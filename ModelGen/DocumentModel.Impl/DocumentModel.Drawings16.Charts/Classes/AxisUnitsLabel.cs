namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the AxisUnitsLabel Class.
/// </summary>
public class AxisUnitsLabelImpl: ModelElementImpl, AxisUnitsLabel
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AxisUnitsLabelImpl(): base() {}
  
  public AxisUnitsLabelImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Drawings16.Charts.Text? Text
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
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
