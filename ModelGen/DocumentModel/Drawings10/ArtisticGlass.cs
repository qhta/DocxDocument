namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticGlass Class.
/// </summary>
public partial class ArtisticGlass: ModelElement<DXO10D.ArtisticGlass>
{
  public ArtisticGlass(): base(){ }
  
  public ArtisticGlass(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticGlass(DXO10D.ArtisticGlass openXmlElement): base(openXmlElement) { }
  
  
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
  ///   scaling, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Scaling
  {
    get
    {
      return _Element?.Scaling?.Value;
    }
    set
    {
      _ExistingElement.Scaling = value;
    }
  }
  
}
