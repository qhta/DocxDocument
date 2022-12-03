namespace DocumentModel.Vml;

/// <summary>
/// Ink.
/// </summary>
public interface Ink // : System.Boolean
{
  /// <summary>
  /// Ink Data
  /// </summary>
  public DocumentModel.Base64BinaryValue? InkData { get ; set; }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public Boolean? AnnotationFlag { get ; set; }
  
}
