namespace DocumentModel.Drawings;

/// <summary>
/// If.
/// </summary>
public interface DiagramChooseIf
{
  /// <summary>
  /// Function
  /// </summary>
  public FunctionKind? Function { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public FunctionOperatorKind? Operator { get ; set; }
  
}
