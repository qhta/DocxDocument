namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LinePropertiesExtension interface.
/// </summary>
public interface LinePropertiesExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public LineSketchStyleProperties? LineSketchStyleProperties { get; set; }
}