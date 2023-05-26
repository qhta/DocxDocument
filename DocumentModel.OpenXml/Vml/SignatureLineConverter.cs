namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Digital Signature Line.
/// </summary>
public static class SignatureLineConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.SignatureLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.SignatureLine openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName, propName);
  }
  
  private static void SetExtension(DXVO.SignatureLine openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Signature Line Flag
  /// </summary>
  private static Boolean? GetIsSignatureLine(DXVO.SignatureLine openXmlElement)
  {
    return openXmlElement?.IsSignatureLine?.Value;
  }
  
  private static bool CmpIsSignatureLine(DXVO.SignatureLine openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.IsSignatureLine?.Value == value) return true;
    diffs?.Add(objName, "IsSignatureLine", openXmlElement?.IsSignatureLine?.Value, value);
    return false;
  }
  
  private static void SetIsSignatureLine(DXVO.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsSignatureLine = value;
    else
      openXmlElement.IsSignatureLine = null;
  }
  
  /// <summary>
  /// Unique ID
  /// </summary>
  private static String? GetId(DXVO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVO.SignatureLine openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXVO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Signature Provider ID
  /// </summary>
  private static String? GetProviderId(DXVO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ProviderId);
  }
  
  private static bool CmpProviderId(DXVO.SignatureLine openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ProviderId, value, diffs, objName, "ProviderId");
  }
  
  private static void SetProviderId(DXVO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.ProviderId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Use Signing Instructions Flag
  /// </summary>
  private static Boolean? GetSigningInstructionsSet(DXVO.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructionsSet?.Value;
  }
  
  private static bool CmpSigningInstructionsSet(DXVO.SignatureLine openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SigningInstructionsSet?.Value == value) return true;
    diffs?.Add(objName, "SigningInstructionsSet", openXmlElement?.SigningInstructionsSet?.Value, value);
    return false;
  }
  
  private static void SetSigningInstructionsSet(DXVO.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SigningInstructionsSet = value;
    else
      openXmlElement.SigningInstructionsSet = null;
  }
  
  /// <summary>
  /// User-specified Comments Flag
  /// </summary>
  private static Boolean? GetAllowComments(DXVO.SignatureLine openXmlElement)
  {
    return openXmlElement?.AllowComments?.Value;
  }
  
  private static bool CmpAllowComments(DXVO.SignatureLine openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AllowComments?.Value == value) return true;
    diffs?.Add(objName, "AllowComments", openXmlElement?.AllowComments?.Value, value);
    return false;
  }
  
  private static void SetAllowComments(DXVO.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowComments = value;
    else
      openXmlElement.AllowComments = null;
  }
  
  /// <summary>
  /// Show Signed Date Flag
  /// </summary>
  private static Boolean? GetShowSignDate(DXVO.SignatureLine openXmlElement)
  {
    return openXmlElement?.ShowSignDate?.Value;
  }
  
  private static bool CmpShowSignDate(DXVO.SignatureLine openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ShowSignDate?.Value == value) return true;
    diffs?.Add(objName, "ShowSignDate", openXmlElement?.ShowSignDate?.Value, value);
    return false;
  }
  
  private static void SetShowSignDate(DXVO.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowSignDate = value;
    else
      openXmlElement.ShowSignDate = null;
  }
  
  /// <summary>
  /// Suggested Signer Line 1
  /// </summary>
  private static String? GetSuggestedSigner(DXVO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSigner);
  }
  
  private static bool CmpSuggestedSigner(DXVO.SignatureLine openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSigner, value, diffs, objName, "SuggestedSigner");
  }
  
  private static void SetSuggestedSigner(DXVO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSigner = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Suggested Signer Line 2
  /// </summary>
  private static String? GetSuggestedSigner2(DXVO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSigner2);
  }
  
  private static bool CmpSuggestedSigner2(DXVO.SignatureLine openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSigner2, value, diffs, objName, "SuggestedSigner2");
  }
  
  private static void SetSuggestedSigner2(DXVO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSigner2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Suggested Signer E-mail Address
  /// </summary>
  private static String? GetSuggestedSignerEmail(DXVO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSignerEmail);
  }
  
  private static bool CmpSuggestedSignerEmail(DXVO.SignatureLine openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSignerEmail, value, diffs, objName, "SuggestedSignerEmail");
  }
  
  private static void SetSuggestedSignerEmail(DXVO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSignerEmail = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Instructions for Signing
  /// </summary>
  private static String? GetSigningInstructions(DXVO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SigningInstructions);
  }
  
  private static bool CmpSigningInstructions(DXVO.SignatureLine openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SigningInstructions, value, diffs, objName, "SigningInstructions");
  }
  
  private static void SetSigningInstructions(DXVO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SigningInstructions = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Additional Signature Information
  /// </summary>
  private static String? GetAdditionalXml(DXVO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdditionalXml);
  }
  
  private static bool CmpAdditionalXml(DXVO.SignatureLine openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdditionalXml, value, diffs, objName, "AdditionalXml");
  }
  
  private static void SetAdditionalXml(DXVO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.AdditionalXml = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Signature Provider Download URL
  /// </summary>
  private static String? GetSignatureProviderUrl(DXVO.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SignatureProviderUrl);
  }
  
  private static bool CmpSignatureProviderUrl(DXVO.SignatureLine openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SignatureProviderUrl, value, diffs, objName, "SignatureProviderUrl");
  }
  
  private static void SetSignatureProviderUrl(DXVO.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SignatureProviderUrl = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.SignatureLine? CreateModelElement(DXVO.SignatureLine? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.SignatureLine? openXmlElement, DMV.SignatureLine? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName, propName))
        ok = false;
      if (!CmpIsSignatureLine(openXmlElement, value.IsSignatureLine, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpProviderId(openXmlElement, value.ProviderId, diffs, objName, propName))
        ok = false;
      if (!CmpSigningInstructionsSet(openXmlElement, value.SigningInstructionsSet, diffs, objName, propName))
        ok = false;
      if (!CmpAllowComments(openXmlElement, value.AllowComments, diffs, objName, propName))
        ok = false;
      if (!CmpShowSignDate(openXmlElement, value.ShowSignDate, diffs, objName, propName))
        ok = false;
      if (!CmpSuggestedSigner(openXmlElement, value.SuggestedSigner, diffs, objName, propName))
        ok = false;
      if (!CmpSuggestedSigner2(openXmlElement, value.SuggestedSigner2, diffs, objName, propName))
        ok = false;
      if (!CmpSuggestedSignerEmail(openXmlElement, value.SuggestedSignerEmail, diffs, objName, propName))
        ok = false;
      if (!CmpSigningInstructions(openXmlElement, value.SigningInstructions, diffs, objName, propName))
        ok = false;
      if (!CmpAdditionalXml(openXmlElement, value.AdditionalXml, diffs, objName, propName))
        ok = false;
      if (!CmpSignatureProviderUrl(openXmlElement, value.SignatureProviderUrl, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.SignatureLine value)
    where OpenXmlElementType: DXVO.SignatureLine, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.SignatureLine openXmlElement, DMV.SignatureLine value)
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
