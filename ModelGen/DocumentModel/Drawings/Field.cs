namespace DocumentModel.Drawings;


/// <summary>
///   Text Field.
/// </summary>
public partial class Field: ModelElement<DXD.Field>
{
  public Field(): base(){ }
  
  public Field(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Field(DXD.Field openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Field ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Field Type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get => _Element?.Type;
    set => _ExistingElement.Type = value;
  }
  
  
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  [DataMember]
  public DMD.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType");
  }
  
  
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMD.ParagraphProperties? ParagraphProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType");
  }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  [DataMember]
  public DMD.Text? Text
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
