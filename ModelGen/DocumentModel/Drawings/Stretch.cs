namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a BLIP should be stretched to fill the target rectangle. The other option is a tile where a BLIP is tiled to fill the available area.
/// </summary>
public partial class Stretch: ModelElement<DXD.Stretch>
{
  public Stretch(): base(){ }
  
  public Stretch(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Stretch(DXD.Stretch openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Fill Rectangle.
  /// </summary>
  [DataMember]
  public DMD.FillRectangle? FillRectangle
  {
    get
    {
      return _Element?.GetObject<DMD.FillRectangle,DXD.FillRectangle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FillRectangle,DXD.FillRectangle>(value);
    }
  }
  
}
