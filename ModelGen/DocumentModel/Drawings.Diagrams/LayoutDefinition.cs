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
      return _Element?.GetObject<DMDD.CategoryList,DXDDD.CategoryList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.CategoryList,DXDDD.CategoryList>(value);
    }
  }
  
  [DataMember]
  public DMDD.SampleData? SampleData
  {
    get
    {
      return _Element?.GetObject<DMDD.SampleData,DXDDD.SampleData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.SampleData,DXDDD.SampleData>(value);
    }
  }
  
  [DataMember]
  public DMDD.StyleData? StyleData
  {
    get
    {
      return _Element?.GetObject<DMDD.StyleData,DXDDD.StyleData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.StyleData,DXDDD.StyleData>(value);
    }
  }
  
  [DataMember]
  public DMDD.ColorData? ColorData
  {
    get
    {
      return _Element?.GetObject<DMDD.ColorData,DXDDD.ColorData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.ColorData,DXDDD.ColorData>(value);
    }
  }
  
  [DataMember]
  public DMDD.LayoutNode? LayoutNode
  {
    get
    {
      return _Element?.GetObject<DMDD.LayoutNode,DXDDD.LayoutNode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.LayoutNode,DXDDD.LayoutNode>(value);
    }
  }
  
  [DataMember]
  public DMDD.DiagramDefinitionExtensionList? DiagramDefinitionExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDD.DiagramDefinitionExtensionList,DXDDD.DiagramDefinitionExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.DiagramDefinitionExtensionList,DXDDD.DiagramDefinitionExtensionList>(value);
    }
  }
  
}
