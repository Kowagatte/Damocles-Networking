namespace Networking {
    
    [System.AttributeUsage(System.AttributeTargets.Struct)]
    public class PacketAttribute : System.Attribute {

        public NamedPackets Packet { get; private set; }

        public PacketAttribute(NamedPackets p) {
            Packet = p;
        }
    }
}