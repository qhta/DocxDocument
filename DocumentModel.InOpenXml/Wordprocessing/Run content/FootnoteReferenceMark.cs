namespace DocumentModel.Wordprocessing;

/// <summary>
/// A reference mark for a footnote within a WordprocessingML document. 
/// </summary>
/// <remarks>A footnote reference mark is used to indicate the location in the document where a footnote is referenced.
/// This element is typically rendered as a superscripted number in the document text. The actual footnote content is stored
/// separately and linked to this reference mark.</remarks>
[XmlRoot("FootnoteReferenceMark", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.FootnoteReferenceMark))]
public class FootnoteReferenceMark: ModelElement<DXW.FootnoteReferenceMark>
{
  
}