namespace DocumentModel.Vml.Office;


/// <summary>
///   Ink.
/// </summary>
public partial class Ink
{
  
  /// <summary>
  ///   Ink Data
  /// </summary>
  [SchemaAttr("i")]
  public DocumentModel.Base64BinaryValue? InkData { get; set; }
  
  
  /// <summary>
  ///   Annotation Flag
  /// </summary>
  [SchemaAttr("annotation")]
  public Boolean? AnnotationFlag { get; set; }
  
}
