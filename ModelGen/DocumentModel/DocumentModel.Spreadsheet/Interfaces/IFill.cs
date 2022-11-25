namespace DocumentModel.Spreadsheet;

/// <summary>
/// Fill.
/// </summary>
public interface IFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pattern.
  /// </summary>
  public DocumentModel.Spreadsheet.IPatternFill? PatternFill { get ; set; }
  
  /// <summary>
  /// Gradient.
  /// </summary>
  public DocumentModel.Spreadsheet.IGradientFill? GradientFill { get ; set; }
  
}
