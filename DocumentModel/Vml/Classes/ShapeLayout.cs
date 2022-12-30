namespace DocumentModel.Vml;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public partial class ShapeLayout
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  public DocumentModel.Vml.ShapeIdMap? ShapeIdMap { get; set; }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public DocumentModel.Vml.RegroupTable? RegroupTable { get; set; }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public DocumentModel.Vml.Rules? Rules { get; set; }
  
}
