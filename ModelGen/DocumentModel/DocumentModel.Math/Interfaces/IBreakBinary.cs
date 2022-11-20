namespace DocumentModel.Math;

/// <summary>
/// Break on Binary Operators.
/// </summary>
public interface IBreakBinary // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public BreakBinaryOperatorValues? Val { get ; set; }
  
}
