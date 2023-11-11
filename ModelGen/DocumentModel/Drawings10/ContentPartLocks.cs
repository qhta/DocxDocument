namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ContentPartLocks Class.
/// </summary>
public partial class ContentPartLocks: ModelElement<DXO10D.ContentPartLocks>
{
  public ContentPartLocks(): base(){ }
  
  public ContentPartLocks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContentPartLocks(DXO10D.ContentPartLocks openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Disallow Shape Grouping
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
  ///   Disallow Shape Selection
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
  ///   Disallow Shape Rotation
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
        _ExistingElement.NoRotation = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.NoChangeAspect = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoChangeAspect = null;
    }
  }
  
  
  /// <summary>
  ///   Disallow Shape Movement
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
  ///   Disallow Shape Resize
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
  ///   Disallow Shape Point Editing
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
        _ExistingElement.NoEditPoints = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoEditPoints = null;
    }
  }
  
  
  /// <summary>
  ///   Disallow Showing Adjust Handles
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
        _ExistingElement.NoAdjustHandles = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.NoChangeArrowheads = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoChangeArrowheads = null;
    }
  }
  
  
  /// <summary>
  ///   Disallow Shape Type Change
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
        _ExistingElement.NoChangeShapeType = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoChangeShapeType = null;
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMD10.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD10.OfficeArtExtensionList,DXO10D.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.OfficeArtExtensionList,DXO10D.OfficeArtExtensionList>(value);
    }
  }
  
}
