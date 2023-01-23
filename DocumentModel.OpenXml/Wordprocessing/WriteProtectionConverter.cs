namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Write Protection.
/// </summary>
public static class WriteProtectionConverter
{
  /// <summary>
  /// Recommend Write Protection in User Interface
  /// </summary>
  private static Boolean? GetRecommended(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement?.Recommended?.Value;
  }
  
  private static bool CmpRecommended(DXW.WriteProtection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Recommended?.Value == value;
  }
  
  private static void SetRecommended(DXW.WriteProtection openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Recommended = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Recommended = null;
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  private static DMW.CryptProviderKind? GetCryptographicProviderType(DXW.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DMW.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value);
  }
  
  private static bool CmpCryptographicProviderType(DXW.WriteProtection openXmlElement, DMW.CryptProviderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DMW.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCryptographicProviderType(DXW.WriteProtection openXmlElement, DMW.CryptProviderKind? value)
  {
    openXmlElement.CryptographicProviderType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DMW.CryptProviderKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  private static DMW.CryptAlgorithmClassKind? GetCryptographicAlgorithmClass(DXW.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value);
  }
  
  private static bool CmpCryptographicAlgorithmClass(DXW.WriteProtection openXmlElement, DMW.CryptAlgorithmClassKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCryptographicAlgorithmClass(DXW.WriteProtection openXmlElement, DMW.CryptAlgorithmClassKind? value)
  {
    openXmlElement.CryptographicAlgorithmClass = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  private static DMW.CryptAlgorithmKind? GetCryptographicAlgorithmType(DXW.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value);
  }
  
  private static bool CmpCryptographicAlgorithmType(DXW.WriteProtection openXmlElement, DMW.CryptAlgorithmKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCryptographicAlgorithmType(DXW.WriteProtection openXmlElement, DMW.CryptAlgorithmKind? value)
  {
    openXmlElement.CryptographicAlgorithmType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  private static Int32? GetCryptographicAlgorithmSid(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement.CryptographicAlgorithmSid?.Value;
  }
  
  private static bool CmpCryptographicAlgorithmSid(DXW.WriteProtection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.CryptographicAlgorithmSid?.Value == value;
  }
  
  private static void SetCryptographicAlgorithmSid(DXW.WriteProtection openXmlElement, Int32? value)
  {
    openXmlElement.CryptographicAlgorithmSid = value;
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  private static UInt32? GetCryptographicSpinCount(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement.CryptographicSpinCount?.Value;
  }
  
  private static bool CmpCryptographicSpinCount(DXW.WriteProtection openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.CryptographicSpinCount?.Value == value;
  }
  
  private static void SetCryptographicSpinCount(DXW.WriteProtection openXmlElement, UInt32? value)
  {
    openXmlElement.CryptographicSpinCount = value;
  }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  private static String? GetCryptographicProvider(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement?.CryptographicProvider?.Value;
  }
  
  private static bool CmpCryptographicProvider(DXW.WriteProtection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CryptographicProvider?.Value == value;
  }
  
  private static void SetCryptographicProvider(DXW.WriteProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CryptographicProvider = new StringValue { Value = value };
    else
      openXmlElement.CryptographicProvider = null;
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  private static UInt32? GetAlgorithmIdExtensibility(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement.AlgorithmIdExtensibility?.Value != null)
      return UInt32.Parse(openXmlElement.AlgorithmIdExtensibility.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpAlgorithmIdExtensibility(DXW.WriteProtection openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.AlgorithmIdExtensibility?.Value != null)
      return UInt32.Parse(openXmlElement.AlgorithmIdExtensibility.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetAlgorithmIdExtensibility(DXW.WriteProtection openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AlgorithmIdExtensibility = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AlgorithmIdExtensibility = null;
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  private static String? GetAlgorithmIdExtensibilitySource(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement?.AlgorithmIdExtensibilitySource?.Value;
  }
  
  private static bool CmpAlgorithmIdExtensibilitySource(DXW.WriteProtection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AlgorithmIdExtensibilitySource?.Value == value;
  }
  
  private static void SetAlgorithmIdExtensibilitySource(DXW.WriteProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlgorithmIdExtensibilitySource = new StringValue { Value = value };
    else
      openXmlElement.AlgorithmIdExtensibilitySource = null;
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  private static UInt32? GetCryptographicProviderTypeExtensibility(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement.CryptographicProviderTypeExtensibility?.Value != null)
      return UInt32.Parse(openXmlElement.CryptographicProviderTypeExtensibility.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpCryptographicProviderTypeExtensibility(DXW.WriteProtection openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.CryptographicProviderTypeExtensibility?.Value != null)
      return UInt32.Parse(openXmlElement.CryptographicProviderTypeExtensibility.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetCryptographicProviderTypeExtensibility(DXW.WriteProtection openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.CryptographicProviderTypeExtensibility = ((UInt32)value).ToString("X8");
      else
        openXmlElement.CryptographicProviderTypeExtensibility = null;
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  private static String? GetCryptographicProviderTypeExtSource(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement?.CryptographicProviderTypeExtSource?.Value;
  }
  
  private static bool CmpCryptographicProviderTypeExtSource(DXW.WriteProtection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CryptographicProviderTypeExtSource?.Value == value;
  }
  
  private static void SetCryptographicProviderTypeExtSource(DXW.WriteProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CryptographicProviderTypeExtSource = new StringValue { Value = value };
    else
      openXmlElement.CryptographicProviderTypeExtSource = null;
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  private static Byte[]? GetHash(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value);
    return null;
  }
  
  private static bool CmpHash(DXW.WriteProtection openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetHash(DXW.WriteProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Hash = Convert.ToBase64String(value);
    else
      openXmlElement.Hash = null;
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  private static Byte[]? GetSalt(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value);
    return null;
  }
  
  private static bool CmpSalt(DXW.WriteProtection openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetSalt(DXW.WriteProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Salt = Convert.ToBase64String(value);
    else
      openXmlElement.Salt = null;
  }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetAlgorithmName(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement?.AlgorithmName?.Value;
  }
  
  private static bool CmpAlgorithmName(DXW.WriteProtection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AlgorithmName?.Value == value;
  }
  
  private static void SetAlgorithmName(DXW.WriteProtection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlgorithmName = new StringValue { Value = value };
    else
      openXmlElement.AlgorithmName = null;
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static Byte[]? GetHashValue(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value);
    return null;
  }
  
  private static bool CmpHashValue(DXW.WriteProtection openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetHashValue(DXW.WriteProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.HashValue = Convert.ToBase64String(value);
    else
      openXmlElement.HashValue = null;
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static Byte[]? GetSaltValue(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value);
    return null;
  }
  
  private static bool CmpSaltValue(DXW.WriteProtection openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetSaltValue(DXW.WriteProtection openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.SaltValue = Convert.ToBase64String(value);
    else
      openXmlElement.SaltValue = null;
  }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSpinCount(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement.SpinCount?.Value;
  }
  
  private static bool CmpSpinCount(DXW.WriteProtection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.SpinCount?.Value == value;
  }
  
  private static void SetSpinCount(DXW.WriteProtection openXmlElement, Int32? value)
  {
    openXmlElement.SpinCount = value;
  }
  
  public static DMW.WriteProtection? CreateModelElement(DXW.WriteProtection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.WriteProtection();
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
  
  public static bool CompareModelElement(DXW.WriteProtection? openXmlElement, DMW.WriteProtection? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRecommended(openXmlElement, value.Recommended, diffs, objName))
        ok = false;
      if (!CmpCryptographicProviderType(openXmlElement, value.CryptographicProviderType, diffs, objName))
        ok = false;
      if (!CmpCryptographicAlgorithmClass(openXmlElement, value.CryptographicAlgorithmClass, diffs, objName))
        ok = false;
      if (!CmpCryptographicAlgorithmType(openXmlElement, value.CryptographicAlgorithmType, diffs, objName))
        ok = false;
      if (!CmpCryptographicAlgorithmSid(openXmlElement, value.CryptographicAlgorithmSid, diffs, objName))
        ok = false;
      if (!CmpCryptographicSpinCount(openXmlElement, value.CryptographicSpinCount, diffs, objName))
        ok = false;
      if (!CmpCryptographicProvider(openXmlElement, value.CryptographicProvider, diffs, objName))
        ok = false;
      if (!CmpAlgorithmIdExtensibility(openXmlElement, value.AlgorithmIdExtensibility, diffs, objName))
        ok = false;
      if (!CmpAlgorithmIdExtensibilitySource(openXmlElement, value.AlgorithmIdExtensibilitySource, diffs, objName))
        ok = false;
      if (!CmpCryptographicProviderTypeExtensibility(openXmlElement, value.CryptographicProviderTypeExtensibility, diffs, objName))
        ok = false;
      if (!CmpCryptographicProviderTypeExtSource(openXmlElement, value.CryptographicProviderTypeExtSource, diffs, objName))
        ok = false;
      if (!CmpHash(openXmlElement, value.Hash, diffs, objName))
        ok = false;
      if (!CmpSalt(openXmlElement, value.Salt, diffs, objName))
        ok = false;
      if (!CmpAlgorithmName(openXmlElement, value.AlgorithmName, diffs, objName))
        ok = false;
      if (!CmpHashValue(openXmlElement, value.HashValue, diffs, objName))
        ok = false;
      if (!CmpSaltValue(openXmlElement, value.SaltValue, diffs, objName))
        ok = false;
      if (!CmpSpinCount(openXmlElement, value.SpinCount, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.WriteProtection? value)
    where OpenXmlElementType: DXW.WriteProtection, new()
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
