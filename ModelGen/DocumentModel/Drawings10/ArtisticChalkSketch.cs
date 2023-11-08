namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticChalkSketch Class.
/// </summary>
public partial class ArtisticChalkSketch: ModelElement<DXO10D.ArtisticChalkSketch>
{
  public ArtisticChalkSketch(): base(){ }
  
  public ArtisticChalkSketch(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticChalkSketch(DXO10D.ArtisticChalkSketch openXmlElement): base(openXmlElement) { }
  
  
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
  ///   pressure, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Pressure
  {
    get
    {
      return _Element?.Pressure?.Value;
    }
    set
    {
      _ExistingElement.Pressure = value;
    }
  }
  
}
