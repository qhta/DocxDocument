namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color using the HSL color model. A perceptual gamma of 2.2 is assumed.
/// </summary>
public partial class HslColor: ModelElement<DXD.HslColor>
{
  public HslColor(): base(){ }
  
  public HslColor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HslColor(DXD.HslColor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the angular value describing the wavelength.
  /// </summary>
  [DataMember]
  public Int32? HueValue
  {
    get
    {
      return _Element?.HueValue?.Value;
    }
    set
    {
      _ExistingElement.HueValue = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the saturation referring to the purity of the hue. Expressed as a percentage with 0% referring to grey, 100% referring to the purest form of the hue.
  /// </summary>
  [DataMember]
  public Int32? SatValue
  {
    get
    {
      return _Element?.SatValue?.Value;
    }
    set
    {
      _ExistingElement.SatValue = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the luminance referring to the lightness or darkness of the color. Expressed as a percentage with 0% referring to maximal dark (black) and 100% referring to maximal white.
  /// </summary>
  [DataMember]
  public Int32? LumValue
  {
    get
    {
      return _Element?.LumValue?.Value;
    }
    set
    {
      _ExistingElement.LumValue = value;
    }
  }
  
}
