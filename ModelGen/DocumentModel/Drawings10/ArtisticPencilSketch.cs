namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticPencilSketch Class.
/// </summary>
public partial class ArtisticPencilSketch: ModelElement<DXO10D.ArtisticPencilSketch>
{
  public ArtisticPencilSketch(): base(){ }
  
  public ArtisticPencilSketch(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticPencilSketch(DXO10D.ArtisticPencilSketch openXmlElement): base(openXmlElement) { }
  
  
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
