namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LinePropertiesExtension Class.
/// </summary>
public class LinePropertiesExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public LineSketchStyleProperties? LineSketchStyleProperties { get; set; }
}