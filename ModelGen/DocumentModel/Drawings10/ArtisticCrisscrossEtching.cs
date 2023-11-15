namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticCrisscrossEtching Class.
/// </summary>
public partial class ArtisticCrisscrossEtching: ModelElement<DXO10D.ArtisticCrisscrossEtching>
{
  public ArtisticCrisscrossEtching(): base(){ }
  
  public ArtisticCrisscrossEtching(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticCrisscrossEtching(DXO10D.ArtisticCrisscrossEtching openXmlElement): base(openXmlElement) { }
  
  
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
  ///   pressure, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Pressure
  {
    get => _Element?.Pressure?.Value;
    set => _ExistingElement.Pressure = value;
  }
  
}
