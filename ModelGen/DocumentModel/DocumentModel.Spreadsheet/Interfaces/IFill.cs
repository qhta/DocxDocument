namespace DocumentModel.Spreadsheet;

/// <summary>
/// Fill.
/// </summary>
public interface IFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pattern.
  /// </summary>
  public IPatternFill? PatternFill { get ; set; }
  
  /// <summary>
  /// Gradient.
  /// </summary>
  public IGradientFill? GradientFill { get ; set; }
  
}
