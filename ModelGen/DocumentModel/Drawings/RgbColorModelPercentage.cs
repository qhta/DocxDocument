namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color using the red, green, blue RGB color model. Each component, red, green, and blue is expressed as a percentage from 0% to 100%. A linear gamma of 1.0 is assumed.
/// </summary>
public partial class RgbColorModelPercentage: ModelElement<DXD.RgbColorModelPercentage>
{
  public RgbColorModelPercentage(): base(){ }
  
  public RgbColorModelPercentage(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RgbColorModelPercentage(DXD.RgbColorModelPercentage openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the percentage of red.
  /// </summary>
  [DataMember]
  public Int32? RedPortion
  {
    get => _Element?.RedPortion?.Value;
    set => _ExistingElement.RedPortion = value;
  }
  
  
  /// <summary>
  ///   Specifies the percentage of green.
  /// </summary>
  [DataMember]
  public Int32? GreenPortion
  {
    get => _Element?.GreenPortion?.Value;
    set => _ExistingElement.GreenPortion = value;
  }
  
  
  /// <summary>
  ///   Specifies the percentage of blue.
  /// </summary>
  [DataMember]
  public Int32? BluePortion
  {
    get => _Element?.BluePortion?.Value;
    set => _ExistingElement.BluePortion = value;
  }
  
}
