namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a graphic frame. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class GraphicFrameLocks: ModelElement<DXD.GraphicFrameLocks>
{
  public GraphicFrameLocks(): base(){ }
  
  public GraphicFrameLocks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GraphicFrameLocks(DXD.GraphicFrameLocks openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape grouping for the corresponding graphic frame. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
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
        _ExistingElement.NoGrouping = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoGrouping = null;
    }
  }
  
  
  /// <summary>
  ///   Disallow Selection of Child Shapes
  /// </summary>
  [DataMember]
  public Boolean? NoDrilldown
  {
    get
    {
      return _Element?.NoDrilldown?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoDrilldown = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoDrilldown = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow selecting of the corresponding picture. That means also that no picture, shapes or text attached to this picture can be selected if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
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
        _ExistingElement.NoSelection = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoSelection = null;
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
        _ExistingElement.NoChangeAspect = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.NoMove = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoMove = null;
    }
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow size changes for the corresponding graphic frame. If this attribute is not specified, then a value of false is assumed.
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
        _ExistingElement.NoResize = new DX.BooleanValue { Value = (Boolean)value };
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
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
