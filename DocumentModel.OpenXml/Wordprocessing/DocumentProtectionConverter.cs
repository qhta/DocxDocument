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
  public static Byte[]? GetAlgorithmIdExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.AlgorithmIdExtensibility?.Value != null)
      return Convert.FromHexString(openXmlElement.AlgorithmIdExtensibility.Value);
    return null;
  }
  
  public static void SetAlgorithmIdExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.AlgorithmIdExtensibility = Convert.ToHexString(value);
      else
        openXmlElement.AlgorithmIdExtensibility = null;
    }
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
  public static Byte[]? GetCryptographicProviderTypeExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.CryptographicProviderTypeExtensibility?.Value != null)
      return Convert.FromHexString(openXmlElement.CryptographicProviderTypeExtensibility.Value);
    return null;
  }
  
  public static void SetCryptographicProviderTypeExtensibility(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.CryptographicProviderTypeExtensibility = Convert.ToHexString(value);
      else
        openXmlElement.CryptographicProviderTypeExtensibility = null;
    }
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
  public static Byte[]? GetHash(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value);
    return null;
  }
  
  public static void SetHash(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Hash = Convert.ToBase64String(value);
      else
        openXmlElement.Hash = null;
    }
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public static Byte[]? GetSalt(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value);
    return null;
  }
  
  public static void SetSalt(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Salt = Convert.ToBase64String(value);
      else
        openXmlElement.Salt = null;
    }
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
  public static Byte[]? GetHashValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value);
    return null;
  }
  
  public static void SetHashValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.HashValue = Convert.ToBase64String(value);
      else
        openXmlElement.HashValue = null;
    }
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetSaltValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value);
    return null;
  }
  
  public static void SetSaltValue(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.SaltValue = Convert.ToBase64String(value);
      else
        openXmlElement.SaltValue = null;
    }
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEdit(openXmlElement, value?.Edit);
      SetFormatting(openXmlElement, value?.Formatting);
      SetEnforcement(openXmlElement, value?.Enforcement);
      SetCryptographicProviderType(openXmlElement, value?.CryptographicProviderType);
      SetCryptographicAlgorithmClass(openXmlElement, value?.CryptographicAlgorithmClass);
      SetCryptographicAlgorithmType(openXmlElement, value?.CryptographicAlgorithmType);
      SetCryptographicAlgorithmSid(openXmlElement, value?.CryptographicAlgorithmSid);
      SetCryptographicSpinCount(openXmlElement, value?.CryptographicSpinCount);
      SetCryptographicProvider(openXmlElement, value?.CryptographicProvider);
      SetAlgorithmIdExtensibility(openXmlElement, value?.AlgorithmIdExtensibility);
      SetAlgorithmIdExtensibilitySource(openXmlElement, value?.AlgorithmIdExtensibilitySource);
      SetCryptographicProviderTypeExtensibility(openXmlElement, value?.CryptographicProviderTypeExtensibility);
      SetCryptographicProviderTypeExtSource(openXmlElement, value?.CryptographicProviderTypeExtSource);
      SetHash(openXmlElement, value?.Hash);
      SetSalt(openXmlElement, value?.Salt);
      SetAlgorithmName(openXmlElement, value?.AlgorithmName);
      SetHashValue(openXmlElement, value?.HashValue);
      SetSaltValue(openXmlElement, value?.SaltValue);
      SetSpinCount(openXmlElement, value?.SpinCount);
      return openXmlElement;
    }
    return default;
  }
}
