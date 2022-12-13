namespace DocumentModel.Drawings;

/// <summary>
/// If.
/// </summary>
public interface DiagramChooseIf
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<DocumentModel.Drawings.AxisKind>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<DocumentModel.Drawings.ElementKind>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<System.Boolean>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<System.Int32>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<System.UInt32>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<System.Int32>? Step { get ; set; }
  
  /// <summary>
  /// Function
  /// </summary>
  public DocumentModel.Drawings.FunctionKind? Function { get ; set; }
  
  /// <summary>
  /// Argument
  /// </summary>
  public String? Argument { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public DocumentModel.Drawings.FunctionOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
  public DocumentModel.Drawings.Algorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawings.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.PresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawings.Constraints? Constraints { get ; set; }
  
  public DocumentModel.Drawings.RuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawings.ForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawings.LayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawings.Choose? Choose { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
