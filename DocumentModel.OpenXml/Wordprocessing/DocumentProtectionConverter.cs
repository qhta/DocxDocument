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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFormatting(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Enforce Document Protection Settings
  /// </summary>
  public static Boolean? GetEnforcement(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEnforcement(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCryptographicAlgorithmSid(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public static UInt32? GetCryptographicSpinCount(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCryptographicSpinCount(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public static String? GetCryptographicProvider(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetCryptographicProvider(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public static DocumentModel.HexBinary? GetAlgorithmIdExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlgorithmIdExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public static String? GetAlgorithmIdExtensibilitySource(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAlgorithmIdExtensibilitySource(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public static DocumentModel.HexBinary? GetCryptographicProviderTypeExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCryptographicProviderTypeExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public static String? GetCryptographicProviderTypeExtSource(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetCryptographicProviderTypeExtSource(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public static DocumentModel.Base64Binary? GetHash(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHash(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public static DocumentModel.Base64Binary? GetSalt(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSalt(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetAlgorithmName(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAlgorithmName(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Base64Binary? GetHashValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHashValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Base64Binary? GetSaltValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaltValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSpinCount(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSpinCount(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
