namespace DocumentModel.Drawings;


/// <summary>
///   Defines the FontCollectionType Class.
/// </summary>
public partial class FontCollectionType: ModelElement<DXD.FontCollectionType>
{
  public FontCollectionType(): base(){ }
  
  public FontCollectionType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontCollectionType(DXD.FontCollectionType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Latin Font.
  /// </summary>
  [DataMember]
  public DMD.LatinFont? LatinFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  
  /// <summary>
  ///   East Asian Font.
  /// </summary>
  [DataMember]
  public DMD.EastAsianFont? EastAsianFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
  
  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  [DataMember]
  public DMD.ComplexScriptFont? ComplexScriptFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextFontType");
  }
  
}
