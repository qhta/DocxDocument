namespace DocumentModel.Drawings;

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