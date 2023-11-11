namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MinColorSolidColorFillProperties Class.
/// </summary>
public partial class MinColorSolidColorFillProperties: ModelElement<DXO16DCD.MinColorSolidColorFillProperties>
{
  public MinColorSolidColorFillProperties(): base(){ }
  
  public MinColorSolidColorFillProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinColorSolidColorFillProperties(DXO16DCD.MinColorSolidColorFillProperties openXmlElement): base(openXmlElement) { }
  
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
  public DMD.SchemeColorKind? SchemeColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SchemeColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SchemeColor");
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
