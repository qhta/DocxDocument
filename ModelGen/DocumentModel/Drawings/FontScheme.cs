namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the font scheme within the theme.  The font scheme consists of a pair of major and minor fonts for which to use in a document.  The major font corresponds well with the heading areas of a document, and the minor font corresponds well with the normal text or paragraph areas.
/// </summary>
public partial class FontScheme: ModelElement<DXD.FontScheme>
{
  public FontScheme(): base(){ }
  
  public FontScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontScheme(DXD.FontScheme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   The name of the font scheme shown in the user interface.
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Major Font.
  /// </summary>
  [DataMember]
  public DMD.MajorFont? MajorFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.FontCollectionType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.FontCollectionType");
  }
  
  
  /// <summary>
  ///   Minor fonts.
  /// </summary>
  [DataMember]
  public DMD.MinorFont? MinorFont
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.FontCollectionType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.FontCollectionType");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
