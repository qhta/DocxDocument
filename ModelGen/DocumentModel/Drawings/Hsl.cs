namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a hue/saturation/luminance effect. The hue, saturation, and luminance can each be adjusted relative to its current value.
/// </summary>
public partial class Hsl: ModelElement<DXD.Hsl>
{
  public Hsl(): base(){ }
  
  public Hsl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Hsl(DXD.Hsl openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the number of degrees by which the hue is adjusted.
  /// </summary>
  [DataMember]
  public Int32? Hue
  {
    get => _Element?.Hue?.Value;
    set => _ExistingElement.Hue = value;
  }
  
  
  /// <summary>
  ///   Specifies the percentage by which the saturation is adjusted.
  /// </summary>
  [DataMember]
  public Int32? Saturation
  {
    get => _Element?.Saturation?.Value;
    set => _ExistingElement.Saturation = value;
  }
  
  
  /// <summary>
  ///   Specifies the percentage by which the luminance is adjusted.
  /// </summary>
  [DataMember]
  public Int32? Luminance
  {
    get => _Element?.Luminance?.Value;
    set => _ExistingElement.Luminance = value;
  }
  
}
