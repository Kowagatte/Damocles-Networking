using LiteNetLib;
using LiteNetLib.Utils;

namespace Networking {
    public interface IPacket {
        
        /// <summary>
        /// Writes the packet to the given NetDataWriter
        /// </summary>
        /// <param name="writer"> NetDataWriter to be written too. </param>
        /// <returns> true if successfully written, false otherwise. </returns>
        bool WritePacket(NetDataWriter writer);

        /// <summary>
        /// Reads the packet from the given NetPacketReader
        /// </summary>
        /// <param name="reader"></param>
        void ReadPacket(NetPacketReader reader);

        /// <summary>
        /// Calls Command corresponding to the Packet.
        /// </summary>
        void Invoke();

    }
}