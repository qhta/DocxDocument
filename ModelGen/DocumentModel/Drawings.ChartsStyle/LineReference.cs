namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the LineReference Class.
/// </summary>
public partial class LineReference: ModelElement<DXO13DCS.LineReference>
{
  public LineReference(): base(){ }
  
  public LineReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineReference(DXO13DCS.LineReference openXmlElement): base(openXmlElement) { }
  
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
  
  [DataMember]
  public String? StyleColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor");
    }
  }
  
}
