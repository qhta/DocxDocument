namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for line properties, providing additional configuration or metadata.
/// </summary>
public interface LinePropertiesExtension: CollectionItem
{
  /// <summary>
  ///   Uniform Resource Identifier for the extension.
  /// </summary>
  public string? Uri { get; set; }

  /// <summary>
  ///   Sketch style properties for the line.
  /// </summary>
  public LineSketchStyleProperties? LineSketchStyleProperties { get; set; }
}