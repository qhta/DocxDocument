namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public class ChartSpace1Impl: ModelElementImpl, ChartSpace1
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ChartData.
  /// </summary>
  public ChartData? ChartData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public Chart1? Chart
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody
  {
    get;
    set;
  }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  public ColorMappingType2? ColorMappingType
  {
    get;
    set;
  }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public FormatOverrides? FormatOverrides
  {
    get;
    set;
  }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public PrintSettings2? PrintSettings
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
