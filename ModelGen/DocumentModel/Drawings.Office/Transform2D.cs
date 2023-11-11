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
        _ExistingElement.HorizontalFlip = new DX.BooleanValue { Value = (Boolean)value };
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
  
}
