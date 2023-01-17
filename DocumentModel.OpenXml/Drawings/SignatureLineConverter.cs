namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the SignatureLine Class.
/// </summary>
public static class SignatureLineConverter
{
  /// <summary>
  /// isSignatureLine, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetIsSignatureLine(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.IsSignatureLine?.Value;
  }
  
  private static void SetIsSignatureLine(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsSignatureLine = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsSignatureLine = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// provId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetProviderId(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.ProviderId?.Value;
  }
  
  private static void SetProviderId(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProviderId = new StringValue { Value = value };
    else
      openXmlElement.ProviderId = null;
  }
  
  /// <summary>
  /// signingInstructionsSet, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetSigningInstructionsSet(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructionsSet?.Value;
  }
  
  private static void SetSigningInstructionsSet(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SigningInstructionsSet = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SigningInstructionsSet = null;
  }
  
  /// <summary>
  /// allowComments, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetAllowComments(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.AllowComments?.Value;
  }
  
  private static void SetAllowComments(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowComments = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AllowComments = null;
  }
  
  /// <summary>
  /// showSignDate, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetShowSignDate(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.ShowSignDate?.Value;
  }
  
  private static void SetShowSignDate(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowSignDate = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowSignDate = null;
  }
  
  /// <summary>
  /// suggestedSigner, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSuggestedSigner(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSigner?.Value;
  }
  
  private static void SetSuggestedSigner(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSigner = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSigner = null;
  }
  
  /// <summary>
  /// suggestedSigner2, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSuggestedSigner2(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSigner2?.Value;
  }
  
  private static void SetSuggestedSigner2(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSigner2 = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSigner2 = null;
  }
  
  /// <summary>
  /// suggestedSignerEmail, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSuggestedSignerEmail(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSignerEmail?.Value;
  }
  
  private static void SetSuggestedSignerEmail(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSignerEmail = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSignerEmail = null;
  }
  
  /// <summary>
  /// signingInstructions, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSigningInstructions(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructions?.Value;
  }
  
  private static void SetSigningInstructions(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SigningInstructions = new StringValue { Value = value };
    else
      openXmlElement.SigningInstructions = null;
  }
  
  /// <summary>
  /// addlXml, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAdditionalXml(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.AdditionalXml?.Value;
  }
  
  private static void SetAdditionalXml(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AdditionalXml = new StringValue { Value = value };
    else
      openXmlElement.AdditionalXml = null;
  }
  
  /// <summary>
  /// sigProvUrl, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetSignatureProviderUrl(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement)
  {
    return openXmlElement?.SignatureProviderUrl?.Value;
  }
  
  private static void SetSignatureProviderUrl(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SignatureProviderUrl = new StringValue { Value = value };
    else
      openXmlElement.SignatureProviderUrl = null;
  }
  
  public static DocumentModel.Drawings.SignatureLine? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SignatureLine? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine, new()
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
