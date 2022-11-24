namespace DocumentModel.Vml;

/// <summary>
/// Single Formula.
/// </summary>
public interface IFormula // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Equation
  /// </summary>
  public String? Equation { get ; set; }
  
}
