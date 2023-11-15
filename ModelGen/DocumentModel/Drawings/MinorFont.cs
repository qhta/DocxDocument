namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of minor fonts that are to be used under different languages or locals.
/// </summary>
public partial class MinorFont: ModelElement<DXD.MinorFont>
{
  public MinorFont(): base(){ }
  
  public MinorFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorFont(DXD.MinorFont openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.LatinFont? LatinFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  [DataMember]
  public DMD.EastAsianFont? EastAsianFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  [DataMember]
  public DMD.ComplexScriptFont? ComplexScriptFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
