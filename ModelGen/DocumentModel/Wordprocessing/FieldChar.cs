namespace DocumentModel.Wordprocessing;


/// <summary>
///   Complex Field Character.
/// </summary>
public partial class FieldChar: ModelElement<DXW.FieldChar>
{
  public FieldChar(): base(){ }
  
  public FieldChar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FieldChar(DXW.FieldChar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Field Should Not Be Recalculated
  /// </summary>
  [DataMember]
  public Boolean? FieldLock
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Field Result Invalidated
  /// </summary>
  [DataMember]
  public Boolean? Dirty
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Custom Field Data.
  /// </summary>
  [DataMember]
  public DMW.FieldData? FieldData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Form Field Properties.
  /// </summary>
  [DataMember]
  public DMW.FormFieldData? FormFieldData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Previous Numbering Field Properties.
  /// </summary>
  [DataMember]
  public DMW.NumberingChange? NumberingChange
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
