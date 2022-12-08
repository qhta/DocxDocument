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
    get;
    set;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public Text1? Text
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties
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
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
