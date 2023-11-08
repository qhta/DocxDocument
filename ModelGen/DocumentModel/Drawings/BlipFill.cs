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
        _ExistingElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXD.Blip>();
      if (element != null)
        return BlipConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Blip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipConverter.CreateOpenXmlElement<DXD.Blip>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.SourceRectangle>();
      if (element != null)
        return SourceRectangleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SourceRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SourceRectangleConverter.CreateOpenXmlElement<DXD.SourceRectangle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Tile? Tile
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Tile>();
      if (element != null)
        return TileConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Tile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TileConverter.CreateOpenXmlElement<DXD.Tile>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Stretch? Stretch
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Stretch>();
      if (element != null)
        return StretchConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Stretch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StretchConverter.CreateOpenXmlElement<DXD.Stretch>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
