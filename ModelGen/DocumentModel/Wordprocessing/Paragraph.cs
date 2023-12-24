namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a paragraph of content in the document.
/// </summary>
public partial class Paragraph: ModelElement<DXW.Paragraph>
{
  public Paragraph(): base(){ }
  
  public Paragraph(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Paragraph(DXW.Paragraph openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidParagraphMarkRevision
  {
    get => HexIntConverter.GetValue(_Element?.RsidParagraphMarkRevision);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidParagraphAddition
  {
    get => HexIntConverter.GetValue(_Element?.RsidParagraphAddition);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Deletion
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidParagraphDeletion
  {
    get => HexIntConverter.GetValue(_Element?.RsidParagraphDeletion);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Properties
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidParagraphProperties
  {
    get => HexIntConverter.GetValue(_Element?.RsidParagraphProperties);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Default Revision Identifier for Runs
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRunAdditionDefault
  {
    get => HexIntConverter.GetValue(_Element?.RsidRunAdditionDefault);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParagraphId
  {
    get => HexIntConverter.GetValue(_Element?.ParagraphId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? TextId
  {
    get => HexIntConverter.GetValue(_Element?.TextId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? NoSpellError
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.ParagraphProperties? ParagraphProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
