namespace DocumentModel.Vml;

/// <summary>
///   Ink.
/// </summary>
public class Ink: ModelElement
{
  /// <summary>
  ///   Ink Data
  /// </summary>
  public IBase64Binary? InkData { get; set; }
  /// <summary>
  ///   Annotation Flag
  /// </summary>
  public bool? AnnotationFlag { get; set; }
}