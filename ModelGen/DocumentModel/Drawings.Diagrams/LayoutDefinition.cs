namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Layout Definition.
/// </summary>
public partial class LayoutDefinition: ModelElement<DXDDD.LayoutDefinition>
{
  public LayoutDefinition(): base(){ }
  
  public LayoutDefinition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LayoutDefinition(DXDDD.LayoutDefinition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   uniqueId
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
  ///   minVer
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
  
  
  /// <summary>
  ///   defStyle
  /// </summary>
  [DataMember]
  public String? DefaultStyle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DefaultStyle);
    }
    set
    {
      _ExistingElement.DefaultStyle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDD.CategoryList? CategoryList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.CategoryList>();
      if (element != null)
        return CategoryListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.CategoryList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryListConverter.CreateOpenXmlElement<DXDDD.CategoryList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDD.SampleData? SampleData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.SampleData>();
      if (element != null)
        return SampleDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.SampleData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SampleDataConverter.CreateOpenXmlElement<DXDDD.SampleData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDD.StyleData? StyleData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.StyleData>();
      if (element != null)
        return StyleDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.StyleData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleDataConverter.CreateOpenXmlElement<DXDDD.StyleData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDD.ColorData? ColorData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.ColorData>();
      if (element != null)
        return ColorDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ColorData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorDataConverter.CreateOpenXmlElement<DXDDD.ColorData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDD.LayoutNode? LayoutNode
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.LayoutNode>();
      if (element != null)
        return LayoutNodeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.LayoutNode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutNodeConverter.CreateOpenXmlElement<DXDDD.LayoutNode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDD.DiagramDefinitionExtensionList? DiagramDefinitionExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.DiagramDefinitionExtensionList>();
      if (element != null)
        return DiagramDefinitionExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.DiagramDefinitionExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiagramDefinitionExtensionListConverter.CreateOpenXmlElement<DXDDD.DiagramDefinitionExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
