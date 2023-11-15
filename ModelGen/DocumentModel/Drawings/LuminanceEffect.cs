namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a luminance effect. Brightness linearly shifts all colors closer to white or black. Contrast scales all colors to be either closer or further apart.
/// </summary>
public partial class LuminanceEffect: ModelElement<DXD.LuminanceEffect>
{
  public LuminanceEffect(): base(){ }
  
  public LuminanceEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LuminanceEffect(DXD.LuminanceEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the percent to change the brightness.
  /// </summary>
  [DataMember]
  public Int32? Brightness
  {
    get => _Element?.Brightness?.Value;
    set => _ExistingElement.Brightness = value;
  }
  
  
  /// <summary>
  ///   Specifies the percent to change the contrast.
  /// </summary>
  [DataMember]
  public Int32? Contrast
  {
    get => _Element?.Contrast?.Value;
    set => _ExistingElement.Contrast = value;
  }
  
}
