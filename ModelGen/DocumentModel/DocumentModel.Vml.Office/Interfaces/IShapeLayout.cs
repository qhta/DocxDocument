namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public interface IShapeLayout // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  public IShapeIdMap? ShapeIdMap { get ; set; }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public IRegroupTable? RegroupTable { get ; set; }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public IRules? Rules { get ; set; }
  
}
