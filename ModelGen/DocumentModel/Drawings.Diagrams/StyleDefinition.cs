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
      return _Element?.GetObject<DMDD.StyleDisplayCategories,DXDDD.StyleDisplayCategories>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.StyleDisplayCategories,DXDDD.StyleDisplayCategories>(value);
    }
  }
  
  [DataMember]
  public DMDD.Scene3D? Scene3D
  {
    get
    {
      return _Element?.GetObject<DMDD.Scene3D,DXDDD.Scene3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.Scene3D,DXDDD.Scene3D>(value);
    }
  }
  
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDD.ExtensionList,DXDDD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.ExtensionList,DXDDD.ExtensionList>(value);
    }
  }
  
}
