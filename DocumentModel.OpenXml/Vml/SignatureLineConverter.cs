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
    return openXmlElement?.IsSignatureLine?.Value == value;
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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Signature Provider ID
  /// </summary>
  private static String? GetProviderId(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.ProviderId?.Value;
  }
  
  private static bool CmpProviderId(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ProviderId?.Value == value;
  }
  
  private static void SetProviderId(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProviderId = new StringValue { Value = value };
    else
      openXmlElement.ProviderId = null;
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
    return openXmlElement?.SigningInstructionsSet?.Value == value;
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
    return openXmlElement?.AllowComments?.Value == value;
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
    return openXmlElement?.ShowSignDate?.Value == value;
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
    return openXmlElement?.SuggestedSigner?.Value;
  }
  
  private static bool CmpSuggestedSigner(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SuggestedSigner?.Value == value;
  }
  
  private static void SetSuggestedSigner(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSigner = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSigner = null;
  }
  
  /// <summary>
  /// Suggested Signer Line 2
  /// </summary>
  private static String? GetSuggestedSigner2(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSigner2?.Value;
  }
  
  private static bool CmpSuggestedSigner2(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SuggestedSigner2?.Value == value;
  }
  
  private static void SetSuggestedSigner2(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSigner2 = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSigner2 = null;
  }
  
  /// <summary>
  /// Suggested Signer E-mail Address
  /// </summary>
  private static String? GetSuggestedSignerEmail(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSignerEmail?.Value;
  }
  
  private static bool CmpSuggestedSignerEmail(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SuggestedSignerEmail?.Value == value;
  }
  
  private static void SetSuggestedSignerEmail(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSignerEmail = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSignerEmail = null;
  }
  
  /// <summary>
  /// Instructions for Signing
  /// </summary>
  private static String? GetSigningInstructions(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructions?.Value;
  }
  
  private static bool CmpSigningInstructions(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SigningInstructions?.Value == value;
  }
  
  private static void SetSigningInstructions(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SigningInstructions = new StringValue { Value = value };
    else
      openXmlElement.SigningInstructions = null;
  }
  
  /// <summary>
  /// Additional Signature Information
  /// </summary>
  private static String? GetAdditionalXml(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.AdditionalXml?.Value;
  }
  
  private static bool CmpAdditionalXml(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AdditionalXml?.Value == value;
  }
  
  private static void SetAdditionalXml(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AdditionalXml = new StringValue { Value = value };
    else
      openXmlElement.AdditionalXml = null;
  }
  
  /// <summary>
  /// Signature Provider Download URL
  /// </summary>
  private static String? GetSignatureProviderUrl(DXVmlO.SignatureLine openXmlElement)
  {
    return openXmlElement?.SignatureProviderUrl?.Value;
  }
  
  private static bool CmpSignatureProviderUrl(DXVmlO.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SignatureProviderUrl?.Value == value;
  }
  
  private static void SetSignatureProviderUrl(DXVmlO.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SignatureProviderUrl = new StringValue { Value = value };
    else
      openXmlElement.SignatureProviderUrl = null;
  }
  
  public static DMVml.SignatureLine? CreateModelElement(DXVmlO.SignatureLine? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.SignatureLine();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.SignatureLine? value)
    where OpenXmlElementType: DXVmlO.SignatureLine, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
