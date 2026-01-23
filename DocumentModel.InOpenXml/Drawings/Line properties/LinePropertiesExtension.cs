namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for line properties, providing additional configuration or metadata.
/// </summary>
public class LinePropertiesExtension: ModelElement<DXD.LinePropertiesExtension>, IExtension
{

  /// <summary>
  ///   Sketch style properties for the line.
  /// </summary>
  public LineSketchStyleProperties? LineSketchStyleProperties { get; set; }

  /// <summary>
  ///  URI associated with the line properties extension.
  /// </summary>
  public string? Uri { get; set; }
}