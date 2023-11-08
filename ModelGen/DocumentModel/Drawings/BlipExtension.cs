namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class BlipExtension: ModelElement<DXD.BlipExtension>
{
  public BlipExtension(): base(){ }
  
  public BlipExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BlipExtension(DXD.BlipExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMD10.ImageProperties? ImageProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ImageProperties>();
      if (element != null)
        return ImagePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ImageProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImagePropertiesConverter.CreateOpenXmlElement<DXO10D.ImageProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public Boolean? UseLocalDpi
  {
    get
    {
      return _ExistingElement.GetFirstChild<DXO10D.UseLocalDpi>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXO10D.UseLocalDpi>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXO10D.UseLocalDpi();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDW.WebVideoProperty? WebVideoProperty
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13WD.WebVideoProperty>();
      if (element != null)
        return WebVideoPropertyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13WD.WebVideoProperty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebVideoPropertyConverter.CreateOpenXmlElement<DXO13WD.WebVideoProperty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDSVG.SVGBlip? SVGBlip
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO19DSVG.SVGBlip>();
      if (element != null)
        return SVGBlipConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO19DSVG.SVGBlip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SVGBlipConverter.CreateOpenXmlElement<DXO19DSVG.SVGBlip>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PictureAttributionSourceURL? PictureAttributionSourceURL
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO19D.PictureAttributionSourceURL>();
      if (element != null)
        return PictureAttributionSourceURLConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO19D.PictureAttributionSourceURL>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureAttributionSourceURLConverter.CreateOpenXmlElement<DXO19D.PictureAttributionSourceURL>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW20.OEmbed? OEmbed
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOW20OE.OEmbed>();
      if (element != null)
        return OEmbedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOW20OE.OEmbed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OEmbedConverter.CreateOpenXmlElement<DXOW20OE.OEmbed>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDOE.OEmbedShared? OEmbedShared
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD21OE.OEmbedShared>();
      if (element != null)
        return OEmbedSharedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD21OE.OEmbedShared>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OEmbedSharedConverter.CreateOpenXmlElement<DXOD21OE.OEmbedShared>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
