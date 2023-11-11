namespace DocumentModel.Drawings;


/// <summary>
///   This element is nearly identical to the representation of 2-D transforms for ordinary shapes (§20.1.7.6). The only addition is a member to represent the Child offset and the Child extents.
/// </summary>
public partial class TransformGroup: ModelElement<DXD.TransformGroup>
{
  public TransformGroup(): base(){ }
  
  public TransformGroup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TransformGroup(DXD.TransformGroup openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation. Specifies the clockwise rotation of a group in 1/64000 of a degree.
  /// </summary>
  [DataMember]
  public Int32? Rotation
  {
    get
    {
      return _Element?.Rotation?.Value;
    }
    set
    {
      _ExistingElement.Rotation = value;
    }
  }
  
  
  /// <summary>
  ///   Horizontal flip. When true, this attribute defines that the group is flipped horizontally about the center of its bounding box.
  /// </summary>
  [DataMember]
  public Boolean? HorizontalFlip
  {
    get
    {
      return _Element?.HorizontalFlip?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.HorizontalFlip = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.HorizontalFlip = null;
    }
  }
  
  
  /// <summary>
  ///   Vertical flip. When true, this attribute defines that the group is flipped vertically about the center of its bounding box.
  /// </summary>
  [DataMember]
  public Boolean? VerticalFlip
  {
    get
    {
      return _Element?.VerticalFlip?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.VerticalFlip = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.VerticalFlip = null;
    }
  }
  
  
  /// <summary>
  ///   Offset.
  /// </summary>
  [DataMember]
  public DMD.Offset? Offset
  {
    get
    {
      return _Element?.GetObject<DMD.Offset,DXD.Offset>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Offset,DXD.Offset>(value);
    }
  }
  
  
  /// <summary>
  ///   Extents.
  /// </summary>
  [DataMember]
  public DMD.Extents? Extents
  {
    get
    {
      return _Element?.GetObject<DMD.Extents,DXD.Extents>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Extents,DXD.Extents>(value);
    }
  }
  
  
  /// <summary>
  ///   Child Offset.
  /// </summary>
  [DataMember]
  public DMD.ChildOffset? ChildOffset
  {
    get
    {
      return _Element?.GetObject<DMD.ChildOffset,DXD.ChildOffset>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ChildOffset,DXD.ChildOffset>(value);
    }
  }
  
  
  /// <summary>
  ///   Child Extents.
  /// </summary>
  [DataMember]
  public DMD.ChildExtents? ChildExtents
  {
    get
    {
      return _Element?.GetObject<DMD.ChildExtents,DXD.ChildExtents>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ChildExtents,DXD.ChildExtents>(value);
    }
  }
  
}
