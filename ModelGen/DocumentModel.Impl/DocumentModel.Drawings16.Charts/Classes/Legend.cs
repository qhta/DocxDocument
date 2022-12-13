namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Legend Class.
/// </summary>
public class LegendImpl: ModelElementImpl, Legend
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LegendImpl(): base() {}
  
  public LegendImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.SidePos? Pos
  {
    get => (DocumentModel.Drawings16.Charts.SidePos?)OpenXmlElement?.Pos?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pos = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos?)value;
    }
  }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PosAlign? Align
  {
    get => (DocumentModel.Drawings16.Charts.PosAlign?)OpenXmlElement?.Align?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Overlay?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Overlay = (System.Boolean?)value;
    }
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
