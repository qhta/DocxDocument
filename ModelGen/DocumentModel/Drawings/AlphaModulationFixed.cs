namespace DocumentModel.Drawings;


/// <summary>
///   This element represents an alpha modulate fixed effect.
/// </summary>
public partial class AlphaModulationFixed: ModelElement<DXD.AlphaModulationFixed>
{
  public AlphaModulationFixed(): base(){ }
  
  public AlphaModulationFixed(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlphaModulationFixed(DXD.AlphaModulationFixed openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the percentage amount to scale the alpha.
  /// </summary>
  [DataMember]
  public Int32? Amount
  {
    get
    {
      return _Element?.Amount?.Value;
    }
    set
    {
      _ExistingElement.Amount = value;
    }
  }
  
}
