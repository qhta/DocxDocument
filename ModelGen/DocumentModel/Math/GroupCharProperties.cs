namespace DocumentModel.Math;


/// <summary>
///   Group-Character Properties.
/// </summary>
public partial class GroupCharProperties: ModelElement<DXM.GroupCharProperties>
{
  public GroupCharProperties(): base(){ }
  
  public GroupCharProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupCharProperties(DXM.GroupCharProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Group Character (Grouping Character).
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
  ///   Position (Group Character).
  /// </summary>
  [DataMember]
  public DMM.Position? Position
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Position>();
      if (element != null)
        return PositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PositionConverter.CreateOpenXmlElement<DXM.Position>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  [DataMember]
  public DMM.VerticalJustification? VerticalJustification
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.VerticalJustification>();
      if (element != null)
        return VerticalJustificationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.VerticalJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VerticalJustificationConverter.CreateOpenXmlElement<DXM.VerticalJustification>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
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
