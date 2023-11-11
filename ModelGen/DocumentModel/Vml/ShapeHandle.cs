namespace DocumentModel.Vml;


/// <summary>
///   Shape Handle.
/// </summary>
public partial class ShapeHandle: ModelElement<DXV.ShapeHandle>
{
  public ShapeHandle(): base(){ }
  
  public ShapeHandle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeHandle(DXV.ShapeHandle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Handle Position
  /// </summary>
  [DataMember]
  public String? Position
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Position);
    }
    set
    {
      _ExistingElement.Position = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Handle Polar Center
  /// </summary>
  [DataMember]
  public String? Polar
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Polar);
    }
    set
    {
      _ExistingElement.Polar = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Handle Coordinate Mapping
  /// </summary>
  [DataMember]
  public String? Map
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Map);
    }
    set
    {
      _ExistingElement.Map = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Invert Handle's X Position
  /// </summary>
  [DataMember]
  public Boolean? InvertX
  {
    get
    {
      return _Element?.InvertX?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.InvertX = value;
      else
        _ExistingElement.InvertX = null;
    }
  }
  
  
  /// <summary>
  ///   Invert Handle's Y Position
  /// </summary>
  [DataMember]
  public Boolean? InvertY
  {
    get
    {
      return _Element?.InvertY?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.InvertY = value;
      else
        _ExistingElement.InvertY = null;
    }
  }
  
  
  /// <summary>
  ///   Handle Inversion Toggle
  /// </summary>
  [DataMember]
  public Boolean? Switch
  {
    get
    {
      return _Element?.Switch?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Switch = value;
      else
        _ExistingElement.Switch = null;
    }
  }
  
  
  /// <summary>
  ///   Handle X Position Range
  /// </summary>
  [DataMember]
  public String? XRange
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.XRange);
    }
    set
    {
      _ExistingElement.XRange = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Handle Y Position Range
  /// </summary>
  [DataMember]
  public String? YRange
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.YRange);
    }
    set
    {
      _ExistingElement.YRange = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Handle Polar Radius Range
  /// </summary>
  [DataMember]
  public String? RadiusRange
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RadiusRange);
    }
    set
    {
      _ExistingElement.RadiusRange = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
