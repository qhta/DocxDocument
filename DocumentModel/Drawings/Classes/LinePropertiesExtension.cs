namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public partial class LinePropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.LineSketchStyleProperties? LineSketchStyleProperties { get; set; }
  
}
