namespace DocumentModel.Vml;

/// <summary>
///   Ink.
/// </summary>
public interface Ink
{
  /// <summary>
  ///   Ink Data
  /// </summary>
  public Base64Binary? InkData { get; set; }
  /// <summary>
  ///   Annotation Flag
  /// </summary>
  public bool? AnnotationFlag { get; set; }
}