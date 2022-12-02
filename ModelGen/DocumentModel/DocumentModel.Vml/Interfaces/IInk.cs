namespace DocumentModel.Vml;

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
  public Boolean? AnnotationFlag { get ; set; }
  
}
