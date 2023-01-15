using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using DocumentProtection = DocumentFormat.OpenXml.Wordprocessing.DocumentProtection;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document Editing Restrictions.
/// </summary>
public static class DocumentProtectionConverter
{
  /// <summary>
  ///   Document Editing Restrictions
  /// </summary>
  public static DocumentProtectionKind? GetEdit(DocumentProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentProtectionValues, DocumentProtectionKind>(openXmlElement?.Edit?.Value);
  }

  public static void SetEdit(DocumentProtection? openXmlElement, DocumentProtectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Edit = EnumValueConverter.CreateEnumValue<DocumentProtectionValues, DocumentProtectionKind>(value);
  }

  /// <summary>
  ///   Only Allow Formatting With Unlocked Styles
  /// </summary>
  public static Boolean? GetFormatting(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.Formatting?.Value;
  }

  public static void SetFormatting(DocumentProtection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Formatting = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Formatting = null;
  }

  /// <summary>
  ///   Enforce Document Protection Settings
  /// </summary>
  public static Boolean? GetEnforcement(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.Enforcement?.Value;
  }

  public static void SetEnforcement(DocumentProtection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enforcement = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Enforcement = null;
  }

  /// <summary>
  ///   Cryptographic Provider Type
  /// </summary>
  public static CryptProviderKind? GetCryptographicProviderType(DocumentProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<CryptProviderValues, CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value);
  }

  public static void SetCryptographicProviderType(DocumentProtection? openXmlElement, CryptProviderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicProviderType = EnumValueConverter.CreateEnumValue<CryptProviderValues, CryptProviderKind>(value);
  }

  /// <summary>
  ///   Cryptographic Algorithm Class
  /// </summary>
  public static CryptAlgorithmClassKind? GetCryptographicAlgorithmClass(DocumentProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<CryptAlgorithmClassValues, CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value);
  }

  public static void SetCryptographicAlgorithmClass(DocumentProtection? openXmlElement, CryptAlgorithmClassKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmClass = EnumValueConverter.CreateEnumValue<CryptAlgorithmClassValues, CryptAlgorithmClassKind>(value);
  }

  /// <summary>
  ///   Cryptographic Algorithm Type
  /// </summary>
  public static CryptAlgorithmKind? GetCryptographicAlgorithmType(DocumentProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<CryptAlgorithmValues, CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value);
  }

  public static void SetCryptographicAlgorithmType(DocumentProtection? openXmlElement, CryptAlgorithmKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmType = EnumValueConverter.CreateEnumValue<CryptAlgorithmValues, CryptAlgorithmKind>(value);
  }

  /// <summary>
  ///   Cryptographic Hashing Algorithm
  /// </summary>
  public static Int32? GetCryptographicAlgorithmSid(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicAlgorithmSid?.Value;
  }

  public static void SetCryptographicAlgorithmSid(DocumentProtection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmSid = value;
  }

  /// <summary>
  ///   Iterations to Run Hashing Algorithm
  /// </summary>
  public static UInt32? GetCryptographicSpinCount(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicSpinCount?.Value;
  }

  public static void SetCryptographicSpinCount(DocumentProtection? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicSpinCount = value;
  }

  /// <summary>
  ///   Cryptographic Provider
  /// </summary>
  public static String? GetCryptographicProvider(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicProvider?.Value;
  }

  public static void SetCryptographicProvider(DocumentProtection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CryptographicProvider = new StringValue { Value = value };
      else
        openXmlElement.CryptographicProvider = null;
  }

  /// <summary>
  ///   Cryptographic Algorithm Extensibility
  /// </summary>
  public static Byte[]? GetAlgorithmIdExtensibility(DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.AlgorithmIdExtensibility?.Value != null)
      return Convert.FromHexString(openXmlElement.AlgorithmIdExtensibility.Value);
    return null;
  }

  public static void SetAlgorithmIdExtensibility(DocumentProtection? openXmlElement, Byte[]? value)
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
  ///   Algorithm Extensibility Source
  /// </summary>
  public static String? GetAlgorithmIdExtensibilitySource(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.AlgorithmIdExtensibilitySource?.Value;
  }

  public static void SetAlgorithmIdExtensibilitySource(DocumentProtection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlgorithmIdExtensibilitySource = new StringValue { Value = value };
      else
        openXmlElement.AlgorithmIdExtensibilitySource = null;
  }

  /// <summary>
  ///   Cryptographic Provider Type Extensibility
  /// </summary>
  public static Byte[]? GetCryptographicProviderTypeExtensibility(DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.CryptographicProviderTypeExtensibility?.Value != null)
      return Convert.FromHexString(openXmlElement.CryptographicProviderTypeExtensibility.Value);
    return null;
  }

  public static void SetCryptographicProviderTypeExtensibility(DocumentProtection? openXmlElement, Byte[]? value)
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
  ///   Provider Type Extensibility Source
  /// </summary>
  public static String? GetCryptographicProviderTypeExtSource(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicProviderTypeExtSource?.Value;
  }

  public static void SetCryptographicProviderTypeExtSource(DocumentProtection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CryptographicProviderTypeExtSource = new StringValue { Value = value };
      else
        openXmlElement.CryptographicProviderTypeExtSource = null;
  }

  /// <summary>
  ///   Password Hash
  /// </summary>
  public static Byte[]? GetHash(DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value);
    return null;
  }

  public static void SetHash(DocumentProtection? openXmlElement, Byte[]? value)
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
  ///   Salt for Password Verifier
  /// </summary>
  public static Byte[]? GetSalt(DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value);
    return null;
  }

  public static void SetSalt(DocumentProtection? openXmlElement, Byte[]? value)
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
  ///   algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetAlgorithmName(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.AlgorithmName?.Value;
  }

  public static void SetAlgorithmName(DocumentProtection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlgorithmName = new StringValue { Value = value };
      else
        openXmlElement.AlgorithmName = null;
  }

  /// <summary>
  ///   hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetHashValue(DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value);
    return null;
  }

  public static void SetHashValue(DocumentProtection? openXmlElement, Byte[]? value)
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
  ///   saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetSaltValue(DocumentProtection? openXmlElement)
  {
    if (openXmlElement?.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value);
    return null;
  }

  public static void SetSaltValue(DocumentProtection? openXmlElement, Byte[]? value)
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
  ///   spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSpinCount(DocumentProtection? openXmlElement)
  {
    return openXmlElement?.SpinCount?.Value;
  }

  public static void SetSpinCount(DocumentProtection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SpinCount = value;
  }

  public static DocumentModel.Wordprocessing.DocumentProtection? CreateModelElement(DocumentProtection? openXmlElement)
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
    where OpenXmlElementType : DocumentProtection, new()
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