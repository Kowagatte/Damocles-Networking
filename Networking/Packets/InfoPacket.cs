using LiteNetLib;
using LiteNetLib.Utils;

namespace Networking.Packets {
    
    [PacketAttribute(NamedPackets.Info)]
    public struct InfoPacket : IPacket {
        public string content;

        public InfoPacket(string _content) {
            content = _content;
        }
        
        public bool WritePacket(NetDataWriter writer) {
            writer.Put(content);
            return true;
        }

        public void ReadPacket(NetPacketReader reader) {
            content = reader.GetString();
        }

        public void Invoke() {
            //TODO 
            throw new System.NotImplementedException();
        }
    }
}