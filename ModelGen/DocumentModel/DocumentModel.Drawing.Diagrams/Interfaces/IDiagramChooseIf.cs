namespace DocumentModel.Drawing.Diagrams;

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
  public IListValue<DocumentFormat.OpenXml.EnumValue<AxisValues>>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.EnumValue<ElementValues>>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.BooleanValue>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.Int32Value>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.UInt32Value>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.Int32Value>? Step { get ; set; }
  
  /// <summary>
  /// Function
  /// </summary>
  public FunctionValues? Function { get ; set; }
  
  /// <summary>
  /// Argument
  /// </summary>
  public String? Argument { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public FunctionOperatorValues? Operator { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
}
