namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Definition.
/// </summary>
public partial class StyleDefinition: ModelElement<DXDDD.StyleDefinition>
{
  public StyleDefinition(): base(){ }
  
  public StyleDefinition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleDefinition(DXDDD.StyleDefinition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Style ID
  /// </summary>
  [DataMember]
  public String? UniqueId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.UniqueId);
    }
    set
    {
      _ExistingElement.UniqueId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Minimum Version
  /// </summary>
  [DataMember]
  public String? MinVersion
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MinVersion);
    }
    set
    {
      _ExistingElement.MinVersion = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDD.StyleDisplayCategories? StyleDisplayCategories
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.StyleDisplayCategories>();
      if (element != null)
        return StyleDisplayCategoriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.StyleDisplayCategories>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleDisplayCategoriesConverter.CreateOpenXmlElement<DXDDD.StyleDisplayCategories>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDD.Scene3D? Scene3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.Scene3D>();
      if (element != null)
        return Scene3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.Scene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DConverter.CreateOpenXmlElement<DXDDD.Scene3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDDD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
