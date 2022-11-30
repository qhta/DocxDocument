namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public interface IChartSpace // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// ChartData.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IChartData? ChartData { get ; set; }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IChart? Chart { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IColorMappingType? ColorMappingType { get ; set; }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IFormatOverrides? FormatOverrides { get ; set; }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IPrintSettings? PrintSettings { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
