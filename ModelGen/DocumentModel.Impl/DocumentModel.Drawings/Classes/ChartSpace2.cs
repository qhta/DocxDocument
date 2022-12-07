namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public class ChartSpace2Impl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace>, ChartSpace2
{
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
  public Chart2? Chart
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties
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
  public ColorMappingType1? ColorMappingType
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
