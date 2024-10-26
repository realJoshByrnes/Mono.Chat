using MSNChatControl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono.Chat
{
    internal class ChatFrameManager
    {
        private int instanceId;
        Dictionary<int, ChatFrame> chatFrames;

        public ChatFrameManager()
        {
            // Initialize the dictionary
            chatFrames = new Dictionary<int, ChatFrame>();
        }

        public ChatFrame createChatFrame()
        {
            // Create a new ChatFrame instance
            ChatFrame chatFrame = new ChatFrame();

            // TODO: We override the params here.
            var originalServer = chatFrame.Server;

            // Add the ChatFrame instance to the dictionary
            chatFrames.Add(instanceId++, chatFrame);
            // Return the ChatFrame instance
            return chatFrame;
        }

        public ChatFrame getChatFrame(int instanceId)
        {
            // Get the ChatFrame instance from the dictionary
            return chatFrames[instanceId];
        }

        public Dictionary<int, ChatFrame> getChatFrames()
        {
            return chatFrames;
        }

        public void removeChatFrame(int instanceId)
        {
            this.getChatFrame(instanceId).Dispose();
            // Remove the ChatFrame instance from the dictionary
            chatFrames.Remove(instanceId);
        }
    }
}
