namespace DocumentModel.Vml.Office;


/// <summary>
///   Shape Layout Properties.
/// </summary>
public partial class ShapeLayout
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Shape ID Map.
  /// </summary>
  public DocumentModel.Vml.Office.ShapeIdMap? ShapeIdMap { get; set; }
  
  
  /// <summary>
  ///   Shape Grouping History.
  /// </summary>
  public DocumentModel.Vml.Office.RegroupTable? RegroupTable { get; set; }
  
  
  /// <summary>
  ///   Rule Set.
  /// </summary>
  public DocumentModel.Vml.Office.Rules? Rules { get; set; }
  
}
