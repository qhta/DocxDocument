namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public class AxisUnitsImpl: ModelElementImpl, AxisUnits
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AxisUnitsImpl(): base() {}
  
  public AxisUnitsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.AxisUnit? Unit
  {
    get => (DocumentModel.Drawings16.Charts.AxisUnit?)OpenXmlElement?.Unit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Unit = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit?)value;
    }
  }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public DocumentModel.Drawings16.Charts.AxisUnitsLabel? AxisUnitsLabel
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
