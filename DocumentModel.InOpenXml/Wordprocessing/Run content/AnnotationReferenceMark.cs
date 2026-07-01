namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a reference mark for an annotation within a WordprocessingML document.
/// </summary>
/// <remarks>An annotation reference mark is used to indicate the location in the document where an annotation,
/// such as a comment or note, is referenced. This element is typically rendered as a superscripted symbol or number in
/// the document text. The actual annotation content is stored separately and linked to this reference mark.</remarks>
[DataContract]
[XmlRoot("AnnotationReferenceMark", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.AnnotationReferenceMark))]
public class AnnotationReferenceMark: ModelElement<DXW.AnnotationReferenceMark>
{
  
}