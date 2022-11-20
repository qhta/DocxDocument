namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Layout Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IShapeIdMap))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IRegroupTable))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IRules))]
public interface IShapeLayout // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
