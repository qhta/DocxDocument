namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of tab stops for text layout and formatting.
/// </summary>
[OpenXmlType(typeof(TabStop))]
[DataContract]
[XmlRoot("TabStopList", Namespace = "DocumentModel.Drawings")]
public class TabStopList : ModelElementCollection<TabStop, DXD.TabStopList, DXD.TabStop>
{
}