namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public class ExternalDataImpl: ModelElementImpl, ExternalData
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExternalDataImpl(): base() {}
  
  public ExternalDataImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? AutoUpdate
  {
    get => (System.Boolean?)OpenXmlElement?.AutoUpdate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AutoUpdate = (System.Boolean?)value;
    }
  }
  
}
