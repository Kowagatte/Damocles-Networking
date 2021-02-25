namespace Networking {
    public interface ICommand {
        void Execute(IPacket packet);
    }
}