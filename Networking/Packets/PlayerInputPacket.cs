using Damocles.Networking.Commands;
using LiteNetLib;
using LiteNetLib.Utils;

namespace Networking.Packets {
    
    [PacketAttribute(NamedPackets.PlayerInput)]
    public struct PlayerInputPacket : IPacket {
        
        public PlayerInputs _input;
        public float _pitch, _yaw;

        public PlayerInputPacket(PlayerInputs input, float pitch, float yaw) {
            _input = input;
            _pitch = pitch;
            _yaw = yaw;
        }
        
        public bool WritePacket(NetDataWriter writer) {
            writer.Put((byte)_input);
            writer.Put(_pitch);
            writer.Put(_yaw);
            return true;
        }

        public void ReadPacket(NetPacketReader reader) {
            _input = (PlayerInputs)reader.GetByte();
            _pitch = reader.GetFloat();
            _yaw = reader.GetFloat();
        }

        public void Invoke() {
            new PlayerInputCommand().Execute(this);
        }
    }
}