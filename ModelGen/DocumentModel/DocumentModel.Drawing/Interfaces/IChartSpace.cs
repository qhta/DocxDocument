namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public interface IChartSpace // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// ChartData.
  /// </summary>
  public DocumentModel.Drawing.IChartData? ChartData { get ; set; }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public DocumentModel.Drawing.IChart? Chart { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawing.ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  public DocumentModel.Drawing.IColorMappingType? ColorMappingType { get ; set; }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public DocumentModel.Drawing.IFormatOverrides? FormatOverrides { get ; set; }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public DocumentModel.Drawing.IPrintSettings? PrintSettings { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
