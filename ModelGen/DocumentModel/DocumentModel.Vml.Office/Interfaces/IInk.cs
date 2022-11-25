namespace DocumentModel.Vml.Office;

/// <summary>
/// Ink.
/// </summary>
public interface IInk // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Ink Data
  /// </summary>
  public DocumentModel.IBase64BinaryValue? InkData { get ; set; }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public System.Boolean? AnnotationFlag { get ; set; }
  
}
