namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a tab character in a text run in WordprocessingML documents.
/// A tab character advances the position on the current line of text. If custom tab stops are defined, the tab advances to the next custom tab stop; otherwise, it advances to the nearest multiple of the default tab stop width.
/// </summary>
[OpenXmlType(typeof(DXW.TabChar))]
[XmlRoot("TabChar", Namespace = "DocumentModel.Wordprocessing")]
public class TabChar : ModelElement<DXW.TabChar>, IRunContent
{
}