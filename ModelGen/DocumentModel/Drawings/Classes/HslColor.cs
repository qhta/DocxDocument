namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color using the HSL color model. A perceptual gamma of 2.2 is assumed.
/// </summary>
public partial class HslColor
{
  
  /// <summary>
  ///   Specifies the angular value describing the wavelength.
  /// </summary>
  [SchemaAttr("hue")]
  public Int32? HueValue { get; set; }
  
  
  /// <summary>
  ///   Specifies the saturation referring to the purity of the hue. Expressed as a percentage with 0% referring to grey, 100% referring to the purest form of the hue.
  /// </summary>
  [SchemaAttr("sat")]
  public Int32? SatValue { get; set; }
  
  
  /// <summary>
  ///   Specifies the luminance referring to the lightness or darkness of the color. Expressed as a percentage with 0% referring to maximal dark (black) and 100% referring to maximal white.
  /// </summary>
  [SchemaAttr("lum")]
  public Int32? LumValue { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
