namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Picture Fill.
/// </summary>
public partial class BlipFill: ModelElement<DXDCD.BlipFill>
{
  public BlipFill(): base(){ }
  
  public BlipFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BlipFill(DXDCD.BlipFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   DPI Setting
  /// </summary>
  [DataMember]
  public UInt32? Dpi
  {
    get
    {
      return _Element?.Dpi?.Value;
    }
    set
    {
      _ExistingElement.Dpi = value;
    }
  }
  
  
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
  ///   Blip.
  /// </summary>
  [DataMember]
  public DMD.Blip? Blip
  {
    get
    {
      return _Element?.GetObject<DMD.Blip,DXD.Blip>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Blip,DXD.Blip>(value);
    }
  }
  
  
  /// <summary>
  ///   Source Rectangle.
  /// </summary>
  [DataMember]
  public DMD.SourceRectangle? SourceRectangle
  {
    get
    {
      return _Element?.GetObject<DMD.SourceRectangle,DXD.SourceRectangle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SourceRectangle,DXD.SourceRectangle>(value);
    }
  }
  
  [DataMember]
  public DMD.Tile? Tile
  {
    get
    {
      return _Element?.GetObject<DMD.Tile,DXD.Tile>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Tile,DXD.Tile>(value);
    }
  }
  
  [DataMember]
  public DMD.Stretch? Stretch
  {
    get
    {
      return _Element?.GetObject<DMD.Stretch,DXD.Stretch>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Stretch,DXD.Stretch>(value);
    }
  }
  
}
