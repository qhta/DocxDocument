namespace DocumentModel.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
public class WebSettingsImpl: ModelElementImpl, WebSettings
{
  public DocumentFormat.OpenXml.Wordprocessing.WebSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.WebSettings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// WebPageEncoding.
  /// </summary>
  public String? WebPageEncoding
  {
    get;
    set;
  }
  
  /// <summary>
  /// OptimizeForBrowser.
  /// </summary>
  public Boolean? OptimizeForBrowser
  {
    get;
    set;
  }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  public Boolean? RelyOnVML
  {
    get;
    set;
  }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  public Boolean? AllowPNG
  {
    get;
    set;
  }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  public Boolean? DoNotRelyOnCSS
  {
    get;
    set;
  }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  public Boolean? DoNotSaveAsSingleFile
  {
    get;
    set;
  }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  public Boolean? DoNotOrganizeInFolder
  {
    get;
    set;
  }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  public Boolean? DoNotUseLongFileNames
  {
    get;
    set;
  }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  public Int32? PixelsPerInch
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
