namespace DocumentModel.Drawings;

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
  public Text? Text
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
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
