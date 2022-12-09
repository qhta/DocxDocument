namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Extension2 Class.
/// </summary>
public class Extension2Impl: ModelElementImpl, Extension2
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// uri, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
}
