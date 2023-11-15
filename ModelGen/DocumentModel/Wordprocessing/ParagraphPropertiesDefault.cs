namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a set of default paragraph properties for the current document. The actual paragraph properties are stored within the pPr child element of the current element.
/// </summary>
public partial class ParagraphPropertiesDefault: ModelElement<DXW.ParagraphPropertiesDefault>
{
  public ParagraphPropertiesDefault(): base(){ }
  
  public ParagraphPropertiesDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphPropertiesDefault(DXW.ParagraphPropertiesDefault openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.ParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
