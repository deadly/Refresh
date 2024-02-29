using System.Xml.Serialization;

namespace Refresh.GameServer.Types.Lists;

public abstract class SerializedList<TItem>
{
    [XmlAttribute("total")]
    public int Total { get; set; }

    [XmlAttribute("hint_start")] 
    public int NextPageStart { get; set; }
    
    [XmlIgnore]
    public abstract List<TItem> Items { get; set; }
}