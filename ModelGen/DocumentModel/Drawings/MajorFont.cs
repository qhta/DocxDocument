namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of major fonts which are to be used under different languages or locals.
/// </summary>
public partial class MajorFont: ModelElement<DXD.MajorFont>
{
  public MajorFont(): base(){ }
  
  public MajorFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorFont(DXD.MajorFont openXmlElement): base(openXmlElement) { }
  
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
