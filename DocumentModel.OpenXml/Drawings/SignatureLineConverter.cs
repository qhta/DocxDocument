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
    return openXmlElement?.IsSignatureLine?.Value == value;
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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// provId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetProviderId(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.ProviderId?.Value;
  }
  
  private static bool CmpProviderId(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ProviderId?.Value == value;
  }
  
  private static void SetProviderId(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProviderId = new StringValue { Value = value };
    else
      openXmlElement.ProviderId = null;
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
    return openXmlElement?.SigningInstructionsSet?.Value == value;
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
    return openXmlElement?.AllowComments?.Value == value;
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
    return openXmlElement?.ShowSignDate?.Value == value;
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
    return openXmlElement?.SuggestedSigner?.Value;
  }
  
  private static bool CmpSuggestedSigner(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SuggestedSigner?.Value == value;
  }
  
  private static void SetSuggestedSigner(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSigner = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSigner = null;
  }
  
  /// <summary>
  /// suggestedSigner2, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSuggestedSigner2(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSigner2?.Value;
  }
  
  private static bool CmpSuggestedSigner2(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SuggestedSigner2?.Value == value;
  }
  
  private static void SetSuggestedSigner2(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSigner2 = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSigner2 = null;
  }
  
  /// <summary>
  /// suggestedSignerEmail, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSuggestedSignerEmail(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSignerEmail?.Value;
  }
  
  private static bool CmpSuggestedSignerEmail(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SuggestedSignerEmail?.Value == value;
  }
  
  private static void SetSuggestedSignerEmail(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSignerEmail = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSignerEmail = null;
  }
  
  /// <summary>
  /// signingInstructions, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSigningInstructions(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructions?.Value;
  }
  
  private static bool CmpSigningInstructions(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SigningInstructions?.Value == value;
  }
  
  private static void SetSigningInstructions(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SigningInstructions = new StringValue { Value = value };
    else
      openXmlElement.SigningInstructions = null;
  }
  
  /// <summary>
  /// addlXml, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAdditionalXml(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.AdditionalXml?.Value;
  }
  
  private static bool CmpAdditionalXml(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AdditionalXml?.Value == value;
  }
  
  private static void SetAdditionalXml(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AdditionalXml = new StringValue { Value = value };
    else
      openXmlElement.AdditionalXml = null;
  }
  
  /// <summary>
  /// sigProvUrl, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSignatureProviderUrl(DXO2013Draw.SignatureLine openXmlElement)
  {
    return openXmlElement?.SignatureProviderUrl?.Value;
  }
  
  private static bool CmpSignatureProviderUrl(DXO2013Draw.SignatureLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SignatureProviderUrl?.Value == value;
  }
  
  private static void SetSignatureProviderUrl(DXO2013Draw.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SignatureProviderUrl = new StringValue { Value = value };
    else
      openXmlElement.SignatureProviderUrl = null;
  }
  
  public static DMDraws.SignatureLine? CreateModelElement(DXO2013Draw.SignatureLine? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.SignatureLine();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SignatureLine? value)
    where OpenXmlElementType: DXO2013Draw.SignatureLine, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
