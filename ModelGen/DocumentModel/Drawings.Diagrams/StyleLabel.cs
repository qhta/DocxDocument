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
  
  
  /// <summary>
  ///   3-D Shape Properties.
  /// </summary>
  [DataMember]
  public DMDD.Shape3D? Shape3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.Shape3D>();
      if (element != null)
        return Shape3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.Shape3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shape3DConverter.CreateOpenXmlElement<DXDDD.Shape3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.TextProperties>();
      if (element != null)
        return TextPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DXDDD.TextProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.Style>();
      if (element != null)
        return StyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleConverter.CreateOpenXmlElement<DXDDD.Style>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
