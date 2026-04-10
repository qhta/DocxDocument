namespace DocumentModel;
/// <summary>
///   IHyperlink List.
/// </summary>
[SimpleType]
[OpenXmlType(typeof(HyperlinkInfo))]
[XmlRoot("HyperlinkList", Namespace = "DocumentModel")]
public class HyperlinkList : ElementCollection<HyperlinkInfo>
{
 /// <summary>
 /// Default constructor.
 /// </summary>
 public HyperlinkList()
 {
 }

 /// <summary>
 /// Initializes a new instance of the HyperlinkList class with the specified collection of hyperlink information.
 /// </summary>
 /// <param name = "HyperlinkInfos">The collection of HyperlinkInfo objects to include in the list. Cannot be null.</param>
 public HyperlinkList(IEnumerable<HyperlinkInfo> HyperlinkInfos) : base(HyperlinkInfos)
 {
 }
}