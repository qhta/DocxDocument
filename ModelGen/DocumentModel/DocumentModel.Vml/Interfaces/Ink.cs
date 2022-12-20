namespace DocumentModel.Vml;

/// <summary>
/// Ink.
/// </summary>
public partial interface Ink
{
  /// <summary>
  /// Ink Data
  /// </summary>
  public DocumentModel.Base64Binary? InkData { get; set; }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public Boolean? AnnotationFlag { get; set; }
  
}
