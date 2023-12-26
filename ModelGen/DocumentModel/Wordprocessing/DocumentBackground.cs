namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the background for every page of the document containing the background element. A document's background is the image or fill for the entire page surface, behind all other document content.
/// </summary>
public partial class DocumentBackground: ModelElement<DXW.DocumentBackground>
{
  public DocumentBackground(): base(){ }
  
  public DocumentBackground(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentBackground(DXW.DocumentBackground openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   themeTint
  /// </summary>
  [DataMember]
  public String? ThemeTint
  {
    get => _Element?.ThemeTint;
    set => _ExistingElement.ThemeTint = value;
  }
  
  
  /// <summary>
  ///   themeShade
  /// </summary>
  [DataMember]
  public String? ThemeShade
  {
    get => _Element?.ThemeShade;
    set => _ExistingElement.ThemeShade = value;
  }
  
  
  /// <summary>
  ///   Background.
  /// </summary>
  [DataMember]
  public DMVML.Background? Background
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
