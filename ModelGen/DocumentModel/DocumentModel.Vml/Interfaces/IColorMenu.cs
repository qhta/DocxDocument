namespace DocumentModel.Vml;

/// <summary>
/// UI Default Colors.
/// </summary>
public interface IColorMenu // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Default stroke color
  /// </summary>
  public System.String? StrokeColor { get ; set; }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  public System.String? FillColor { get ; set; }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  public System.String? ShadowColor { get ; set; }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  public System.String? ExtrusionColor { get ; set; }
  
}
