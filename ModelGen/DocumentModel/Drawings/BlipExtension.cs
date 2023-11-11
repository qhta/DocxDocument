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
      return _Element?.GetObject<DMD10.ImageProperties,DXO10D.ImageProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ImageProperties,DXO10D.ImageProperties>(value);
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
      return _Element?.GetObject<DMDW.WebVideoProperty,DXO13WD.WebVideoProperty>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.WebVideoProperty,DXO13WD.WebVideoProperty>(value);
    }
  }
  
  [DataMember]
  public DMDSVG.SVGBlip? SVGBlip
  {
    get
    {
      return _Element?.GetObject<DMDSVG.SVGBlip,DXO19DSVG.SVGBlip>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSVG.SVGBlip,DXO19DSVG.SVGBlip>(value);
    }
  }
  
  [DataMember]
  public DMD.PictureAttributionSourceURL? PictureAttributionSourceURL
  {
    get
    {
      return _Element?.GetObject<DMD.PictureAttributionSourceURL,DXO19D.PictureAttributionSourceURL>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PictureAttributionSourceURL,DXO19D.PictureAttributionSourceURL>(value);
    }
  }
  
  [DataMember]
  public DMW20.OEmbed? OEmbed
  {
    get
    {
      return _Element?.GetObject<DMW20.OEmbed,DXOW20OE.OEmbed>();
    }
    set
    {
      _ExistingElement.SetObject<DMW20.OEmbed,DXOW20OE.OEmbed>(value);
    }
  }
  
  [DataMember]
  public DMDOE.OEmbedShared? OEmbedShared
  {
    get
    {
      return _Element?.GetObject<DMDOE.OEmbedShared,DXOD21OE.OEmbedShared>();
    }
    set
    {
      _ExistingElement.SetObject<DMDOE.OEmbedShared,DXOD21OE.OEmbedShared>(value);
    }
  }
  
}
