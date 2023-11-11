namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Label.
/// </summary>
public partial class StyleLabel: ModelElement<DXDDD.StyleLabel>
{
  public StyleLabel(): base(){ }
  
  public StyleLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleLabel(DXDDD.StyleLabel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Style Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   3-D Scene.
  /// </summary>
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
  
  
  /// <summary>
  ///   3-D Shape Properties.
  /// </summary>
  [DataMember]
  public DMDD.Shape3D? Shape3D
  {
    get
    {
      return _Element?.GetObject<DMDD.Shape3D,DXDDD.Shape3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.Shape3D,DXDDD.Shape3D>(value);
    }
  }
  
  
  /// <summary>
  ///   Text Properties.
  /// </summary>
  [DataMember]
  public DMDD.TextProperties? TextProperties
  {
    get
    {
      return _Element?.GetObject<DMDD.TextProperties,DXDDD.TextProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.TextProperties,DXDDD.TextProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Style.
  /// </summary>
  [DataMember]
  public DMDD.Style? Style
  {
    get
    {
      return _Element?.GetObject<DMDD.Style,DXDDD.Style>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.Style,DXDDD.Style>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
