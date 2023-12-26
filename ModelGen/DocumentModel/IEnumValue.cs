namespace DocumentModel;


/// <summary>
///   A definition of an OpenXml enum value
/// </summary>
public partial class IEnumValue: ModelElement<DX.IEnumValue>
{
  public IEnumValue(): base(){ }
  
  public IEnumValue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public IEnumValue(DX.IEnumValue openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets a value indicating whether the current value is valid.
  /// </summary>
  [DataMember]
  public Boolean? IsValid
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is System.Boolean");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is System.Boolean");
  }
  
  
  /// <summary>
  ///   Gets the version this type was introduced in.
  /// </summary>
  [DataMember]
  public DM.FileFormatVersions? Version
  {
    get => EnumValueConverter.Convert<DM.FileFormatVersions, DX.FileFormatVersions>(_Element?.Version);
    set => throw new NotImplementedException("Not implemented in GenerateSimpleEnumTypePropertySetCode: enum propertyType is DocumentFormat.OpenXml.FileFormatVersions");
  }
  
  
  /// <summary>
  ///   Gets the value of the enum.
  /// </summary>
  [DataMember]
  public String? Value
  {
    get => throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: string propertyType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: string propertyType baseType is System.Object");
  }
  
}
