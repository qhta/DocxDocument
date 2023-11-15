namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticPhotocopy Class.
/// </summary>
public partial class ArtisticPhotocopy: ModelElement<DXO10D.ArtisticPhotocopy>
{
  public ArtisticPhotocopy(): base(){ }
  
  public ArtisticPhotocopy(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticPhotocopy(DXO10D.ArtisticPhotocopy openXmlElement): base(openXmlElement) { }
  
  
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
  ///   detail, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Detail
  {
    get => _Element?.Detail?.Value;
    set => _ExistingElement.Detail = value;
  }
  
}
