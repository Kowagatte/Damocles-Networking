using LiteNetLib;
using LiteNetLib.Utils;

namespace Networking.Events {
    
    [NetworkEvent(NetworkEvents.PlayerInput)]
    public struct PlayerInputEvent : Event {

        private PlayerInputs _input;
        private float _pitch, _yaw;

        public PlayerInputEvent(PlayerInputs input, float pitch, float yaw) {
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
        
    }
}