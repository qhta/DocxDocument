namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// For Each.
/// </summary>
public interface ForEach
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public DocumentModel.ListOf<System.Boolean>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public DocumentModel.ListOf<System.Int32>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public DocumentModel.ListOf<System.UInt32>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public DocumentModel.ListOf<System.Int32>? Step { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.Algorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.PresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.Constraints? Constraints { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.RuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.ForEach? ChildForEach { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.LayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.Choose? Choose { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get ; set; }
  
}
