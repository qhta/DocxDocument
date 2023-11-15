namespace DocumentModel.Drawings;


/// <summary>
///   Text Paragraphs.
/// </summary>
public partial class Paragraph: ModelElement<DXD.Paragraph>
{
  public Paragraph(): base(){ }
  
  public Paragraph(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Paragraph(DXD.Paragraph openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMD.ParagraphProperties? ParagraphProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType");
  }
  
  [DataMember]
  public DMD.EndParagraphRunProperties? EndParagraphRunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType");
  }
  
}
