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
    return BooleanValueConverter.GetValue(openXmlElement?.Recommended);
  }
  
  private static bool CmpRecommended(DXW.WriteProtection openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Recommended, value, diffs, objName, "Recommended");
  }
  
  private static void SetRecommended(DXW.WriteProtection openXmlElement, Boolean? value)
  {
    openXmlElement.Recommended = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  private static DMW.CryptProviderKind? GetCryptographicProviderType(DXW.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.CryptProviderValues, DMW.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value);
  }
  
  private static bool CmpCryptographicProviderType(DXW.WriteProtection openXmlElement, DMW.CryptProviderKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.CryptProviderValues, DMW.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCryptographicProviderType(DXW.WriteProtection openXmlElement, DMW.CryptProviderKind? value)
  {
    openXmlElement.CryptographicProviderType = EnumValueConverter.CreateEnumValue<DXW.CryptProviderValues, DMW.CryptProviderKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  private static DMW.CryptAlgorithmClassKind? GetCryptographicAlgorithmClass(DXW.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value);
  }
  
  private static bool CmpCryptographicAlgorithmClass(DXW.WriteProtection openXmlElement, DMW.CryptAlgorithmClassKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCryptographicAlgorithmClass(DXW.WriteProtection openXmlElement, DMW.CryptAlgorithmClassKind? value)
  {
    openXmlElement.CryptographicAlgorithmClass = EnumValueConverter.CreateEnumValue<DXW.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  private static DMW.CryptAlgorithmKind? GetCryptographicAlgorithmType(DXW.WriteProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value);
  }
  
  private static bool CmpCryptographicAlgorithmType(DXW.WriteProtection openXmlElement, DMW.CryptAlgorithmKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCryptographicAlgorithmType(DXW.WriteProtection openXmlElement, DMW.CryptAlgorithmKind? value)
  {
    openXmlElement.CryptographicAlgorithmType = EnumValueConverter.CreateEnumValue<DXW.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(value);
  }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  private static Int32? GetCryptographicAlgorithmSid(DXW.WriteProtection openXmlElement)
  {
    return openXmlElement?.CryptographicAlgorithmSid?.Value;
  }
  
  private static bool CmpCryptographicAlgorithmSid(DXW.WriteProtection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.CryptographicAlgorithmSid?.Value == value) return true;
    diffs?.Add(objName, "CryptographicAlgorithmSid", openXmlElement?.CryptographicAlgorithmSid?.Value, value);
    return false;
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
    return openXmlElement?.CryptographicSpinCount?.Value;
  }
  
  private static bool CmpCryptographicSpinCount(DXW.WriteProtection openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.CryptographicSpinCount?.Value == value) return true;
    diffs?.Add(objName, "CryptographicSpinCount", openXmlElement?.CryptographicSpinCount?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.CryptographicProvider);
  }
  
  private static bool CmpCryptographicProvider(DXW.WriteProtection openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CryptographicProvider, value, diffs, objName, "CryptographicProvider");
  }
  
  private static void SetCryptographicProvider(DXW.WriteProtection openXmlElement, String? value)
  {
    openXmlElement.CryptographicProvider = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  private static DM.HexInt? GetAlgorithmIdExtensibility(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement?.AlgorithmIdExtensibility?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.AlgorithmIdExtensibility.Value);
    return null;
  }
  
  private static bool CmpAlgorithmIdExtensibility(DXW.WriteProtection openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.AlgorithmIdExtensibility?.Value, value, diffs, objName, "AlgorithmIdExtensibility");
  }
  
  private static void SetAlgorithmIdExtensibility(DXW.WriteProtection openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.AlgorithmIdExtensibility = value.ToString();
    else
      openXmlElement.AlgorithmIdExtensibility = null;
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  private static String? GetAlgorithmIdExtensibilitySource(DXW.WriteProtection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlgorithmIdExtensibilitySource);
  }
  
  private static bool CmpAlgorithmIdExtensibilitySource(DXW.WriteProtection openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlgorithmIdExtensibilitySource, value, diffs, objName, "AlgorithmIdExtensibilitySource");
  }
  
  private static void SetAlgorithmIdExtensibilitySource(DXW.WriteProtection openXmlElement, String? value)
  {
    openXmlElement.AlgorithmIdExtensibilitySource = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  private static DM.HexInt? GetCryptographicProviderTypeExtensibility(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement?.CryptographicProviderTypeExtensibility?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.CryptographicProviderTypeExtensibility.Value);
    return null;
  }
  
  private static bool CmpCryptographicProviderTypeExtensibility(DXW.WriteProtection openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.CryptographicProviderTypeExtensibility?.Value, value, diffs, objName, "CryptographicProviderTypeExtensibility");
  }
  
  private static void SetCryptographicProviderTypeExtensibility(DXW.WriteProtection openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.CryptographicProviderTypeExtensibility = value.ToString();
    else
      openXmlElement.CryptographicProviderTypeExtensibility = null;
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  private static String? GetCryptographicProviderTypeExtSource(DXW.WriteProtection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CryptographicProviderTypeExtSource);
  }
  
  private static bool CmpCryptographicProviderTypeExtSource(DXW.WriteProtection openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CryptographicProviderTypeExtSource, value, diffs, objName, "CryptographicProviderTypeExtSource");
  }
  
  private static void SetCryptographicProviderTypeExtSource(DXW.WriteProtection openXmlElement, String? value)
  {
    openXmlElement.CryptographicProviderTypeExtSource = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  private static DM.Base64Binary? GetHash(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement?.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value);
    return null;
  }
  
  private static bool CmpHash(DXW.WriteProtection openXmlElement, DM.Base64Binary? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Hash?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.Hash.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.Hash?.Value == null && value == null) return true;
    diffs?.Add(objName, "Hash", openXmlElement?.Hash?.Value, value);
    return false;
  }
  
  private static void SetHash(DXW.WriteProtection openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.Hash = Convert.ToBase64String(value);
    else
      openXmlElement.Hash = null;
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  private static DM.Base64Binary? GetSalt(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement?.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value);
    return null;
  }
  
  private static bool CmpSalt(DXW.WriteProtection openXmlElement, DM.Base64Binary? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Salt?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.Salt.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.Salt?.Value == null && value == null) return true;
    diffs?.Add(objName, "Salt", openXmlElement?.Salt?.Value, value);
    return false;
  }
  
  private static void SetSalt(DXW.WriteProtection openXmlElement, DM.Base64Binary? value)
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
    return StringValueConverter.GetValue(openXmlElement?.AlgorithmName);
  }
  
  private static bool CmpAlgorithmName(DXW.WriteProtection openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlgorithmName, value, diffs, objName, "AlgorithmName");
  }
  
  private static void SetAlgorithmName(DXW.WriteProtection openXmlElement, String? value)
  {
    openXmlElement.AlgorithmName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.Base64Binary? GetHashValue(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement?.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value);
    return null;
  }
  
  private static bool CmpHashValue(DXW.WriteProtection openXmlElement, DM.Base64Binary? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HashValue?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.HashValue.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.HashValue?.Value == null && value == null) return true;
    diffs?.Add(objName, "HashValue", openXmlElement?.HashValue?.Value, value);
    return false;
  }
  
  private static void SetHashValue(DXW.WriteProtection openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.HashValue = Convert.ToBase64String(value);
    else
      openXmlElement.HashValue = null;
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.Base64Binary? GetSaltValue(DXW.WriteProtection openXmlElement)
  {
    if (openXmlElement?.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value);
    return null;
  }
  
  private static bool CmpSaltValue(DXW.WriteProtection openXmlElement, DM.Base64Binary? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SaltValue?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.SaltValue.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.SaltValue?.Value == null && value == null) return true;
    diffs?.Add(objName, "SaltValue", openXmlElement?.SaltValue?.Value, value);
    return false;
  }
  
  private static void SetSaltValue(DXW.WriteProtection openXmlElement, DM.Base64Binary? value)
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
    return openXmlElement?.SpinCount?.Value;
  }
  
  private static bool CmpSpinCount(DXW.WriteProtection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SpinCount?.Value == value) return true;
    diffs?.Add(objName, "SpinCount", openXmlElement?.SpinCount?.Value, value);
    return false;
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
  
  public static bool CompareModelElement(DXW.WriteProtection? openXmlElement, DMW.WriteProtection? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRecommended(openXmlElement, value.Recommended, diffs, objName, propName))
        ok = false;
      if (!CmpCryptographicProviderType(openXmlElement, value.CryptographicProviderType, diffs, objName, propName))
        ok = false;
      if (!CmpCryptographicAlgorithmClass(openXmlElement, value.CryptographicAlgorithmClass, diffs, objName, propName))
        ok = false;
      if (!CmpCryptographicAlgorithmType(openXmlElement, value.CryptographicAlgorithmType, diffs, objName, propName))
        ok = false;
      if (!CmpCryptographicAlgorithmSid(openXmlElement, value.CryptographicAlgorithmSid, diffs, objName, propName))
        ok = false;
      if (!CmpCryptographicSpinCount(openXmlElement, value.CryptographicSpinCount, diffs, objName, propName))
        ok = false;
      if (!CmpCryptographicProvider(openXmlElement, value.CryptographicProvider, diffs, objName, propName))
        ok = false;
      if (!CmpAlgorithmIdExtensibility(openXmlElement, value.AlgorithmIdExtensibility, diffs, objName, propName))
        ok = false;
      if (!CmpAlgorithmIdExtensibilitySource(openXmlElement, value.AlgorithmIdExtensibilitySource, diffs, objName, propName))
        ok = false;
      if (!CmpCryptographicProviderTypeExtensibility(openXmlElement, value.CryptographicProviderTypeExtensibility, diffs, objName, propName))
        ok = false;
      if (!CmpCryptographicProviderTypeExtSource(openXmlElement, value.CryptographicProviderTypeExtSource, diffs, objName, propName))
        ok = false;
      if (!CmpHash(openXmlElement, value.Hash, diffs, objName, propName))
        ok = false;
      if (!CmpSalt(openXmlElement, value.Salt, diffs, objName, propName))
        ok = false;
      if (!CmpAlgorithmName(openXmlElement, value.AlgorithmName, diffs, objName, propName))
        ok = false;
      if (!CmpHashValue(openXmlElement, value.HashValue, diffs, objName, propName))
        ok = false;
      if (!CmpSaltValue(openXmlElement, value.SaltValue, diffs, objName, propName))
        ok = false;
      if (!CmpSpinCount(openXmlElement, value.SpinCount, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.WriteProtection value)
    where OpenXmlElementType: DXW.WriteProtection, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.WriteProtection openXmlElement, DMW.WriteProtection value)
  {
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
  }
}
