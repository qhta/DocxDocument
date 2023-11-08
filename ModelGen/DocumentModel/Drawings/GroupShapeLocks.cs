namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a connection shape. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class GroupShapeLocks: ModelElement<DXD.GroupShapeLocks>
{
  public GroupShapeLocks(): base(){ }
  
  public GroupShapeLocks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeLocks(DXD.GroupShapeLocks openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be grouped. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoGrouping
  {
    get
    {
      return _Element?.NoGrouping?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoGrouping = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not show adjust handles for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoUngrouping
  {
    get
    {
      return _Element?.NoUngrouping?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoUngrouping = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoUngrouping = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot have any part of it be selected. That means that no picture, shapes or attached text can be selected either if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoSelection
  {
    get
    {
      return _Element?.NoSelection?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoSelection = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoSelection = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be rotated Objects that reside within the group can still be rotated unless they also have been locked. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoRotation
  {
    get
    {
      return _Element?.NoRotation?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoRotation = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoRotation = null;
    }
  }
  
  
  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  [DataMember]
  public Boolean? NoChangeAspect
  {
    get
    {
      return _Element?.NoChangeAspect?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoChangeAspect = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the corresponding graphic frame cannot be moved. Objects that reside within the graphic frame can still be moved unless they also have been locked. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoMove
  {
    get
    {
      return _Element?.NoMove?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoMove = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoMove = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be resized. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoResize
  {
    get
    {
      return _Element?.NoResize?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoResize = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoResize = null;
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
