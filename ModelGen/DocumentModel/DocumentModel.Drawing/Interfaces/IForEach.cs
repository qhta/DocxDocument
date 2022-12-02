namespace DocumentModel.Drawing;

/// <summary>
/// For Each.
/// </summary>
public interface IForEach // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public System.Collections.Generic.List<DocumentModel.Drawing.AxisKind>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public System.Collections.Generic.List<DocumentModel.Drawing.ElementKind>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public System.Collections.Generic.List<System.Boolean>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public System.Collections.Generic.List<System.Int32>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public System.Collections.Generic.List<System.UInt32>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public System.Collections.Generic.List<System.Int32>? Step { get ; set; }
  
  public DocumentModel.Drawing.IAlgorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.IPresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawing.IConstraints? Constraints { get ; set; }
  
  public DocumentModel.Drawing.IRuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawing.IForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawing.ILayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawing.IChoose? Choose { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
