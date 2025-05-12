using ClashRoyale.Logic;
using ClashRoyale.Protocol.Messages.Server;
using DotNetty.Buffers;
using System.Threading;

namespace ClashRoyale.Protocol.Messages.Client.Sector
{
    public class StartMissionMessage : PiranhaMessage
    {
        public StartMissionMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            Id = 14104;
            RequiredState = Device.State.Home;
        }

        public override async void Process()
        {
            //Thread.Sleep(5000);
            await new NpcSectorStateMessage(Device).SendAsync();
        }
    }
}