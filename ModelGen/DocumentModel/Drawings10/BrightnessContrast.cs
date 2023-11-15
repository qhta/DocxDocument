namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the BrightnessContrast Class.
/// </summary>
public partial class BrightnessContrast: ModelElement<DXO10D.BrightnessContrast>
{
  public BrightnessContrast(): base(){ }
  
  public BrightnessContrast(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BrightnessContrast(DXO10D.BrightnessContrast openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   bright, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Bright
  {
    get => _Element?.Bright?.Value;
    set => _ExistingElement.Bright = value;
  }
  
  
  /// <summary>
  ///   contrast, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Contrast
  {
    get => _Element?.Contrast?.Value;
    set => _ExistingElement.Contrast = value;
  }
  
}
