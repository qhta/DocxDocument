namespace DocumentModel.Math;


/// <summary>
///   Accent Properties.
/// </summary>
public partial class AccentProperties: ModelElement<DXM.AccentProperties>
{
  public AccentProperties(): base(){ }
  
  public AccentProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AccentProperties(DXM.AccentProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Accent Character.
  /// </summary>
  [DataMember]
  public DMM.AccentChar? AccentChar
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.AccentChar>();
      if (element != null)
        return AccentCharConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.AccentChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AccentCharConverter.CreateOpenXmlElement<DXM.AccentChar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Control Properties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ControlProperties>();
      if (element != null)
        return ControlPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
