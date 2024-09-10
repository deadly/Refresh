using Realms;
using Refresh.GameServer.Types.UserData;

namespace Refresh.GameServer.Types.Relations;
#nullable disable

public partial class BlockUserRelation : IRealmObject
{
    public GameUser UserToBlock { get; set; }
    public GameUser UserBlocking { get; set; }
}
