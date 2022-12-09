namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartTitle Class.
/// </summary>
public class ChartTitleImpl: ModelElementImpl, ChartTitle
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public SidePos? Pos
  {
    get => (SidePos?)OpenXmlElement?.Pos?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pos = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos?)value;
    }
  }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  public PosAlign? Align
  {
    get => (PosAlign?)OpenXmlElement?.Align?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Align = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign?)value;
    }
  }
  
  /// <summary>
  /// overlay, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Overlay
  {
    get => (Boolean?)OpenXmlElement?.Overlay?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Overlay = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public Text2? Text
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties8? ShapeProperties
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
  public ExtensionList2? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
