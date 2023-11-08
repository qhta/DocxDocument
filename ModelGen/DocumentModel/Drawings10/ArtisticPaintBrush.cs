namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticPaintBrush Class.
/// </summary>
public partial class ArtisticPaintBrush: ModelElement<DXO10D.ArtisticPaintBrush>
{
  public ArtisticPaintBrush(): base(){ }
  
  public ArtisticPaintBrush(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticPaintBrush(DXO10D.ArtisticPaintBrush openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Transparancy
  {
    get
    {
      return _Element?.Transparancy?.Value;
    }
    set
    {
      _ExistingElement.Transparancy = value;
    }
  }
  
  
  /// <summary>
  ///   brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? BrushSize
  {
    get
    {
      return _Element?.BrushSize?.Value;
    }
    set
    {
      _ExistingElement.BrushSize = value;
    }
  }
  
}
