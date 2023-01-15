using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using WriteProtection = DocumentFormat.OpenXml.Wordprocessing.WriteProtection;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Write Protection.
/// </summary>
public static class WriteProtectionConverter
{
  /// <summary>
  ///   Recommend Write Protection in User Interface
  /// </summary>
  public static Boolean? GetRecommended(WriteProtection? openXmlElement)
  {
    return openXmlElement?.Recommended?.Value;
  }

  public static void SetRecommended(WriteProtection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Recommended = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Recommended = null;
  }

  /// <summary>
  ///   Cryptographic Provider Type
  /// </summary>
  public static CryptProviderKind? GetCryptographicProviderType(WriteProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<CryptProviderValues, CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value);
  }

  public static void SetCryptographicProviderType(WriteProtection? openXmlElement, CryptProviderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicProviderType = EnumValueConverter.CreateEnumValue<CryptProviderValues, CryptProviderKind>(value);
  }

  /// <summary>
  ///   Cryptographic Algorithm Class
  /// </summary>
  public static CryptAlgorithmClassKind? GetCryptographicAlgorithmClass(WriteProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<CryptAlgorithmClassValues, CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value);
  }

  public static void SetCryptographicAlgorithmClass(WriteProtection? openXmlElement, CryptAlgorithmClassKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmClass = EnumValueConverter.CreateEnumValue<CryptAlgorithmClassValues, CryptAlgorithmClassKind>(value);
  }

  /// <summary>
  ///   Cryptographic Algorithm Type
  /// </summary>
  public static CryptAlgorithmKind? GetCryptographicAlgorithmType(WriteProtection? openXmlElement)
  {
    return EnumValueConverter.GetValue<CryptAlgorithmValues, CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value);
  }

  public static void SetCryptographicAlgorithmType(WriteProtection? openXmlElement, CryptAlgorithmKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmType = EnumValueConverter.CreateEnumValue<CryptAlgorithmValues, CryptAlgorithmKind>(value);
  }

  /// <summary>
  ///   Cryptographic Hashing Algorithm
  /// </summary>
  public static Int32? GetCryptographicAlgorithmSid(WriteProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicAlgorithmSid?.Value;
  }

  public static void SetCryptographicAlgorithmSid(WriteProtection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicAlgorithmSid = value;
  }

  /// <summary>
  ///   Iterations to Run Hashing Algorithm
  /// </summary>
  public static UInt32? GetCryptographicSpinCount(WriteProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicSpinCount?.Value;
  }

  public static void SetCryptographicSpinCount(WriteProtection? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CryptographicSpinCount = value;
  }

  /// <summary>
  ///   Cryptographic Provider
  /// </summary>
  public static String? GetCryptographicProvider(WriteProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicProvider?.Value;
  }

  public static void SetCryptographicProvider(WriteProtection? openXmlElement, String? value)
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
  public static Byte[]? GetAlgorithmIdExtensibility(WriteProtection? openXmlElement)
  {
    if (openXmlElement?.AlgorithmIdExtensibility?.Value != null)
      return Convert.FromHexString(openXmlElement.AlgorithmIdExtensibility.Value);
    return null;
  }

  public static void SetAlgorithmIdExtensibility(WriteProtection? openXmlElement, Byte[]? value)
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
  public static String? GetAlgorithmIdExtensibilitySource(WriteProtection? openXmlElement)
  {
    return openXmlElement?.AlgorithmIdExtensibilitySource?.Value;
  }

  public static void SetAlgorithmIdExtensibilitySource(WriteProtection? openXmlElement, String? value)
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
  public static Byte[]? GetCryptographicProviderTypeExtensibility(WriteProtection? openXmlElement)
  {
    if (openXmlElement?.CryptographicProviderTypeExtensibility?.Value != null)
      return Convert.FromHexString(openXmlElement.CryptographicProviderTypeExtensibility.Value);
    return null;
  }

  public static void SetCryptographicProviderTypeExtensibility(WriteProtection? openXmlElement, Byte[]? value)
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
  public static String? GetCryptographicProviderTypeExtSource(WriteProtection? openXmlElement)
  {
    return openXmlElement?.CryptographicProviderTypeExtSource?.Value;
  }

  public static void SetCryptographicProviderTypeExtSource(WriteProtection? openXmlElement, String? value)
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
  public static Byte[]? GetHash(WriteProtection? openXmlElement)
  {
    if (openXmlElement?.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value);
    return null;
  }

  public static void SetHash(WriteProtection? openXmlElement, Byte[]? value)
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
  public static Byte[]? GetSalt(WriteProtection? openXmlElement)
  {
    if (openXmlElement?.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value);
    return null;
  }

  public static void SetSalt(WriteProtection? openXmlElement, Byte[]? value)
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
  public static String? GetAlgorithmName(WriteProtection? openXmlElement)
  {
    return openXmlElement?.AlgorithmName?.Value;
  }

  public static void SetAlgorithmName(WriteProtection? openXmlElement, String? value)
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
  public static Byte[]? GetHashValue(WriteProtection? openXmlElement)
  {
    if (openXmlElement?.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value);
    return null;
  }

  public static void SetHashValue(WriteProtection? openXmlElement, Byte[]? value)
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
  public static Byte[]? GetSaltValue(WriteProtection? openXmlElement)
  {
    if (openXmlElement?.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value);
    return null;
  }

  public static void SetSaltValue(WriteProtection? openXmlElement, Byte[]? value)
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
  public static Int32? GetSpinCount(WriteProtection? openXmlElement)
  {
    return openXmlElement?.SpinCount?.Value;
  }

  public static void SetSpinCount(WriteProtection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SpinCount = value;
  }

  public static DocumentModel.Wordprocessing.WriteProtection? CreateModelElement(WriteProtection? openXmlElement)
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
    where OpenXmlElementType : WriteProtection, new()
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