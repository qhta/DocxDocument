namespace DocumentModel.Vml;


/// <summary>
///   Defines the Lock Class.
/// </summary>
public partial class Lock: ModelElement<DXVO.Lock>
{
  public Lock(): base(){ }
  
  public Lock(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Lock(DXVO.Lock openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Position Lock
  /// </summary>
  [DataMember]
  public Boolean? Position
  {
    get
    {
      return _Element?.Position?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Position = value;
      else
        _ExistingElement.Position = null;
    }
  }
  
  
  /// <summary>
  ///   Selection Lock
  /// </summary>
  [DataMember]
  public Boolean? Selection
  {
    get
    {
      return _Element?.Selection?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Selection = value;
      else
        _ExistingElement.Selection = null;
    }
  }
  
  
  /// <summary>
  ///   Grouping Lock
  /// </summary>
  [DataMember]
  public Boolean? Grouping
  {
    get
    {
      return _Element?.Grouping?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Grouping = value;
      else
        _ExistingElement.Grouping = null;
    }
  }
  
  
  /// <summary>
  ///   Ungrouping Lock
  /// </summary>
  [DataMember]
  public Boolean? Ungrouping
  {
    get
    {
      return _Element?.Ungrouping?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Ungrouping = value;
      else
        _ExistingElement.Ungrouping = null;
    }
  }
  
  
  /// <summary>
  ///   Rotation Lock
  /// </summary>
  [DataMember]
  public Boolean? Rotation
  {
    get
    {
      return _Element?.Rotation?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Rotation = value;
      else
        _ExistingElement.Rotation = null;
    }
  }
  
  
  /// <summary>
  ///   Cropping Lock
  /// </summary>
  [DataMember]
  public Boolean? Cropping
  {
    get
    {
      return _Element?.Cropping?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Cropping = value;
      else
        _ExistingElement.Cropping = null;
    }
  }
  
  
  /// <summary>
  ///   Vertices Lock
  /// </summary>
  [DataMember]
  public Boolean? Verticies
  {
    get
    {
      return _Element?.Verticies?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Verticies = value;
      else
        _ExistingElement.Verticies = null;
    }
  }
  
  
  /// <summary>
  ///   Handles Lock
  /// </summary>
  [DataMember]
  public Boolean? AdjustHandles
  {
    get
    {
      return _Element?.AdjustHandles?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AdjustHandles = value;
      else
        _ExistingElement.AdjustHandles = null;
    }
  }
  
  
  /// <summary>
  ///   Text Lock
  /// </summary>
  [DataMember]
  public Boolean? TextLock
  {
    get
    {
      return _Element?.TextLock?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.TextLock = value;
      else
        _ExistingElement.TextLock = null;
    }
  }
  
  
  /// <summary>
  ///   Aspect Ratio Lock
  /// </summary>
  [DataMember]
  public Boolean? AspectRatio
  {
    get
    {
      return _Element?.AspectRatio?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AspectRatio = value;
      else
        _ExistingElement.AspectRatio = null;
    }
  }
  
  
  /// <summary>
  ///   AutoShape Type Lock
  /// </summary>
  [DataMember]
  public Boolean? ShapeType
  {
    get
    {
      return _Element?.ShapeType?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ShapeType = value;
      else
        _ExistingElement.ShapeType = null;
    }
  }
  
}
