namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document Editing Restrictions.
/// </summary>
public partial class DocumentProtection: ModelElement<DXW.DocumentProtection>
{
  public DocumentProtection(): base(){ }
  
  public DocumentProtection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentProtection(DXW.DocumentProtection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Only Allow Formatting With Unlocked Styles
  /// </summary>
  [DataMember]
  public Boolean? Formatting
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Enforce Document Protection Settings
  /// </summary>
  [DataMember]
  public Boolean? Enforcement
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Cryptographic Hashing Algorithm
  /// </summary>
  [DataMember]
  public Int32? CryptographicAlgorithmSid
  {
    get => _Element?.CryptographicAlgorithmSid?.Value;
    set => _ExistingElement.CryptographicAlgorithmSid = value;
  }
  
  
  /// <summary>
  ///   Iterations to Run Hashing Algorithm
  /// </summary>
  [DataMember]
  public UInt32? CryptographicSpinCount
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Cryptographic Provider
  /// </summary>
  [DataMember]
  public String? CryptographicProvider
  {
    get => _Element?.CryptographicProvider;
    set => _ExistingElement.CryptographicProvider = value;
  }
  
  
  /// <summary>
  ///   Cryptographic Algorithm Extensibility
  /// </summary>
  [DataMember]
  public DM.HexBinary? AlgorithmIdExtensibility
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Algorithm Extensibility Source
  /// </summary>
  [DataMember]
  public String? AlgorithmIdExtensibilitySource
  {
    get => _Element?.AlgorithmIdExtensibilitySource;
    set => _ExistingElement.AlgorithmIdExtensibilitySource = value;
  }
  
  
  /// <summary>
  ///   Cryptographic Provider Type Extensibility
  /// </summary>
  [DataMember]
  public DM.HexBinary? CryptographicProviderTypeExtensibility
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Provider Type Extensibility Source
  /// </summary>
  [DataMember]
  public String? CryptographicProviderTypeExtSource
  {
    get => _Element?.CryptographicProviderTypeExtSource;
    set => _ExistingElement.CryptographicProviderTypeExtSource = value;
  }
  
  
  /// <summary>
  ///   Password Hash
  /// </summary>
  [DataMember]
  public DM.Base64Binary? Hash
  {
    get => Base64BinaryConverter.GetValue(_Element?.Hash);
    set => _ExistingElement.Hash = Base64BinaryConverter.CreateBase64BinaryValue(value);
  }
  
  
  /// <summary>
  ///   Salt for Password Verifier
  /// </summary>
  [DataMember]
  public DM.Base64Binary? Salt
  {
    get => Base64BinaryConverter.GetValue(_Element?.Salt);
    set => _ExistingElement.Salt = Base64BinaryConverter.CreateBase64BinaryValue(value);
  }
  
  
  /// <summary>
  ///   algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? AlgorithmName
  {
    get => _Element?.AlgorithmName;
    set => _ExistingElement.AlgorithmName = value;
  }
  
  
  /// <summary>
  ///   hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.Base64Binary? HashValue
  {
    get => Base64BinaryConverter.GetValue(_Element?.HashValue);
    set => _ExistingElement.HashValue = Base64BinaryConverter.CreateBase64BinaryValue(value);
  }
  
  
  /// <summary>
  ///   saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.Base64Binary? SaltValue
  {
    get => Base64BinaryConverter.GetValue(_Element?.SaltValue);
    set => _ExistingElement.SaltValue = Base64BinaryConverter.CreateBase64BinaryValue(value);
  }
  
  
  /// <summary>
  ///   spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? SpinCount
  {
    get => _Element?.SpinCount?.Value;
    set => _ExistingElement.SpinCount = value;
  }
  
}
