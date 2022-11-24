namespace DocumentModel.Math;

/// <summary>
/// Break on Binary Operators.
/// </summary>
public interface IBreakBinary // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public BreakBinaryOperatorValues? Val { get ; set; }
  
}
