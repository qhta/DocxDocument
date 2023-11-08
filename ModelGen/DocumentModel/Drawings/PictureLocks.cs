namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a graphic frame. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class PictureLocks: ModelElement<DXD.PictureLocks>
{
  public PictureLocks(): base(){ }
  
  public PictureLocks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PictureLocks(DXD.PictureLocks openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape grouping for the corresponding connection shape. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
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
  ///   Specifies that the generating application should not allow selecting of the corresponding connection shape. That means also that no picture, shapes or text attached to this connection shape can be selected if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
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
  ///   Specifies that the generating application should not allow shape rotation changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
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
  ///   Specifies that the generating application should not allow position changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
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
  ///   Specifies that the generating application should not allow size changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
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
  ///   Specifies that the generating application should not allow shape point changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoEditPoints
  {
    get
    {
      return _Element?.NoEditPoints?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoEditPoints = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoEditPoints = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not show adjust handles for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoAdjustHandles
  {
    get
    {
      return _Element?.NoAdjustHandles?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoAdjustHandles = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoAdjustHandles = null;
    }
  }
  
  
  /// <summary>
  ///   Disallow Arrowhead Changes
  /// </summary>
  [DataMember]
  public Boolean? NoChangeArrowheads
  {
    get
    {
      return _Element?.NoChangeArrowheads?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoChangeArrowheads = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoChangeArrowheads = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape type changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoChangeShapeType
  {
    get
    {
      return _Element?.NoChangeShapeType?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoChangeShapeType = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow cropping for the corresponding picture. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoCrop
  {
    get
    {
      return _Element?.NoCrop?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoCrop = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoCrop = null;
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
