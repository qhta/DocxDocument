using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the presence of a hyperlink at the current location in a WordprocessingML document.
/// This class extends <see cref = "IParagraphContent"/>, <see cref = "ISdtRunContent"/>, <see cref = "IBidirectionalContent"/>, and <see cref = "IMathArgumentContent"/>, enabling advanced linking, navigation, and integration of hyperlinks within paragraphs, structured document tags, bidirectional content, and mathematical arguments.
/// </summary>
[OpenXmlType(typeof(DXW.Hyperlink))]
[XmlRoot("Hyperlink", Namespace = "DocumentModel.Wordprocessing")]
public class Hyperlink : Hyperlink<DXW.Hyperlink>
{
}