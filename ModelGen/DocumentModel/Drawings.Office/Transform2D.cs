namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the Transform2D Class.
/// </summary>
public partial class Transform2D: ModelElement<DXOD.Transform2D>
{
  public Transform2D(): base(){ }
  
  public Transform2D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Transform2D(DXOD.Transform2D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation
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
  ///   Horizontal Flip
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
  ///   Vertical Flip
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
  
}
