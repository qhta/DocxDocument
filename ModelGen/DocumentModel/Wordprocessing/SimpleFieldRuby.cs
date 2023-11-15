namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SimpleFieldRuby Class.
/// </summary>
public partial class SimpleFieldRuby: ModelElement<DXW.SimpleFieldRuby>
{
  public SimpleFieldRuby(): base(){ }
  
  public SimpleFieldRuby(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SimpleFieldRuby(DXW.SimpleFieldRuby openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   instr
  /// </summary>
  [DataMember]
  public String? Instruction
  {
    get => _Element?.Instruction;
    set => _ExistingElement.Instruction = value;
  }
  
  
  /// <summary>
  ///   fldLock
  /// </summary>
  [DataMember]
  public Boolean? FieldLock
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  [DataMember]
  public Boolean? Dirty
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   FieldData.
  /// </summary>
  [DataMember]
  public DMW.FieldData? FieldData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
