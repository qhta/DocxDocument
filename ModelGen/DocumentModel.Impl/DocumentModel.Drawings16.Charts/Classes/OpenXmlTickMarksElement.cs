namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public class OpenXmlTickMarksElementImpl: ModelElementImpl, OpenXmlTickMarksElement
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlTickMarksElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlTickMarksElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlTickMarksElementImpl(): base() {}
  
  public OpenXmlTickMarksElementImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlTickMarksElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TickMarksType? Type
  {
    get => (DocumentModel.Drawings16.Charts.TickMarksType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
