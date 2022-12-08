namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public interface LinePropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public LineSketchStyleProperties? LineSketchStyleProperties { get ; set; }
  
}
