namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public interface IChartText // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// String Reference.
  /// </summary>
  public DocumentModel.Drawing.Charts.IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITextBodyType? RichText { get ; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public DocumentModel.Drawing.Charts.IStringDataType? StringLiteral { get ; set; }
  
}
