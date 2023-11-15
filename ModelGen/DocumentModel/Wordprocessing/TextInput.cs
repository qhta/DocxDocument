namespace DocumentModel.Wordprocessing;


/// <summary>
///   Text Box Form Field Properties.
/// </summary>
public partial class TextInput: ModelElement<DXW.TextInput>
{
  public TextInput(): base(){ }
  
  public TextInput(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextInput(DXW.TextInput openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Box Form Field Type.
  /// </summary>
  [DataMember]
  public DMW.TextBoxFormFieldKind? TextBoxFormFieldType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Default Text Box Form Field String.
  /// </summary>
  [DataMember]
  public DMW.DefaultTextBoxFormFieldString? DefaultTextBoxFormFieldString
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String255Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String255Type");
  }
  
  
  /// <summary>
  ///   Text Box Form Field Maximum Length.
  /// </summary>
  [DataMember]
  public Int16? MaxLength
  {
    get => _Element?.GetIntVal<Int16, DXW.MaxLength>();
    set => _ExistingElement.SetIntVal<Int16, DXW.MaxLength>(value);
  }
  
  
  /// <summary>
  ///   Text Box Form Field Formatting.
  /// </summary>
  [DataMember]
  public String? Format
  {
    get => _Element?.GetStringVal<DXW.Format>();
    set => _ExistingElement.SetStringVal<DXW.Format>(value);
  }
  
}
