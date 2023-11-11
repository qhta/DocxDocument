namespace DocumentModel;


/// <summary>
///   Web Page Settings.
/// </summary>
public partial class WebSettings: ModelElement<DXW.WebSettings>
{
  public WebSettings(): base(){ }
  
  public WebSettings(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebSettings(DXW.WebSettings openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Frameset.
  /// </summary>
  [DataMember]
  public DMW.Frameset? Frameset
  {
    get
    {
      return _Element?.GetObject<DMW.Frameset,DXW.Frameset>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Frameset,DXW.Frameset>(value);
    }
  }
  
  
  /// <summary>
  ///   Divs.
  /// </summary>
  [DataMember]
  public DMW.Divs? Divs
  {
    get
    {
      return _Element?.GetObject<DMW.Divs,DXW.Divs>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Divs,DXW.Divs>(value);
    }
  }
  
  
  /// <summary>
  ///   WebPageEncoding.
  /// </summary>
  [DataMember]
  public DMW.WebPageEncoding? WebPageEncoding
  {
    get
    {
      return _Element?.GetObject<DMW.WebPageEncoding,DXW.WebPageEncoding>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.WebPageEncoding,DXW.WebPageEncoding>(value);
    }
  }
  
  
  /// <summary>
  ///   OptimizeForBrowser.
  /// </summary>
  [DataMember]
  public DMW.OptimizeForBrowser? OptimizeForBrowser
  {
    get
    {
      return _Element?.GetObject<DMW.OptimizeForBrowser,DXW.OptimizeForBrowser>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.OptimizeForBrowser,DXW.OptimizeForBrowser>(value);
    }
  }
  
  
  /// <summary>
  ///   RelyOnVML.
  /// </summary>
  [DataMember]
  public DMW.RelyOnVML? RelyOnVML
  {
    get
    {
      return _Element?.GetObject<DMW.RelyOnVML,DXW.RelyOnVML>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RelyOnVML,DXW.RelyOnVML>(value);
    }
  }
  
  
  /// <summary>
  ///   AllowPNG.
  /// </summary>
  [DataMember]
  public DMW.AllowPNG? AllowPNG
  {
    get
    {
      return _Element?.GetObject<DMW.AllowPNG,DXW.AllowPNG>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AllowPNG,DXW.AllowPNG>(value);
    }
  }
  
  
  /// <summary>
  ///   DoNotRelyOnCSS.
  /// </summary>
  [DataMember]
  public DMW.DoNotRelyOnCSS? DoNotRelyOnCSS
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotRelyOnCSS,DXW.DoNotRelyOnCSS>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotRelyOnCSS,DXW.DoNotRelyOnCSS>(value);
    }
  }
  
  
  /// <summary>
  ///   DoNotSaveAsSingleFile.
  /// </summary>
  [DataMember]
  public DMW.DoNotSaveAsSingleFile? DoNotSaveAsSingleFile
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotSaveAsSingleFile,DXW.DoNotSaveAsSingleFile>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotSaveAsSingleFile,DXW.DoNotSaveAsSingleFile>(value);
    }
  }
  
  
  /// <summary>
  ///   DoNotOrganizeInFolder.
  /// </summary>
  [DataMember]
  public DMW.DoNotOrganizeInFolder? DoNotOrganizeInFolder
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotOrganizeInFolder,DXW.DoNotOrganizeInFolder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotOrganizeInFolder,DXW.DoNotOrganizeInFolder>(value);
    }
  }
  
  
  /// <summary>
  ///   DoNotUseLongFileNames.
  /// </summary>
  [DataMember]
  public DMW.DoNotUseLongFileNames? DoNotUseLongFileNames
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotUseLongFileNames,DXW.DoNotUseLongFileNames>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotUseLongFileNames,DXW.DoNotUseLongFileNames>(value);
    }
  }
  
  
  /// <summary>
  ///   PixelsPerInch.
  /// </summary>
  [DataMember]
  public DMW.PixelsPerInch? PixelsPerInch
  {
    get
    {
      return _Element?.GetObject<DMW.PixelsPerInch,DXW.PixelsPerInch>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PixelsPerInch,DXW.PixelsPerInch>(value);
    }
  }
  
  
  /// <summary>
  ///   TargetScreenSize.
  /// </summary>
  [DataMember]
  public DMW.TargetScreenSizeKind? TargetScreenSize
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(_ExistingElement.GetFirstChild<DXW.TargetScreenSize>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TargetScreenSize>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(itemElement, (DMW.TargetScreenSizeKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TargetScreenSize, DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DMW.TargetScreenSizeKind>((DMW.TargetScreenSizeKind)value));
    }
  }
  
}
