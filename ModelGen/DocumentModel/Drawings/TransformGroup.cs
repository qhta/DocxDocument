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
        _ExistingElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXD.Offset>();
      if (element != null)
        return OffsetConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Offset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OffsetConverter.CreateOpenXmlElement<DXD.Offset>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Extents>();
      if (element != null)
        return ExtentsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Extents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtentsConverter.CreateOpenXmlElement<DXD.Extents>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ChildOffset>();
      if (element != null)
        return ChildOffsetConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ChildOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChildOffsetConverter.CreateOpenXmlElement<DXD.ChildOffset>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ChildExtents>();
      if (element != null)
        return ChildExtentsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ChildExtents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChildExtentsConverter.CreateOpenXmlElement<DXD.ChildExtents>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
