namespace DocumentModel.Vml;

/// <summary>
/// Single Formula.
/// </summary>
public interface IFormula // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Equation
  /// </summary>
  public string? Equation { get ; set; }
  
}
