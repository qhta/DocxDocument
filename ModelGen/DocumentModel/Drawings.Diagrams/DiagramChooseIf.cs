namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   If.
/// </summary>
public partial class DiagramChooseIf
{
  
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Axis
  /// </summary>
  public DM.ListOf<AxisKind>? Axis { get; set; }
  
  
  /// <summary>
  ///   Data Point Type
  /// </summary>
  public DM.ListOf<ElementKind>? PointType { get; set; }
  
  
  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  public DM.ListOf<Boolean>? HideLastTrans { get; set; }
  
  
  /// <summary>
  ///   Start
  /// </summary>
  public DM.ListOf<Int32>? Start { get; set; }
  
  
  /// <summary>
  ///   Count
  /// </summary>
  public DM.ListOf<UInt32>? Count { get; set; }
  
  
  /// <summary>
  ///   Step
  /// </summary>
  public DM.ListOf<Int32>? Step { get; set; }
  
  
  /// <summary>
  ///   Function
  /// </summary>
  public DocumentModel.Drawings.Diagrams.FunctionKind? Function { get; set; }
  
  
  /// <summary>
  ///   Argument
  /// </summary>
  public String? Argument { get; set; }
  
  
  /// <summary>
  ///   Operator
  /// </summary>
  public DocumentModel.Drawings.Diagrams.FunctionOperatorKind? Operator { get; set; }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  public String? Val { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
