namespace DocumentModel.Vml.Office;


/// <summary>
///   VML Diagram.
/// </summary>
public partial class Diagram
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Diagram Style Options
  /// </summary>
  [SchemaAttr("dgmstyle")]
  public Int64? Style { get; set; }
  
  
  /// <summary>
  ///   Diagram Automatic Format
  /// </summary>
  [SchemaAttr("autoformat")]
  public Boolean? AutoFormat { get; set; }
  
  
  /// <summary>
  ///   Diagram Reverse Direction
  /// </summary>
  [SchemaAttr("reverse")]
  public Boolean? Reverse { get; set; }
  
  
  /// <summary>
  ///   Diagram Automatic Layout
  /// </summary>
  [SchemaAttr("autolayout")]
  public Boolean? AutoLayout { get; set; }
  
  
  /// <summary>
  ///   Diagram Layout X Scale
  /// </summary>
  [SchemaAttr("dgmscalex")]
  public Int64? ScaleX { get; set; }
  
  
  /// <summary>
  ///   Diagram Layout Y Scale
  /// </summary>
  [SchemaAttr("dgmscaley")]
  public Int64? ScaleY { get; set; }
  
  
  /// <summary>
  ///   Diagram Font Size
  /// </summary>
  [SchemaAttr("dgmfontsize")]
  public Int64? FontSize { get; set; }
  
  
  /// <summary>
  ///   Diagram Layout Extents
  /// </summary>
  [SchemaAttr("constrainbounds")]
  public String? ConstrainBounds { get; set; }
  
  
  /// <summary>
  ///   Diagram Base Font Size
  /// </summary>
  [SchemaAttr("dgmbasetextscale")]
  public Int64? BaseTextScale { get; set; }
  
  
  /// <summary>
  ///   Diagram Relationship Table.
  /// </summary>
  public DocumentModel.Vml.Office.RelationTable? RelationTable { get; set; }
  
}
