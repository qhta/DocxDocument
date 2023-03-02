namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LinePropertiesExtension Class.
/// </summary>
public record LinePropertiesExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public LineSketchStyleProperties? LineSketchStyleProperties { get; set; }
}