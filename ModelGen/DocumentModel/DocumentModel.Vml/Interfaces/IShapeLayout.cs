namespace DocumentModel.Vml;

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
  public DocumentModel.Vml.IShapeIdMap? ShapeIdMap { get ; set; }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public DocumentModel.Vml.IRegroupTable? RegroupTable { get ; set; }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public DocumentModel.Vml.IRules? Rules { get ; set; }
  
}
