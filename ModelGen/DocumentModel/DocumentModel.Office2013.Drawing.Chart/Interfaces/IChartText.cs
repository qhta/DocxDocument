namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public interface IChartText // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// String Reference.
  /// </summary>
  public IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public IRichText? RichText { get ; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public IStringLiteral? StringLiteral { get ; set; }
  
}
