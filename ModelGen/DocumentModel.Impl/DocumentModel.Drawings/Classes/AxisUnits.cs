namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public AxisUnit? Unit
  {
    get => (AxisUnit?)OpenXmlElement?.Unit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Unit = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit?)value;
    }
  }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public AxisUnitsLabel? AxisUnitsLabel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
