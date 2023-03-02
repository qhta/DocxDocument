namespace DocumentModel.Vml;

/// <summary>
///   Ink.
/// </summary>
public record Ink
{
  /// <summary>
  ///   Ink Data
  /// </summary>
  public Base64Binary? InkData { get; set; }

  /// <summary>
  ///   Annotation Flag
  /// </summary>
  public Boolean? AnnotationFlag { get; set; }
}