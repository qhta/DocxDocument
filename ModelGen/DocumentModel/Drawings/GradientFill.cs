namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient fill.
/// </summary>
public partial class GradientFill: ModelElement<DXD.GradientFill>
{
  public GradientFill(): base(){ }
  
  public GradientFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientFill(DXD.GradientFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [DataMember]
  public Boolean? RotateWithShape
  {
    get
    {
      return _Element?.RotateWithShape?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.RotateWithShape = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.RotateWithShape = null;
    }
  }
  
  
  /// <summary>
  ///   Gradient Stop List.
  /// </summary>
  [DataMember]
  public DMD.GradientStopList? GradientStopList
  {
    get
    {
      return _Element?.GetObject<DMD.GradientStopList,DXD.GradientStopList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GradientStopList,DXD.GradientStopList>(value);
    }
  }
  
  [DataMember]
  public DMD.LinearGradientFill? LinearGradientFill
  {
    get
    {
      return _Element?.GetObject<DMD.LinearGradientFill,DXD.LinearGradientFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LinearGradientFill,DXD.LinearGradientFill>(value);
    }
  }
  
  [DataMember]
  public DMD.PathGradientFill? PathGradientFill
  {
    get
    {
      return _Element?.GetObject<DMD.PathGradientFill,DXD.PathGradientFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PathGradientFill,DXD.PathGradientFill>(value);
    }
  }
  
  [DataMember]
  public DMD.TileRectangle? TileRectangle
  {
    get
    {
      return _Element?.GetObject<DMD.TileRectangle,DXD.TileRectangle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.TileRectangle,DXD.TileRectangle>(value);
    }
  }
  
}
