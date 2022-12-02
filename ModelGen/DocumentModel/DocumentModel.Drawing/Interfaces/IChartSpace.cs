namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public interface IChartSpace // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// ChartData.
  /// </summary>
  public IChartData? ChartData { get ; set; }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public IChart? Chart { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  public IColorMappingType? ColorMappingType { get ; set; }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public IFormatOverrides? FormatOverrides { get ; set; }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public IPrintSettings? PrintSettings { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
