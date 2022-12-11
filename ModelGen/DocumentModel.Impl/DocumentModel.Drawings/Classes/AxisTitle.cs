namespace DocumentModel.Drawings;

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
