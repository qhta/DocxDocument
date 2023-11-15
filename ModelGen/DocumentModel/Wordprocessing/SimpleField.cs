namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SimpleField Class.
/// </summary>
public partial class SimpleField: ModelElement<DXW.SimpleField>
{
  public SimpleField(): base(){ }
  
  public SimpleField(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SimpleField(DXW.SimpleField openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Field Codes
  /// </summary>
  [DataMember]
  public String? Instruction
  {
    get => _Element?.Instruction;
    set => _ExistingElement.Instruction = value;
  }
  
  
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
  
}
