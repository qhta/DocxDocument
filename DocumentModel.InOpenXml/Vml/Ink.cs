namespace DocumentModel.Vml;

/// <summary>
///   Ink.
/// </summary>
public class Ink: ModelElement<DXVO.Ink>
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