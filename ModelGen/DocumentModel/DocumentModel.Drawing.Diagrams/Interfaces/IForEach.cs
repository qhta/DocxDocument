namespace DocumentModel.Drawing.Diagrams;

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
  public System.Collections.Generic.List<DocumentModel.Drawing.Diagrams.AxisKind>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public System.Collections.Generic.List<DocumentModel.Drawing.Diagrams.ElementKind>? PointType { get ; set; }
  
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
  
  public DocumentModel.Drawing.Diagrams.IAlgorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IPresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IConstraints? Constraints { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IRuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.ILayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IChoose? Choose { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
