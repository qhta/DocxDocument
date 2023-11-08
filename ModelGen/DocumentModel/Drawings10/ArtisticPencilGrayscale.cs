namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticPencilGrayscale Class.
/// </summary>
public partial class ArtisticPencilGrayscale: ModelElement<DXO10D.ArtisticPencilGrayscale>
{
  public ArtisticPencilGrayscale(): base(){ }
  
  public ArtisticPencilGrayscale(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticPencilGrayscale(DXO10D.ArtisticPencilGrayscale openXmlElement): base(openXmlElement) { }
  
  
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
  ///   pencilSize, this property is only available in Office 2010 and later.
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
