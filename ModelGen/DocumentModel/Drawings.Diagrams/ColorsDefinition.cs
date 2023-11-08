namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Color Transform Definitions.
/// </summary>
public partial class ColorsDefinition: ModelElement<DXDDD.ColorsDefinition>
{
  public ColorsDefinition(): base(){ }
  
  public ColorsDefinition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorsDefinition(DXDDD.ColorsDefinition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique ID
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
  public DMDD.ColorTransformCategories? ColorTransformCategories
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.ColorTransformCategories>();
      if (element != null)
        return ColorTransformCategoriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ColorTransformCategories>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorTransformCategoriesConverter.CreateOpenXmlElement<DXDDD.ColorTransformCategories>(value);
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
