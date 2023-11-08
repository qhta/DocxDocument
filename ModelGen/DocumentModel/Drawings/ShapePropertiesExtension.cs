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
      var element = _Element?.GetFirstChild<DXO10D.HiddenFillProperties>();
      if (element != null)
        return HiddenFillPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.HiddenFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenFillPropertiesConverter.CreateOpenXmlElement<DXO10D.HiddenFillProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD10.HiddenLineProperties? HiddenLineProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.HiddenLineProperties>();
      if (element != null)
        return HiddenLinePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.HiddenLineProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenLinePropertiesConverter.CreateOpenXmlElement<DXO10D.HiddenLineProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD10.HiddenEffectsProperties? HiddenEffectsProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.HiddenEffectsProperties>();
      if (element != null)
        return HiddenEffectsPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.HiddenEffectsProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenEffectsPropertiesConverter.CreateOpenXmlElement<DXO10D.HiddenEffectsProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD10.HiddenScene3D? HiddenScene3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.HiddenScene3D>();
      if (element != null)
        return HiddenScene3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.HiddenScene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenScene3DConverter.CreateOpenXmlElement<DXO10D.HiddenScene3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD10.HiddenShape3D? HiddenShape3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.HiddenShape3D>();
      if (element != null)
        return HiddenShape3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.HiddenShape3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenShape3DConverter.CreateOpenXmlElement<DXO10D.HiddenShape3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
