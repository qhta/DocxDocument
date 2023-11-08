namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for the definition of default shape, line, and textbox formatting properties.  An application can use this information to format a shape (or text) initially on insertion into a document.
/// </summary>
public partial class ObjectDefaults: ModelElement<DXD.ObjectDefaults>
{
  public ObjectDefaults(): base(){ }
  
  public ObjectDefaults(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ObjectDefaults(DXD.ObjectDefaults openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape Default.
  /// </summary>
  [DataMember]
  public DMD.ShapeDefault? ShapeDefault
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ShapeDefault>();
      if (element != null)
        return ShapeDefaultConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ShapeDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeDefaultConverter.CreateOpenXmlElement<DXD.ShapeDefault>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Line Default.
  /// </summary>
  [DataMember]
  public DMD.LineDefault? LineDefault
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LineDefault>();
      if (element != null)
        return LineDefaultConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LineDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineDefaultConverter.CreateOpenXmlElement<DXD.LineDefault>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Text Default.
  /// </summary>
  [DataMember]
  public DMD.TextDefault? TextDefault
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.TextDefault>();
      if (element != null)
        return TextDefaultConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.TextDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextDefaultConverter.CreateOpenXmlElement<DXD.TextDefault>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
