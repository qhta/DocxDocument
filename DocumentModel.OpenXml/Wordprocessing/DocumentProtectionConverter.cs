namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Editing Restrictions.
/// </summary>
public static class DocumentProtectionConverter
{
  /// <summary>
  /// Document Editing Restrictions
  /// </summary>
  public static DocumentModel.Wordprocessing.DocumentProtectionKind? GetEdit(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues, DocumentModel.Wordprocessing.DocumentProtectionKind>(openXmlElement?.Edit?.Value);
  }
  
  public static void SetEdit(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Wordprocessing.DocumentProtectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Edit = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues, DocumentModel.Wordprocessing.DocumentProtectionKind>(value);
  }
  
  /// <summary>
  /// Only Allow Formatting With Unlocked Styles
  /// </summary>
  public static Boolean? GetFormatting(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.Formatting?.Value;
  }
  
  public static void SetFormatting(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Formatting = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Formatting = null;
  }
  
  /// <summary>
  /// Enforce Document Protection Settings
  /// </summary>
  public static Boolean? GetEnforcement(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.Enforcement?.Value;
  }
  
  public static void SetEnforcement(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enforcement = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Enforcement = null;
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public static DocumentModel.Wordprocessing.CryptProviderKind? GetCryptographicProviderType(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DocumentModel.Wordprocessing.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value);
  }
  
  public static void SetCryptographicProviderType(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Wordprocessing.CryptProviderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicProviderType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DocumentModel.Wordprocessing.CryptProviderKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public static DocumentModel.Wordprocessing.CryptAlgorithmClassKind? GetCryptographicAlgorithmClass(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DocumentModel.Wordprocessing.CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value);
  }
  
  public static void SetCryptographicAlgorithmClass(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Wordprocessing.CryptAlgorithmClassKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmClass = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DocumentModel.Wordprocessing.CryptAlgorithmClassKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public static DocumentModel.Wordprocessing.CryptAlgorithmKind? GetCryptographicAlgorithmType(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DocumentModel.Wordprocessing.CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value);
  }
  
  public static void SetCryptographicAlgorithmType(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Wordprocessing.CryptAlgorithmKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DocumentModel.Wordprocessing.CryptAlgorithmKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public static Int32? GetCryptographicAlgorithmSid(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicAlgorithmSid?.Value;
  }
  
  public static void SetCryptographicAlgorithmSid(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmSid = value;
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public static UInt32? GetCryptographicSpinCount(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicSpinCount?.Value;
  }
  
  public static void SetCryptographicSpinCount(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicSpinCount = value;
  }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public static String? GetCryptographicProvider(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicProvider?.Value;
  }
  
  public static void SetCryptographicProvider(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CryptographicProvider = new StringValue { Value = value };
      else
        openXmlElement.CryptographicProvider = null;
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public static DocumentModel.HexBinary? GetAlgorithmIdExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetAlgorithmIdExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public static String? GetAlgorithmIdExtensibilitySource(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.AlgorithmIdExtensibilitySource?.Value;
  }
  
  public static void SetAlgorithmIdExtensibilitySource(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlgorithmIdExtensibilitySource = new StringValue { Value = value };
      else
        openXmlElement.AlgorithmIdExtensibilitySource = null;
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public static DocumentModel.HexBinary? GetCryptographicProviderTypeExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetCryptographicProviderTypeExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public static String? GetCryptographicProviderTypeExtSource(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicProviderTypeExtSource?.Value;
  }
  
  public static void SetCryptographicProviderTypeExtSource(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CryptographicProviderTypeExtSource = new StringValue { Value = value };
      else
        openXmlElement.CryptographicProviderTypeExtSource = null;
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public static DocumentModel.Base64Binary? GetHash(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  public static void SetHash(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public static DocumentModel.Base64Binary? GetSalt(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  public static void SetSalt(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetAlgorithmName(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.AlgorithmName?.Value;
  }
  
  public static void SetAlgorithmName(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlgorithmName = new StringValue { Value = value };
      else
        openXmlElement.AlgorithmName = null;
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Base64Binary? GetHashValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  public static void SetHashValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Base64Binary? GetSaltValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  public static void SetSaltValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSpinCount(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    return openXmlElement?.SpinCount?.Value;
  }
  
  public static void SetSpinCount(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SpinCount = value;
  }
  
  public static DocumentModel.Wordprocessing.DocumentProtection? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocumentProtection();
      value.Edit = GetEdit(openXmlElement);
      value.Formatting = GetFormatting(openXmlElement);
      value.Enforcement = GetEnforcement(openXmlElement);
      value.CryptographicProviderType = GetCryptographicProviderType(openXmlElement);
      value.CryptographicAlgorithmClass = GetCryptographicAlgorithmClass(openXmlElement);
      value.CryptographicAlgorithmType = GetCryptographicAlgorithmType(openXmlElement);
      value.CryptographicAlgorithmSid = GetCryptographicAlgorithmSid(openXmlElement);
      value.CryptographicSpinCount = GetCryptographicSpinCount(openXmlElement);
      value.CryptographicProvider = GetCryptographicProvider(openXmlElement);
      value.AlgorithmIdExtensibility = GetAlgorithmIdExtensibility(openXmlElement);
      value.AlgorithmIdExtensibilitySource = GetAlgorithmIdExtensibilitySource(openXmlElement);
      value.CryptographicProviderTypeExtensibility = GetCryptographicProviderTypeExtensibility(openXmlElement);
      value.CryptographicProviderTypeExtSource = GetCryptographicProviderTypeExtSource(openXmlElement);
      value.Hash = GetHash(openXmlElement);
      value.Salt = GetSalt(openXmlElement);
      value.AlgorithmName = GetAlgorithmName(openXmlElement);
      value.HashValue = GetHashValue(openXmlElement);
      value.SaltValue = GetSaltValue(openXmlElement);
      value.SpinCount = GetSpinCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocumentProtection? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocumentProtection, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
