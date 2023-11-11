namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the type of picture fill that the picture object has. Because a picture has a picture fill already by default, it is possible to have two fills specified for a picture object. An example of this is shown below.
/// </summary>
public partial class BlipFill: ModelElement<DXD.BlipFill>
{
  public BlipFill(): base(){ }
  
  public BlipFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BlipFill(DXD.BlipFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the DPI (dots per inch) used to calculate the size of the blip. If not present or zero, the DPI in the blip is used.
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
