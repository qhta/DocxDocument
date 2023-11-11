namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a color that happens to be the accent 5 color.  The set of twelve colors come together to form the color scheme for a theme.
/// </summary>
public partial class Accent5Color: ModelElement<DXD.Accent5Color>
{
  public Accent5Color(): base(){ }
  
  public Accent5Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent5Color(DXD.Accent5Color openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get
    {
      return _Element?.GetObject<DMD.RgbColorModelPercentage,DXD.RgbColorModelPercentage>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.RgbColorModelPercentage,DXD.RgbColorModelPercentage>(value);
    }
  }
  
  [DataMember]
  public DMD.RgbColorModelHex? RgbColorModelHex
  {
    get
    {
      return _Element?.GetObject<DMD.RgbColorModelHex,DXD.RgbColorModelHex>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.RgbColorModelHex,DXD.RgbColorModelHex>(value);
    }
  }
  
  [DataMember]
  public DMD.HslColor? HslColor
  {
    get
    {
      return _Element?.GetObject<DMD.HslColor,DXD.HslColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HslColor,DXD.HslColor>(value);
    }
  }
  
  [DataMember]
  public DMD.SystemColor? SystemColor
  {
    get
    {
      return _Element?.GetObject<DMD.SystemColor,DXD.SystemColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SystemColor,DXD.SystemColor>(value);
    }
  }
  
  [DataMember]
  public DMD.PresetColorKind? PresetColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.PresetColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.PresetColor");
    }
  }
  
}
