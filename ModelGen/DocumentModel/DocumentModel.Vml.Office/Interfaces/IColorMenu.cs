namespace DocumentModel.Vml.Office;

/// <summary>
/// UI Default Colors.
/// </summary>
public interface IColorMenu // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Default stroke color
  /// </summary>
  public string? StrokeColor { get ; set; }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  public string? FillColor { get ; set; }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  public string? ShadowColor { get ; set; }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  public string? ExtrusionColor { get ; set; }
  
}
