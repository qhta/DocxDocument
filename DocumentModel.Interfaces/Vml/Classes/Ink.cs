namespace DocumentModel.Vml;

/// <summary>
///   Ink.
/// </summary>
public interface Ink: IModelElement
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