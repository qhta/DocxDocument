namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public class ChartSpaceImpl: ModelElementImpl, ChartSpace
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartSpaceImpl(): base() {}
  
  public ChartSpaceImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ChartData.
  /// </summary>
  public ChartData? ChartData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public Chart? Chart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  public ColorMappingType? ColorMappingType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public FormatOverrides? FormatOverrides
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public PrintSettings? PrintSettings
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
