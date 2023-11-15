namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticLineDrawing Class.
/// </summary>
public partial class ArtisticLineDrawing: ModelElement<DXO10D.ArtisticLineDrawing>
{
  public ArtisticLineDrawing(): base(){ }
  
  public ArtisticLineDrawing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticLineDrawing(DXO10D.ArtisticLineDrawing openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Transparancy
  {
    get => _Element?.Transparancy?.Value;
    set => _ExistingElement.Transparancy = value;
  }
  
  
  /// <summary>
  ///   pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? PencilSize
  {
    get => _Element?.PencilSize?.Value;
    set => _ExistingElement.PencilSize = value;
  }
  
}
