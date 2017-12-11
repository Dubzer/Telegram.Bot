﻿using Telegram.Bot.Types;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Export an invite link to a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights.
    /// </summary>
    public class ExportChatInviteLinkRequest : RequestBase<string>
    {
        /// <summary>
        /// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
        /// </summary>
        public ChatId ChatId { get; set; }

        /// <summary>
        /// Initializes a new request
        /// </summary>
        public ExportChatInviteLinkRequest()
            : base("exportChatInviteLink")
        { }

        /// <summary>
        /// Initializes a new request with chatId
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel.</param>
        public ExportChatInviteLinkRequest(ChatId chatId)
            : this()
        {
            ChatId = chatId;
        }
    }
}
