namespace DocumentModel.Drawing;

/// <summary>
/// If.
/// </summary>
public interface IDiagramChooseIf // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<AxisKind>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<ElementKind>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<Boolean>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<Int32>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<UInt32>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<Int32>? Step { get ; set; }
  
  /// <summary>
  /// Function
  /// </summary>
  public FunctionKind? Function { get ; set; }
  
  /// <summary>
  /// Argument
  /// </summary>
  public String? Argument { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public FunctionOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
  public Collection<IAlgorithm>? Algorithms { get ; set; }
  
  public Collection<IShape>? Shapes { get ; set; }
  
  public Collection<IPresentationOf>? PresentationOfs { get ; set; }
  
  public Collection<IConstraints>? Constraintses { get ; set; }
  
  public Collection<IRuleList>? RuleLists { get ; set; }
  
  public Collection<IForEach>? ForEachs { get ; set; }
  
  public Collection<ILayoutNode>? LayoutNodes { get ; set; }
  
  public Collection<IChoose>? Chooses { get ; set; }
  
  public Collection<IExtensionList>? ExtensionLists { get ; set; }
  
}
