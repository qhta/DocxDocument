namespace DocumentModel.Vml;

/// <summary>
/// Ink.
/// </summary>
public interface Ink
{
  /// <summary>
  /// Ink Data
  /// </summary>
  public Base64BinaryValue? InkData { get ; set; }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public Boolean? AnnotationFlag { get ; set; }
  
}
