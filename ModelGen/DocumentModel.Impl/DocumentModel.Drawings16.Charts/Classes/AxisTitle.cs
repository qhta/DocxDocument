namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the AxisTitle Class.
/// </summary>
public class AxisTitleImpl: ModelElementImpl, AxisTitle
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AxisTitleImpl(): base() {}
  
  public AxisTitleImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle openXmlElement): base(openXmlElement)
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
