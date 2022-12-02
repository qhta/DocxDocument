namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public interface IChartText // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// String Reference.
  /// </summary>
  public DocumentModel.Drawing.IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public DocumentModel.Drawing.IRichText? RichText { get ; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public DocumentModel.Drawing.IStringLiteral? StringLiteral { get ; set; }
  
}
