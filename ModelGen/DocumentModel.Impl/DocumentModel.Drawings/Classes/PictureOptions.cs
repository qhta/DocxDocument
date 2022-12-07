namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public class PictureOptionsImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>, PictureOptions
{
  /// <summary>
  /// Picture Format.
  /// </summary>
  public PictureFormatKind? PictureFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
        return (PictureFormatKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.PictureFormat{ Val = (DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
