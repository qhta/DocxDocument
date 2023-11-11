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
      return _Element?.GetObject<DMD.ShapeDefault,DXD.ShapeDefault>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ShapeDefault,DXD.ShapeDefault>(value);
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
      return _Element?.GetObject<DMD.LineDefault,DXD.LineDefault>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LineDefault,DXD.LineDefault>(value);
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
      return _Element?.GetObject<DMD.TextDefault,DXD.TextDefault>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.TextDefault,DXD.TextDefault>(value);
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
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
