namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public interface IShapeLayout // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  public DocumentModel.Vml.Office.IShapeIdMap? ShapeIdMap { get ; set; }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public DocumentModel.Vml.Office.IRegroupTable? RegroupTable { get ; set; }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public DocumentModel.Vml.Office.IRules? Rules { get ; set; }
  
}
