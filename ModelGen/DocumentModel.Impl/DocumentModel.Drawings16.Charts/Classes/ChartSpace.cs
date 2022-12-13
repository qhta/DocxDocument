namespace DocumentModel.Drawings16.Charts;

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
  public DocumentModel.Drawings16.Charts.ChartData? ChartData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public DocumentModel.Drawings16.Charts.Chart? Chart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TxPrTextBody? TxPrTextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ColorMappingType? ColorMappingType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public DocumentModel.Drawings16.Charts.FormatOverrides? FormatOverrides
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PrintSettings? PrintSettings
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
