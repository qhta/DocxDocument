namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a continuation separator mark within a WordprocessingML document.
/// </summary>
/// <remarks>A continuation separator mark is used to indicate the continuation of content from a previous section or page.
/// This element is typically rendered as a horizontal line or other visual separator in the document text.</remarks>
[DataContract]
[XmlRoot("ContinuationSeparatorMark", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.ContinuationSeparatorMark))]
public class ContinuationSeparatorMark : ModelElement<DXW.ContinuationSeparatorMark>
{

}