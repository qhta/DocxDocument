namespace DocumentModel.Math;


/// <summary>
///   Border Box Properties.
/// </summary>
public partial class BorderBoxProperties: ModelElement<DXM.BorderBoxProperties>
{
  public BorderBoxProperties(): base(){ }
  
  public BorderBoxProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderBoxProperties(DXM.BorderBoxProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Hide Top Edge.
  /// </summary>
  [DataMember]
  public DMM.HideTop? HideTop
  {
    get
    {
      return _Element?.GetObject<DMM.HideTop,DXM.HideTop>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.HideTop,DXM.HideTop>(value);
    }
  }
  
  
  /// <summary>
  ///   Hide Bottom Edge.
  /// </summary>
  [DataMember]
  public DMM.HideBottom? HideBottom
  {
    get
    {
      return _Element?.GetObject<DMM.HideBottom,DXM.HideBottom>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.HideBottom,DXM.HideBottom>(value);
    }
  }
  
  
  /// <summary>
  ///   Hide Left Edge.
  /// </summary>
  [DataMember]
  public DMM.HideLeft? HideLeft
  {
    get
    {
      return _Element?.GetObject<DMM.HideLeft,DXM.HideLeft>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.HideLeft,DXM.HideLeft>(value);
    }
  }
  
  
  /// <summary>
  ///   Hide Right Edge.
  /// </summary>
  [DataMember]
  public DMM.HideRight? HideRight
  {
    get
    {
      return _Element?.GetObject<DMM.HideRight,DXM.HideRight>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.HideRight,DXM.HideRight>(value);
    }
  }
  
  
  /// <summary>
  ///   Border Box Strikethrough Horizontal.
  /// </summary>
  [DataMember]
  public DMM.StrikeHorizontal? StrikeHorizontal
  {
    get
    {
      return _Element?.GetObject<DMM.StrikeHorizontal,DXM.StrikeHorizontal>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.StrikeHorizontal,DXM.StrikeHorizontal>(value);
    }
  }
  
  
  /// <summary>
  ///   Border Box Strikethrough Vertical.
  /// </summary>
  [DataMember]
  public DMM.StrikeVertical? StrikeVertical
  {
    get
    {
      return _Element?.GetObject<DMM.StrikeVertical,DXM.StrikeVertical>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.StrikeVertical,DXM.StrikeVertical>(value);
    }
  }
  
  
  /// <summary>
  ///   Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  [DataMember]
  public DMM.StrikeBottomLeftToTopRight? StrikeBottomLeftToTopRight
  {
    get
    {
      return _Element?.GetObject<DMM.StrikeBottomLeftToTopRight,DXM.StrikeBottomLeftToTopRight>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.StrikeBottomLeftToTopRight,DXM.StrikeBottomLeftToTopRight>(value);
    }
  }
  
  
  /// <summary>
  ///   Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  [DataMember]
  public DMM.StrikeTopLeftToBottomRight? StrikeTopLeftToBottomRight
  {
    get
    {
      return _Element?.GetObject<DMM.StrikeTopLeftToBottomRight,DXM.StrikeTopLeftToBottomRight>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.StrikeTopLeftToBottomRight,DXM.StrikeTopLeftToBottomRight>(value);
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
      return _Element?.GetObject<DMM.ControlProperties,DXM.ControlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ControlProperties,DXM.ControlProperties>(value);
    }
  }
  
}
