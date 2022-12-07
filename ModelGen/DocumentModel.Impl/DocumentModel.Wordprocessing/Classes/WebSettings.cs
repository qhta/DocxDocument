namespace DocumentModel.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
public class WebSettingsImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.WebSettings>, WebSettings
{
  /// <summary>
  /// Frameset.
  /// </summary>
  public Frameset? Frameset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Divs.
  /// </summary>
  public Divs? Divs
  {
    get;
    set;
  }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  public TargetScreenSizeKind? TargetScreenSize
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize>();
        return (TargetScreenSizeKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize{ Val = (DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
