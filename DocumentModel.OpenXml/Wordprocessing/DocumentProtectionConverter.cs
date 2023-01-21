namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Editing Restrictions.
/// </summary>
public static class DocumentProtectionConverter
{
  /// <summary>
  /// Document Editing Restrictions
  /// </summary>
  private static DMW.DocumentProtectionKind? GetEdit(DXW.DocumentProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues, DMW.DocumentProtectionKind>(openXmlElement?.Edit?.Value);
  }
  
  private static void SetEdit(DXW.DocumentProtection openXmlElement, DMW.DocumentProtectionKind? value)
  {
    openXmlElement.Edit = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues, DMW.DocumentProtectionKind>(value);
  }
  
  /// <summary>
  /// Only Allow Formatting With Unlocked Styles
  /// </summary>
  private static Boolean? GetFormatting(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement?.Formatting?.Value;
  }
  
  private static void SetFormatting(DXW.DocumentProtection openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Formatting = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Formatting = null;
  }
  
  /// <summary>
  /// Enforce Document Protection Settings
  /// </summary>
  private static Boolean? GetEnforcement(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement?.Enforcement?.Value;
  }
  
  private static void SetEnforcement(DXW.DocumentProtection openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enforcement = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Enforcement = null;
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  private static DMW.CryptProviderKind? GetCryptographicProviderType(DXW.DocumentProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DMW.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value);
  }
  
  private static void SetCryptographicProviderType(DXW.DocumentProtection openXmlElement, DMW.CryptProviderKind? value)
  {
    openXmlElement.CryptographicProviderType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DMW.CryptProviderKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  private static DMW.CryptAlgorithmClassKind? GetCryptographicAlgorithmClass(DXW.DocumentProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value);
  }
  
  private static void SetCryptographicAlgorithmClass(DXW.DocumentProtection openXmlElement, DMW.CryptAlgorithmClassKind? value)
  {
    openXmlElement.CryptographicAlgorithmClass = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  private static DMW.CryptAlgorithmKind? GetCryptographicAlgorithmType(DXW.DocumentProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value);
  }
  
  private static void SetCryptographicAlgorithmType(DXW.DocumentProtection openXmlElement, DMW.CryptAlgorithmKind? value)
  {
    openXmlElement.CryptographicAlgorithmType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  private static Int32? GetCryptographicAlgorithmSid(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement.CryptographicAlgorithmSid?.Value;
  }
  
  private static void SetCryptographicAlgorithmSid(DXW.DocumentProtection openXmlElement, Int32? value)
  {
    openXmlElement.CryptographicAlgorithmSid = value;
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  private static UInt32? GetCryptographicSpinCount(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement.CryptographicSpinCount?.Value;
  }
  
  private static void SetCryptographicSpinCount(DXW.DocumentProtection openXmlElement, UInt32? value)
  {
    openXmlElement.CryptographicSpinCount = value;
  }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  private static String? GetCryptographicProvider(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement?.CryptographicProvider?.Value;
  }
  
  private static void SetCryptographicProvider(DXW.DocumentProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CryptographicProvider = new StringValue { Value = value };
    else
      openXmlElement.CryptographicProvider = null;
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  private static UInt32? GetAlgorithmIdExtensibility(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement.AlgorithmIdExtensibility?.Value != null)
      return UInt32.Parse(openXmlElement.AlgorithmIdExtensibility.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetAlgorithmIdExtensibility(DXW.DocumentProtection openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AlgorithmIdExtensibility = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AlgorithmIdExtensibility = null;
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  private static String? GetAlgorithmIdExtensibilitySource(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement?.AlgorithmIdExtensibilitySource?.Value;
  }
  
  private static void SetAlgorithmIdExtensibilitySource(DXW.DocumentProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlgorithmIdExtensibilitySource = new StringValue { Value = value };
    else
      openXmlElement.AlgorithmIdExtensibilitySource = null;
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  private static UInt32? GetCryptographicProviderTypeExtensibility(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement.CryptographicProviderTypeExtensibility?.Value != null)
      return UInt32.Parse(openXmlElement.CryptographicProviderTypeExtensibility.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCryptographicProviderTypeExtensibility(DXW.DocumentProtection openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.CryptographicProviderTypeExtensibility = ((UInt32)value).ToString("X8");
      else
        openXmlElement.CryptographicProviderTypeExtensibility = null;
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  private static String? GetCryptographicProviderTypeExtSource(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement?.CryptographicProviderTypeExtSource?.Value;
  }
  
  private static void SetCryptographicProviderTypeExtSource(DXW.DocumentProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CryptographicProviderTypeExtSource = new StringValue { Value = value };
    else
      openXmlElement.CryptographicProviderTypeExtSource = null;
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  private static Byte[]? GetHash(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value);
    return null;
  }
  
  private static void SetHash(DXW.DocumentProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Hash = Convert.ToBase64String(value);
    else
      openXmlElement.Hash = null;
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  private static Byte[]? GetSalt(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value);
    return null;
  }
  
  private static void SetSalt(DXW.DocumentProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Salt = Convert.ToBase64String(value);
    else
      openXmlElement.Salt = null;
  }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetAlgorithmName(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement?.AlgorithmName?.Value;
  }
  
  private static void SetAlgorithmName(DXW.DocumentProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlgorithmName = new StringValue { Value = value };
    else
      openXmlElement.AlgorithmName = null;
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static Byte[]? GetHashValue(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value);
    return null;
  }
  
  private static void SetHashValue(DXW.DocumentProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.HashValue = Convert.ToBase64String(value);
    else
      openXmlElement.HashValue = null;
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static Byte[]? GetSaltValue(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value);
    return null;
  }
  
  private static void SetSaltValue(DXW.DocumentProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.SaltValue = Convert.ToBase64String(value);
    else
      openXmlElement.SaltValue = null;
  }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSpinCount(DXW.DocumentProtection openXmlElement)
  {
    return openXmlElement.SpinCount?.Value;
  }
  
  private static void SetSpinCount(DXW.DocumentProtection openXmlElement, Int32? value)
  {
    openXmlElement.SpinCount = value;
  }
  
  public static DMW.DocumentProtection? CreateModelElement(DXW.DocumentProtection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocumentProtection();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocumentProtection? value)
    where OpenXmlElementType: DXW.DocumentProtection, new()
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
