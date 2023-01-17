namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Write Protection.
/// </summary>
public static class WriteProtectionConverter
{
  /// <summary>
  /// Recommend Write Protection in User Interface
  /// </summary>
  private static Boolean? GetRecommended(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return openXmlElement?.Recommended?.Value;
  }
  
  private static void SetRecommended(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Recommended = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Recommended = null;
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  private static DocumentModel.Wordprocessing.CryptProviderKind? GetCryptographicProviderType(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DocumentModel.Wordprocessing.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value);
  }
  
  private static void SetCryptographicProviderType(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, DocumentModel.Wordprocessing.CryptProviderKind? value)
  {
    openXmlElement.CryptographicProviderType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DocumentModel.Wordprocessing.CryptProviderKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  private static DocumentModel.Wordprocessing.CryptAlgorithmClassKind? GetCryptographicAlgorithmClass(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DocumentModel.Wordprocessing.CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value);
  }
  
  private static void SetCryptographicAlgorithmClass(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, DocumentModel.Wordprocessing.CryptAlgorithmClassKind? value)
  {
    openXmlElement.CryptographicAlgorithmClass = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DocumentModel.Wordprocessing.CryptAlgorithmClassKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  private static DocumentModel.Wordprocessing.CryptAlgorithmKind? GetCryptographicAlgorithmType(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DocumentModel.Wordprocessing.CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value);
  }
  
  private static void SetCryptographicAlgorithmType(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, DocumentModel.Wordprocessing.CryptAlgorithmKind? value)
  {
    openXmlElement.CryptographicAlgorithmType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DocumentModel.Wordprocessing.CryptAlgorithmKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  private static Int32? GetCryptographicAlgorithmSid(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return openXmlElement.CryptographicAlgorithmSid?.Value;
  }
  
  private static void SetCryptographicAlgorithmSid(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, Int32? value)
  {
    openXmlElement.CryptographicAlgorithmSid = value;
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  private static UInt32? GetCryptographicSpinCount(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return openXmlElement.CryptographicSpinCount?.Value;
  }
  
  private static void SetCryptographicSpinCount(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, UInt32? value)
  {
    openXmlElement.CryptographicSpinCount = value;
  }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  private static String? GetCryptographicProvider(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return openXmlElement?.CryptographicProvider?.Value;
  }
  
  private static void SetCryptographicProvider(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CryptographicProvider = new StringValue { Value = value };
    else
      openXmlElement.CryptographicProvider = null;
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  private static UInt32? GetAlgorithmIdExtensibility(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    if (openXmlElement.AlgorithmIdExtensibility?.Value != null)
      return UInt32.Parse(openXmlElement.AlgorithmIdExtensibility.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetAlgorithmIdExtensibility(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AlgorithmIdExtensibility = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AlgorithmIdExtensibility = null;
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  private static String? GetAlgorithmIdExtensibilitySource(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return openXmlElement?.AlgorithmIdExtensibilitySource?.Value;
  }
  
  private static void SetAlgorithmIdExtensibilitySource(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlgorithmIdExtensibilitySource = new StringValue { Value = value };
    else
      openXmlElement.AlgorithmIdExtensibilitySource = null;
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  private static UInt32? GetCryptographicProviderTypeExtensibility(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    if (openXmlElement.CryptographicProviderTypeExtensibility?.Value != null)
      return UInt32.Parse(openXmlElement.CryptographicProviderTypeExtensibility.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCryptographicProviderTypeExtensibility(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.CryptographicProviderTypeExtensibility = ((UInt32)value).ToString("X8");
      else
        openXmlElement.CryptographicProviderTypeExtensibility = null;
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  private static String? GetCryptographicProviderTypeExtSource(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return openXmlElement?.CryptographicProviderTypeExtSource?.Value;
  }
  
  private static void SetCryptographicProviderTypeExtSource(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CryptographicProviderTypeExtSource = new StringValue { Value = value };
    else
      openXmlElement.CryptographicProviderTypeExtSource = null;
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  private static Byte[]? GetHash(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    if (openXmlElement.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value);
    return null;
  }
  
  private static void SetHash(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Hash = Convert.ToBase64String(value);
    else
      openXmlElement.Hash = null;
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  private static Byte[]? GetSalt(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    if (openXmlElement.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value);
    return null;
  }
  
  private static void SetSalt(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Salt = Convert.ToBase64String(value);
    else
      openXmlElement.Salt = null;
  }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetAlgorithmName(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return openXmlElement?.AlgorithmName?.Value;
  }
  
  private static void SetAlgorithmName(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlgorithmName = new StringValue { Value = value };
    else
      openXmlElement.AlgorithmName = null;
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static Byte[]? GetHashValue(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    if (openXmlElement.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value);
    return null;
  }
  
  private static void SetHashValue(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.HashValue = Convert.ToBase64String(value);
    else
      openXmlElement.HashValue = null;
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static Byte[]? GetSaltValue(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    if (openXmlElement.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value);
    return null;
  }
  
  private static void SetSaltValue(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.SaltValue = Convert.ToBase64String(value);
    else
      openXmlElement.SaltValue = null;
  }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSpinCount(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement)
  {
    return openXmlElement.SpinCount?.Value;
  }
  
  private static void SetSpinCount(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement, Int32? value)
  {
    openXmlElement.SpinCount = value;
  }
  
  public static DocumentModel.Wordprocessing.WriteProtection? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.WriteProtection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.WriteProtection();
      value.Recommended = GetRecommended(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.WriteProtection? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.WriteProtection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRecommended(openXmlElement, value?.Recommended);
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
