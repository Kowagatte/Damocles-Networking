using System;
using LiteNetLib;
using LiteNetLib.Utils;
namespace Networking.Events {
    
    [NetworkEvent(NetworkEvents.JOIN)]
    public struct JoinEvent : Event {

        string JoinMessage;

        public JoinEvent(String joinMessage) {
            JoinMessage = joinMessage;
        }
        
        public bool WritePacket(NetDataWriter writer) {
            writer.Put((byte)NetworkEvents.JOIN);
            writer.Put(JoinMessage);
            return true;
        }

        public void ReadPacket(NetPacketReader reader) {
            JoinMessage = reader.GetString();
        }

        public void Invoke() { }
    }
}