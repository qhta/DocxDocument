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
  
  private static bool CmpEdit(DXW.DocumentProtection openXmlElement, DMW.DocumentProtectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues, DMW.DocumentProtectionKind>(openXmlElement?.Edit?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return BooleanValueConverter.GetValue(openXmlElement?.Formatting);
  }
  
  private static bool CmpFormatting(DXW.DocumentProtection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Formatting, value, diffs, objName, "Formatting");
  }
  
  private static void SetFormatting(DXW.DocumentProtection openXmlElement, Boolean? value)
  {
    openXmlElement.Formatting = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Enforce Document Protection Settings
  /// </summary>
  private static Boolean? GetEnforcement(DXW.DocumentProtection openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Enforcement);
  }
  
  private static bool CmpEnforcement(DXW.DocumentProtection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Enforcement, value, diffs, objName, "Enforcement");
  }
  
  private static void SetEnforcement(DXW.DocumentProtection openXmlElement, Boolean? value)
  {
    openXmlElement.Enforcement = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  private static DMW.CryptProviderKind? GetCryptographicProviderType(DXW.DocumentProtection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DMW.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value);
  }
  
  private static bool CmpCryptographicProviderType(DXW.DocumentProtection openXmlElement, DMW.CryptProviderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues, DMW.CryptProviderKind>(openXmlElement?.CryptographicProviderType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpCryptographicAlgorithmClass(DXW.DocumentProtection openXmlElement, DMW.CryptAlgorithmClassKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues, DMW.CryptAlgorithmClassKind>(openXmlElement?.CryptographicAlgorithmClass?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpCryptographicAlgorithmType(DXW.DocumentProtection openXmlElement, DMW.CryptAlgorithmKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues, DMW.CryptAlgorithmKind>(openXmlElement?.CryptographicAlgorithmType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.CryptographicAlgorithmSid?.Value;
  }
  
  private static bool CmpCryptographicAlgorithmSid(DXW.DocumentProtection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CryptographicAlgorithmSid?.Value == value) return true;
    diffs?.Add(objName, "CryptographicAlgorithmSid", openXmlElement?.CryptographicAlgorithmSid?.Value, value);
    return false;
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
    return openXmlElement?.CryptographicSpinCount?.Value;
  }
  
  private static bool CmpCryptographicSpinCount(DXW.DocumentProtection openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CryptographicSpinCount?.Value == value) return true;
    diffs?.Add(objName, "CryptographicSpinCount", openXmlElement?.CryptographicSpinCount?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.CryptographicProvider);
  }
  
  private static bool CmpCryptographicProvider(DXW.DocumentProtection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CryptographicProvider, value, diffs, objName, "CryptographicProvider");
  }
  
  private static void SetCryptographicProvider(DXW.DocumentProtection openXmlElement, String? value)
  {
    openXmlElement.CryptographicProvider = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  private static DM.HexInt? GetAlgorithmIdExtensibility(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement?.AlgorithmIdExtensibility?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.AlgorithmIdExtensibility.Value);
    return null;
  }
  
  private static bool CmpAlgorithmIdExtensibility(DXW.DocumentProtection openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AlgorithmIdExtensibility?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.AlgorithmIdExtensibility.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.AlgorithmIdExtensibility?.Value == null && value == null) return true;
    diffs?.Add(objName, "AlgorithmIdExtensibility", openXmlElement?.AlgorithmIdExtensibility?.Value, value);
    return false;
  }
  
  private static void SetAlgorithmIdExtensibility(DXW.DocumentProtection openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.AlgorithmIdExtensibility = value.ToString();
    else
      openXmlElement.AlgorithmIdExtensibility = null;
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  private static String? GetAlgorithmIdExtensibilitySource(DXW.DocumentProtection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlgorithmIdExtensibilitySource);
  }
  
  private static bool CmpAlgorithmIdExtensibilitySource(DXW.DocumentProtection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlgorithmIdExtensibilitySource, value, diffs, objName, "AlgorithmIdExtensibilitySource");
  }
  
  private static void SetAlgorithmIdExtensibilitySource(DXW.DocumentProtection openXmlElement, String? value)
  {
    openXmlElement.AlgorithmIdExtensibilitySource = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  private static DM.HexInt? GetCryptographicProviderTypeExtensibility(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement?.CryptographicProviderTypeExtensibility?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.CryptographicProviderTypeExtensibility.Value);
    return null;
  }
  
  private static bool CmpCryptographicProviderTypeExtensibility(DXW.DocumentProtection openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CryptographicProviderTypeExtensibility?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.CryptographicProviderTypeExtensibility.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.CryptographicProviderTypeExtensibility?.Value == null && value == null) return true;
    diffs?.Add(objName, "CryptographicProviderTypeExtensibility", openXmlElement?.CryptographicProviderTypeExtensibility?.Value, value);
    return false;
  }
  
  private static void SetCryptographicProviderTypeExtensibility(DXW.DocumentProtection openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.CryptographicProviderTypeExtensibility = value.ToString();
    else
      openXmlElement.CryptographicProviderTypeExtensibility = null;
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  private static String? GetCryptographicProviderTypeExtSource(DXW.DocumentProtection openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CryptographicProviderTypeExtSource);
  }
  
  private static bool CmpCryptographicProviderTypeExtSource(DXW.DocumentProtection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CryptographicProviderTypeExtSource, value, diffs, objName, "CryptographicProviderTypeExtSource");
  }
  
  private static void SetCryptographicProviderTypeExtSource(DXW.DocumentProtection openXmlElement, String? value)
  {
    openXmlElement.CryptographicProviderTypeExtSource = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  private static DM.Base64Binary? GetHash(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement?.Hash?.Value != null)
      return Convert.FromBase64String(openXmlElement.Hash.Value);
    return null;
  }
  
  private static bool CmpHash(DXW.DocumentProtection openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Hash?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.Hash.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.Hash?.Value == null && value == null) return true;
    diffs?.Add(objName, "Hash", openXmlElement?.Hash?.Value, value);
    return false;
  }
  
  private static void SetHash(DXW.DocumentProtection openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.Hash = Convert.ToBase64String(value);
    else
      openXmlElement.Hash = null;
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  private static DM.Base64Binary? GetSalt(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement?.Salt?.Value != null)
      return Convert.FromBase64String(openXmlElement.Salt.Value);
    return null;
  }
  
  private static bool CmpSalt(DXW.DocumentProtection openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Salt?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.Salt.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.Salt?.Value == null && value == null) return true;
    diffs?.Add(objName, "Salt", openXmlElement?.Salt?.Value, value);
    return false;
  }
  
  private static void SetSalt(DXW.DocumentProtection openXmlElement, DM.Base64Binary? value)
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
    return StringValueConverter.GetValue(openXmlElement?.AlgorithmName);
  }
  
  private static bool CmpAlgorithmName(DXW.DocumentProtection openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlgorithmName, value, diffs, objName, "AlgorithmName");
  }
  
  private static void SetAlgorithmName(DXW.DocumentProtection openXmlElement, String? value)
  {
    openXmlElement.AlgorithmName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.Base64Binary? GetHashValue(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement?.HashValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.HashValue.Value);
    return null;
  }
  
  private static bool CmpHashValue(DXW.DocumentProtection openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HashValue?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.HashValue.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.HashValue?.Value == null && value == null) return true;
    diffs?.Add(objName, "HashValue", openXmlElement?.HashValue?.Value, value);
    return false;
  }
  
  private static void SetHashValue(DXW.DocumentProtection openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.HashValue = Convert.ToBase64String(value);
    else
      openXmlElement.HashValue = null;
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.Base64Binary? GetSaltValue(DXW.DocumentProtection openXmlElement)
  {
    if (openXmlElement?.SaltValue?.Value != null)
      return Convert.FromBase64String(openXmlElement.SaltValue.Value);
    return null;
  }
  
  private static bool CmpSaltValue(DXW.DocumentProtection openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SaltValue?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.SaltValue.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.SaltValue?.Value == null && value == null) return true;
    diffs?.Add(objName, "SaltValue", openXmlElement?.SaltValue?.Value, value);
    return false;
  }
  
  private static void SetSaltValue(DXW.DocumentProtection openXmlElement, DM.Base64Binary? value)
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
    return openXmlElement?.SpinCount?.Value;
  }
  
  private static bool CmpSpinCount(DXW.DocumentProtection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SpinCount?.Value == value) return true;
    diffs?.Add(objName, "SpinCount", openXmlElement?.SpinCount?.Value, value);
    return false;
  }
  
  private static void SetSpinCount(DXW.DocumentProtection openXmlElement, Int32? value)
  {
    openXmlElement.SpinCount = value;
  }
  
  public static DocumentModel.Wordprocessing.DocumentProtection? CreateModelElement(DXW.DocumentProtection? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.DocumentProtection? openXmlElement, DMW.DocumentProtection? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEdit(openXmlElement, value.Edit, diffs, objName))
        ok = false;
      if (!CmpFormatting(openXmlElement, value.Formatting, diffs, objName))
        ok = false;
      if (!CmpEnforcement(openXmlElement, value.Enforcement, diffs, objName))
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocumentProtection value)
    where OpenXmlElementType: DXW.DocumentProtection, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocumentProtection openXmlElement, DMW.DocumentProtection value)
  {
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
    }
  }
