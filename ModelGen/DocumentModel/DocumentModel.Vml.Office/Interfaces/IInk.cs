namespace DocumentModel.Vml.Office;

/// <summary>
/// Ink.
/// </summary>
public interface IInk // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Ink Data
  /// </summary>
  public IBase64BinaryValue? InkData { get ; set; }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public ITrueFalseValue? AnnotationFlag { get ; set; }
  
}
