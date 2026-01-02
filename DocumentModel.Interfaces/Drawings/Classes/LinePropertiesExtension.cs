namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LinePropertiesExtension Class.
/// </summary>
public class LinePropertiesExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public LineSketchStyleProperties? LineSketchStyleProperties { get; set; }
}