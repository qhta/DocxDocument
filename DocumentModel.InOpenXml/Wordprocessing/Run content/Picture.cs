namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a picture element within a WordprocessingML document.
/// </summary>
/// <remarks>The Picture class corresponds to the <c>Picture</c> element in the WordprocessingML schema and is used to
/// define images embedded in a document. This class provides a strongly-typed representation for working with picture
/// content in Open XML word processing documents.</remarks>
[DataContract]
[XmlRoot(ElementName = "picture", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.Picture))]
public class Picture: ModelElement<DXW.Picture>
{
  /// <summary>
  /// Identifier for the anchor.
  /// </summary>
  [OpenXmlProperty("AnchorId")]
  public HexBinary? AnchorId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}