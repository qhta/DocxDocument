namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Ink.
/// </summary>
public class Ink: ModelElement
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