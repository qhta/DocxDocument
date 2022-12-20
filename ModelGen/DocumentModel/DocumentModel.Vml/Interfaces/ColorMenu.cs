namespace DocumentModel.Vml;

/// <summary>
/// UI Default Colors.
/// </summary>
public partial interface ColorMenu
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  /// <summary>
  /// Default stroke color
  /// </summary>
  public String? StrokeColor { get; set; }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  public String? FillColor { get; set; }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  public String? ShadowColor { get; set; }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  public String? ExtrusionColor { get; set; }
  
}
