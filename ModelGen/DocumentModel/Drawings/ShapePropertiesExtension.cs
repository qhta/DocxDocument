namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class ShapePropertiesExtension: ModelElement<DXD.ShapePropertiesExtension>
{
  public ShapePropertiesExtension(): base(){ }
  
  public ShapePropertiesExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapePropertiesExtension(DXD.ShapePropertiesExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMD10.HiddenFillProperties? HiddenFillProperties
  {
    get
    {
      return _Element?.GetObject<DMD10.HiddenFillProperties,DXO10D.HiddenFillProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.HiddenFillProperties,DXO10D.HiddenFillProperties>(value);
    }
  }
  
  [DataMember]
  public DMD10.HiddenLineProperties? HiddenLineProperties
  {
    get
    {
      return _Element?.GetObject<DMD10.HiddenLineProperties,DXO10D.HiddenLineProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.HiddenLineProperties,DXO10D.HiddenLineProperties>(value);
    }
  }
  
  [DataMember]
  public DMD10.HiddenEffectsProperties? HiddenEffectsProperties
  {
    get
    {
      return _Element?.GetObject<DMD10.HiddenEffectsProperties,DXO10D.HiddenEffectsProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.HiddenEffectsProperties,DXO10D.HiddenEffectsProperties>(value);
    }
  }
  
  [DataMember]
  public DMD10.HiddenScene3D? HiddenScene3D
  {
    get
    {
      return _Element?.GetObject<DMD10.HiddenScene3D,DXO10D.HiddenScene3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.HiddenScene3D,DXO10D.HiddenScene3D>(value);
    }
  }
  
  [DataMember]
  public DMD10.HiddenShape3D? HiddenShape3D
  {
    get
    {
      return _Element?.GetObject<DMD10.HiddenShape3D,DXO10D.HiddenShape3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.HiddenShape3D,DXO10D.HiddenShape3D>(value);
    }
  }
  
  [DataMember]
  public Boolean? ShadowObscured
  {
    get
    {
      return _ExistingElement.GetFirstChild<DXO10D.ShadowObscured>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXO10D.ShadowObscured>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXO10D.ShadowObscured();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
