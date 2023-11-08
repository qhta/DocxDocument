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
      var element = _Element?.GetFirstChild<DXW.Frameset>();
      if (element != null)
        return FramesetConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Frameset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FramesetConverter.CreateOpenXmlElement<DXW.Frameset>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Divs>();
      if (element != null)
        return DivsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Divs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DivsConverter.CreateOpenXmlElement<DXW.Divs>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.WebPageEncoding>();
      if (element != null)
        return WebPageEncodingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.WebPageEncoding>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebPageEncodingConverter.CreateOpenXmlElement<DXW.WebPageEncoding>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.OptimizeForBrowser>();
      if (element != null)
        return OptimizeForBrowserConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.OptimizeForBrowser>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OptimizeForBrowserConverter.CreateOpenXmlElement<DXW.OptimizeForBrowser>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.RelyOnVML>();
      if (element != null)
        return RelyOnVMLConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RelyOnVML>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelyOnVMLConverter.CreateOpenXmlElement<DXW.RelyOnVML>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AllowPNG>();
      if (element != null)
        return AllowPNGConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AllowPNG>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AllowPNGConverter.CreateOpenXmlElement<DXW.AllowPNG>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotRelyOnCSS>();
      if (element != null)
        return DoNotRelyOnCSSConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotRelyOnCSS>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotRelyOnCSSConverter.CreateOpenXmlElement<DXW.DoNotRelyOnCSS>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotSaveAsSingleFile>();
      if (element != null)
        return DoNotSaveAsSingleFileConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotSaveAsSingleFile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotSaveAsSingleFileConverter.CreateOpenXmlElement<DXW.DoNotSaveAsSingleFile>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotOrganizeInFolder>();
      if (element != null)
        return DoNotOrganizeInFolderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotOrganizeInFolder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotOrganizeInFolderConverter.CreateOpenXmlElement<DXW.DoNotOrganizeInFolder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotUseLongFileNames>();
      if (element != null)
        return DoNotUseLongFileNamesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotUseLongFileNames>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotUseLongFileNamesConverter.CreateOpenXmlElement<DXW.DoNotUseLongFileNames>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PixelsPerInch>();
      if (element != null)
        return PixelsPerInchConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PixelsPerInch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PixelsPerInchConverter.CreateOpenXmlElement<DXW.PixelsPerInch>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
