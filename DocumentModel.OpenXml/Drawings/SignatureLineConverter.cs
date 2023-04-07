namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the SignatureLine Class.
/// </summary>
public static class SignatureLineConverter
{
  /// <summary>
  /// isSignatureLine, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetIsSignatureLine(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.IsSignatureLine?.Value;
  }
  
  private static bool CmpIsSignatureLine(DXO2013Draw.SignatureLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IsSignatureLine?.Value == value) return true;
    diffs?.Add(objName, "IsSignatureLine", openXmlElement?.IsSignatureLine?.Value, value);
    return false;
  }
  
  private static void SetIsSignatureLine(DXO2013Draw.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsSignatureLine = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsSignatureLine = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013Draw.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// provId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetProviderId(DXO2013Draw.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ProviderId);
  }
  
  private static bool CmpProviderId(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ProviderId, value, diffs, objName, "ProviderId");
  }
  
  private static void SetProviderId(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.ProviderId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// signingInstructionsSet, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetSigningInstructionsSet(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructionsSet?.Value;
  }
  
  private static bool CmpSigningInstructionsSet(DXO2013Draw.SignatureLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SigningInstructionsSet?.Value == value) return true;
    diffs?.Add(objName, "SigningInstructionsSet", openXmlElement?.SigningInstructionsSet?.Value, value);
    return false;
  }
  
  private static void SetSigningInstructionsSet(DXO2013Draw.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SigningInstructionsSet = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SigningInstructionsSet = null;
  }
  
  /// <summary>
  /// allowComments, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetAllowComments(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.AllowComments?.Value;
  }
  
  private static bool CmpAllowComments(DXO2013Draw.SignatureLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowComments?.Value == value) return true;
    diffs?.Add(objName, "AllowComments", openXmlElement?.AllowComments?.Value, value);
    return false;
  }
  
  private static void SetAllowComments(DXO2013Draw.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowComments = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AllowComments = null;
  }
  
  /// <summary>
  /// showSignDate, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetShowSignDate(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.ShowSignDate?.Value;
  }
  
  private static bool CmpShowSignDate(DXO2013Draw.SignatureLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowSignDate?.Value == value) return true;
    diffs?.Add(objName, "ShowSignDate", openXmlElement?.ShowSignDate?.Value, value);
    return false;
  }
  
  private static void SetShowSignDate(DXO2013Draw.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowSignDate = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowSignDate = null;
  }
  
  /// <summary>
  /// suggestedSigner, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSuggestedSigner(DXO2013Draw.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSigner);
  }
  
  private static bool CmpSuggestedSigner(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSigner, value, diffs, objName, "SuggestedSigner");
  }
  
  private static void SetSuggestedSigner(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSigner = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// suggestedSigner2, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSuggestedSigner2(DXO2013Draw.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSigner2);
  }
  
  private static bool CmpSuggestedSigner2(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSigner2, value, diffs, objName, "SuggestedSigner2");
  }
  
  private static void SetSuggestedSigner2(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSigner2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// suggestedSignerEmail, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSuggestedSignerEmail(DXO2013Draw.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SuggestedSignerEmail);
  }
  
  private static bool CmpSuggestedSignerEmail(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SuggestedSignerEmail, value, diffs, objName, "SuggestedSignerEmail");
  }
  
  private static void SetSuggestedSignerEmail(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SuggestedSignerEmail = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// signingInstructions, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSigningInstructions(DXO2013Draw.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SigningInstructions);
  }
  
  private static bool CmpSigningInstructions(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SigningInstructions, value, diffs, objName, "SigningInstructions");
  }
  
  private static void SetSigningInstructions(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SigningInstructions = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// addlXml, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAdditionalXml(DXO2013Draw.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdditionalXml);
  }
  
  private static bool CmpAdditionalXml(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdditionalXml, value, diffs, objName, "AdditionalXml");
  }
  
  private static void SetAdditionalXml(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.AdditionalXml = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// sigProvUrl, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSignatureProviderUrl(DXO2013Draw.SignatureLine openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SignatureProviderUrl);
  }
  
  private static bool CmpSignatureProviderUrl(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SignatureProviderUrl, value, diffs, objName, "SignatureProviderUrl");
  }
  
  private static void SetSignatureProviderUrl(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    openXmlElement.SignatureProviderUrl = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.SignatureLine? CreateModelElement(DXO2013Draw.SignatureLine? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SignatureLine();
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
  
  public static bool CompareModelElement(DXO2013Draw.SignatureLine? openXmlElement, DMDraws.SignatureLine? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SignatureLine value)
    where OpenXmlElementType: DXO2013Draw.SignatureLine, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013Draw.SignatureLine openXmlElement, DMDraws.SignatureLine value)
  {
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
