namespace DocumentModel.Wordprocessing;

/// <summary>
/// A reference mark for an endnote within a WordprocessingML document. 
/// </summary>
/// <remarks>An endnote reference mark is used to indicate the location in the document where an endnote is referenced.
/// This element is typically rendered as a superscripted number in the document text. The actual endnote content is stored
/// separately and linked to this reference mark.</remarks>
[DataContract]
[XmlRoot("EndnoteReferenceMark", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.EndnoteReferenceMark))]
public class EndnoteReferenceMark: ModelElement<DXW.EndnoteReferenceMark>
{
  
}