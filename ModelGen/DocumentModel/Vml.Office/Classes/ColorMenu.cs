namespace DocumentModel.Vml.Office;


/// <summary>
///   UI Default Colors.
/// </summary>
public partial class ColorMenu
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Default stroke color
  /// </summary>
  [SchemaAttr("strokecolor")]
  public String? StrokeColor { get; set; }
  
  
  /// <summary>
  ///   Default fill color
  /// </summary>
  [SchemaAttr("fillcolor")]
  public String? FillColor { get; set; }
  
  
  /// <summary>
  ///   Default shadow color
  /// </summary>
  [SchemaAttr("shadowcolor")]
  public String? ShadowColor { get; set; }
  
  
  /// <summary>
  ///   Default extrusion color
  /// </summary>
  [SchemaAttr("extrusioncolor")]
  public String? ExtrusionColor { get; set; }
  
}
