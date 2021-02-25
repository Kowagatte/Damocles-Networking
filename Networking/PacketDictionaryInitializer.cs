using System;
using System.Collections.Generic;
using System.Reflection;

namespace Networking {
    public class PacketDictionaryInitializer {

        public Dictionary<NamedPackets, Type> PacketDict = new Dictionary<NamedPackets, Type>();

        public PacketDictionaryInitializer() {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies) {
                foreach (Type type in assembly.GetTypes()) {
                    if (typeof(IPacket).IsAssignableFrom(type)) {
                        var attr = (PacketAttribute[])type.GetCustomAttributes(typeof(PacketAttribute), false);
                        if (attr.Length == 0 || PacketDict.ContainsKey(attr[0].Packet)) continue;
                        PacketDict.Add(attr[0].Packet, type);
                    }
                }
            }
        }
        
    }
}