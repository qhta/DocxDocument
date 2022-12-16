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
  
  public WebSettingsImpl(): base() {}
  
  public WebSettingsImpl(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Frameset.
  /// </summary>
  public DocumentModel.Wordprocessing.Frameset? Frameset
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FramesetImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FramesetImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Divs.
  /// </summary>
  public DocumentModel.Wordprocessing.Divs? Divs
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Divs>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DivsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Divs>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DivsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// WebPageEncoding.
  /// </summary>
  public String? WebPageEncoding
  {
    get => (System.String?)OpenXmlElement?.WebPageEncoding?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.WebPageEncoding != null)
        {
          if (value is not null)
            OpenXmlElement.WebPageEncoding.Val = (System.String?)value;
          else
            OpenXmlElement.WebPageEncoding = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.WebPageEncoding = new DocumentFormat.OpenXml.Wordprocessing.WebPageEncoding{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// OptimizeForBrowser.
  /// </summary>
  public Boolean? OptimizeForBrowser
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OptimizeForBrowser>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OptimizeForBrowser>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.OptimizeForBrowser();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  public Boolean? RelyOnVML
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelyOnVML>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelyOnVML>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.RelyOnVML();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  public Boolean? AllowPNG
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowPNG>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowPNG>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AllowPNG();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  public Boolean? DoNotRelyOnCSS
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotRelyOnCSS>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotRelyOnCSS>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotRelyOnCSS();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  public Boolean? DoNotSaveAsSingleFile
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSaveAsSingleFile>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSaveAsSingleFile>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotSaveAsSingleFile();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  public Boolean? DoNotOrganizeInFolder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotOrganizeInFolder>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotOrganizeInFolder>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotOrganizeInFolder();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  public Boolean? DoNotUseLongFileNames
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseLongFileNames>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseLongFileNames>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseLongFileNames();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  public Int32? PixelsPerInch
  {
    get => (System.Int32?)OpenXmlElement?.PixelsPerInch?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PixelsPerInch != null)
        {
          if (value is not null)
            OpenXmlElement.PixelsPerInch.Val = (System.Int32?)value;
          else
            OpenXmlElement.PixelsPerInch = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PixelsPerInch = new DocumentFormat.OpenXml.Wordprocessing.PixelsPerInch{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  public DocumentModel.Wordprocessing.TargetScreenSizeKind? TargetScreenSize
  {
    get => (DocumentModel.Wordprocessing.TargetScreenSizeKind?)OpenXmlElement?.TargetScreenSize?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TargetScreenSize != null)
        {
          if (value is not null)
            OpenXmlElement.TargetScreenSize.Val = (DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues?)value;
          else
            OpenXmlElement.TargetScreenSize = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TargetScreenSize = new DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize{ Val = (DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues?)value };
        }
      }
    }
  }
  
}
