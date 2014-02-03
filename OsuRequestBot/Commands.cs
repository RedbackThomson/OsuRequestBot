using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace OsuRequestBot
{
    /// <summary>
    /// Class necessary for sorting through messages 
    /// and acting on the commands
    /// </summary>
    class Commands
    {
        //Declare Variables
        #region Command Variables

        private const bool _requiresMod = false;

        private const string CommandChar = "!";
        private const string RequestCommand = "request";
        private const string RequestShortCommand = "req";
        private const string NowPlayingCommand = "np";
        public static bool RequiresMod { get { return _requiresMod; } }

        private const string BeatmapRegex = "osu.ppy.sh/b/([0-9]{1,})+";
        private const string SongRegex = "osu.ppy.sh/s/([0-9]{1,})+";
        private const string OsuDirectURL = "osu://dl/{0}";
        private static MainForm Form;
        #endregion

        /// <summary>
        /// Adds all ban, timeout and purge messages to the arrays
        /// </summary>
        public static void SetUpMessages()
        {
            
        }

        public static void SetRequests(MainForm form)
        {
            Form = form;
        }

        /// <summary>
        /// Reads the message and commands the bot if necessary
        /// </summary>
        /// <param name="user">The user's name</param>
        /// <param name="message">The sent message</param>
        /// <param name="isMod">Is the user currently a channel op</param>
        public static CommandResponse CommandResponder(string user, string message, bool isMod)
        {
            //Only mods can use the commands
            if (_requiresMod && !isMod) return null;
            //Make sure it starts with the command character
            
            if (message.StartsWith(CommandChar))
            {
                var commandResponse = CommandCheck(user, message);
                if (commandResponse != null) return commandResponse;
            }

            //No commands/censored words were detected
            return null;
        }

        private static CommandResponse CommandCheck(string user, string message)
        {
            //Remove the command character and trim it
            var cleanMessage = message.Remove(0, 1).Trim();
            var cleanSplit = cleanMessage.Split(' ');

            #region Request Commands
            //Check through the request commands
            if((cleanSplit[0].ToLower() == RequestCommand || cleanSplit[0].ToLower() == RequestShortCommand) && (cleanSplit.Length >= 2))
            {
                return ReadRequest(user, cleanMessage.Split(new []{' '}, 2)[1]);
            }
            else if(cleanSplit[0] == NowPlayingCommand)
            {
                return new CommandResponse ("Current Song: " + Form.CurrentSong, CommandResponse.ResponseAction.None);
            }
            #endregion

            return new CommandResponse(CommandResponse.ResponseAction.None);
        }

        public static CommandResponse ReadRequest(string user, string url)
        {
            BeatmapInfo toAdd = null;
            //Is a beatmap request
            var beatmapMatch = Regex.Match(url, BeatmapRegex);
            if(beatmapMatch.Success)
            {
                var id = beatmapMatch.Groups[1].Value;
                int intID;
                if (!int.TryParse(id, out intID)) return CommandResponse.None;
                toAdd = BeatmapFetcher.FetchBeatmapInfo(intID);

                
            }

            var songMatch = Regex.Match(url, SongRegex);
            if(songMatch.Success)
            {
                var id = songMatch.Groups[1].Value;
                int intID;
                if (!int.TryParse(id, out intID)) return CommandResponse.None;
                var set = BeatmapFetcher.FetchSetInfo(intID);
                toAdd = (set.Length >= 1 ? set[set.Length - 1] : null);
            }

            if(toAdd == null) return CommandResponse.None;

            Form.AddRequest(new RequestGridItem { User = user, RequestDate = DateTime.Now, Artist = toAdd.artist, Song = toAdd.title, Link = CreateOsuDirectURL(toAdd.beatmapset_id) });
            return new CommandResponse(CommandResponse.ResponseAction.None) { Message = "Added: " + toAdd.artist + " - " + toAdd.title };
        }

        public static string CreateOsuDirectURL(int rankedID)
        {
            return string.Format(OsuDirectURL, rankedID); 
        }
    }

    /// <summary>
    /// Class for passing command responses
    /// </summary>
    public class CommandResponse
    {
        //Declare Variables
        public string Message;
        public ResponseAction Action;

        //Default none response
        public static CommandResponse None { get { return new CommandResponse(ResponseAction.None); } }

        /// <summary>
        /// Constructor for default response (without custom message)
        /// </summary>
        /// <param name="action">The response action</param>
        public CommandResponse(ResponseAction action)
        {
            Action = action;
        }

        /// <summary>
        /// Constructor for default response
        /// </summary>
        /// <param name="message">The message for the chat</param>
        /// <param name="action">The reponse action</param>
        public CommandResponse(string message, ResponseAction action)
        {
            Message = message;
            Action = action;
        }

        /// <summary>
        /// Enum for handling the actions for responding
        /// </summary>
        public enum ResponseAction
        {
            None = 0,
            Warning = 1,
            Timeout = 2,
            Ban = 3,
            Purge = 4
        }   
    }
}
