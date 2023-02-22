namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Digital Signature Line.
/// </summary>
public static class SignatureLineConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.SignatureLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.SignatureLine openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtension(DXVmlO.SignatureLine openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Signature Line Flag
  /// </summary>
  private static Boolean? GetIsSignatureLine(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.IsSignatureLine?.Value;
  }
  
  private static bool CmpIsSignatureLine(DXVmlO.SignatureLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IsSignatureLine?.Value == value) return true;
    diffs?.Add(objName, "IsSignatureLine", openXmlElement?.IsSignatureLine?.Value, value);
    return false;
  }
  
  private static void SetIsSignatureLine(DXVmlO.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsSignatureLine = value;
    else
      openXmlElement.IsSignatureLine = null;
  }
  
  /// <summary>
  /// Unique ID
  /// </summary>
  private static String? GetId(DXVmlO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Signature Provider ID
  /// </summary>
  private static String? GetProviderId(DXVmlO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ProviderId);
  }
  
  private static bool CmpProviderId(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ProviderId, value, diffs, objName, "ProviderId");
  }
  
  private static void SetProviderId(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.ProviderId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Use Signing Instructions Flag
  /// </summary>
  private static Boolean? GetSigningInstructionsSet(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructionsSet?.Value;
  }
  
  private static bool CmpSigningInstructionsSet(DXVmlO.SignatureLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SigningInstructionsSet?.Value == value) return true;
    diffs?.Add(objName, "SigningInstructionsSet", openXmlElement?.SigningInstructionsSet?.Value, value);
    return false;
  }
  
  private static void SetSigningInstructionsSet(DXVmlO.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SigningInstructionsSet = value;
    else
      openXmlElement.SigningInstructionsSet = null;
  }
  
  /// <summary>
  /// User-specified Comments Flag
  /// </summary>
  private static Boolean? GetAllowComments(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.AllowComments?.Value;
  }
  
  private static bool CmpAllowComments(DXVmlO.SignatureLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowComments?.Value == value) return true;
    diffs?.Add(objName, "AllowComments", openXmlElement?.AllowComments?.Value, value);
    return false;
  }
  
  private static void SetAllowComments(DXVmlO.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowComments = value;
    else
      openXmlElement.AllowComments = null;
  }
  
  /// <summary>
  /// Show Signed Date Flag
  /// </summary>
  private static Boolean? GetShowSignDate(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.ShowSignDate?.Value;
  }
  
  private static bool CmpShowSignDate(DXVmlO.SignatureLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowSignDate?.Value == value) return true;
    diffs?.Add(objName, "ShowSignDate", openXmlElement?.ShowSignDate?.Value, value);
    return false;
  }
  
  private static void SetShowSignDate(DXVmlO.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowSignDate = value;
    else
      openXmlElement.ShowSignDate = null;
  }
  
  /// <summary>
  /// Suggested Signer Line 1
  /// </summary>
  private static String? GetSuggestedSigner(DXVmlO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSigner);
  }
  
  private static bool CmpSuggestedSigner(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSigner, value, diffs, objName, "SuggestedSigner");
  }
  
  private static void SetSuggestedSigner(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSigner = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Suggested Signer Line 2
  /// </summary>
  private static String? GetSuggestedSigner2(DXVmlO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSigner2);
  }
  
  private static bool CmpSuggestedSigner2(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSigner2, value, diffs, objName, "SuggestedSigner2");
  }
  
  private static void SetSuggestedSigner2(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSigner2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Suggested Signer E-mail Address
  /// </summary>
  private static String? GetSuggestedSignerEmail(DXVmlO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSignerEmail);
  }
  
  private static bool CmpSuggestedSignerEmail(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSignerEmail, value, diffs, objName, "SuggestedSignerEmail");
  }
  
  private static void SetSuggestedSignerEmail(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSignerEmail = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Instructions for Signing
  /// </summary>
  private static String? GetSigningInstructions(DXVmlO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SigningInstructions);
  }
  
  private static bool CmpSigningInstructions(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SigningInstructions, value, diffs, objName, "SigningInstructions");
  }
  
  private static void SetSigningInstructions(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SigningInstructions = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Additional Signature Information
  /// </summary>
  private static String? GetAdditionalXml(DXVmlO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdditionalXml);
  }
  
  private static bool CmpAdditionalXml(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdditionalXml, value, diffs, objName, "AdditionalXml");
  }
  
  private static void SetAdditionalXml(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.AdditionalXml = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Signature Provider Download URL
  /// </summary>
  private static String? GetSignatureProviderUrl(DXVmlO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SignatureProviderUrl);
  }
  
  private static bool CmpSignatureProviderUrl(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SignatureProviderUrl, value, diffs, objName, "SignatureProviderUrl");
  }
  
  private static void SetSignatureProviderUrl(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SignatureProviderUrl = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.SignatureLine? CreateModelElement(DXVmlO.SignatureLine? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.SignatureLine();
      value.Extension = GetExtension(openXmlElement);
      value.IsSignatureLine = GetIsSignatureLine(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.ProviderId = GetProviderId(openXmlElement);
      value.SigningInstructionsSet = GetSigningInstructionsSet(openXmlElement);
      value.AllowComments = GetAllowComments(openXmlElement);
      value.ShowSignDate = GetShowSignDate(openXmlElement);
      value.SuggestedSigner = GetSuggestedSigner(openXmlElement);
      value.SuggestedSigner2 = GetSuggestedSigner2(openXmlElement);
      value.SuggestedSignerEmail = GetSuggestedSignerEmail(openXmlElement);
      value.SigningInstructions = GetSigningInstructions(openXmlElement);
      value.AdditionalXml = GetAdditionalXml(openXmlElement);
      value.SignatureProviderUrl = GetSignatureProviderUrl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.SignatureLine? openXmlElement, DMVml.SignatureLine? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpIsSignatureLine(openXmlElement, value.IsSignatureLine, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpProviderId(openXmlElement, value.ProviderId, diffs, objName))
        ok = false;
      if (!CmpSigningInstructionsSet(openXmlElement, value.SigningInstructionsSet, diffs, objName))
        ok = false;
      if (!CmpAllowComments(openXmlElement, value.AllowComments, diffs, objName))
        ok = false;
      if (!CmpShowSignDate(openXmlElement, value.ShowSignDate, diffs, objName))
        ok = false;
      if (!CmpSuggestedSigner(openXmlElement, value.SuggestedSigner, diffs, objName))
        ok = false;
      if (!CmpSuggestedSigner2(openXmlElement, value.SuggestedSigner2, diffs, objName))
        ok = false;
      if (!CmpSuggestedSignerEmail(openXmlElement, value.SuggestedSignerEmail, diffs, objName))
        ok = false;
      if (!CmpSigningInstructions(openXmlElement, value.SigningInstructions, diffs, objName))
        ok = false;
      if (!CmpAdditionalXml(openXmlElement, value.AdditionalXml, diffs, objName))
        ok = false;
      if (!CmpSignatureProviderUrl(openXmlElement, value.SignatureProviderUrl, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.SignatureLine value)
    where OpenXmlElementType: DXVmlO.SignatureLine, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.SignatureLine openXmlElement, DMVml.SignatureLine value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetIsSignatureLine(openXmlElement, value?.IsSignatureLine);
    SetId(openXmlElement, value?.Id);
    SetProviderId(openXmlElement, value?.ProviderId);
    SetSigningInstructionsSet(openXmlElement, value?.SigningInstructionsSet);
    SetAllowComments(openXmlElement, value?.AllowComments);
    SetShowSignDate(openXmlElement, value?.ShowSignDate);
    SetSuggestedSigner(openXmlElement, value?.SuggestedSigner);
    SetSuggestedSigner2(openXmlElement, value?.SuggestedSigner2);
    SetSuggestedSignerEmail(openXmlElement, value?.SuggestedSignerEmail);
    SetSigningInstructions(openXmlElement, value?.SigningInstructions);
    SetAdditionalXml(openXmlElement, value?.AdditionalXml);
    SetSignatureProviderUrl(openXmlElement, value?.SignatureProviderUrl);
    }
  }
