namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Digital Signature Line.
/// </summary>
public static class SignatureLineConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Signature Line Flag
  /// </summary>
  private static Boolean? GetIsSignatureLine(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.IsSignatureLine?.Value;
  }
  
  private static void SetIsSignatureLine(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsSignatureLine = value;
    else
      openXmlElement.IsSignatureLine = null;
  }
  
  /// <summary>
  /// Unique ID
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Signature Provider ID
  /// </summary>
  private static String? GetProviderId(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.ProviderId?.Value;
  }
  
  private static void SetProviderId(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProviderId = new StringValue { Value = value };
    else
      openXmlElement.ProviderId = null;
  }
  
  /// <summary>
  /// Use Signing Instructions Flag
  /// </summary>
  private static Boolean? GetSigningInstructionsSet(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructionsSet?.Value;
  }
  
  private static void SetSigningInstructionsSet(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SigningInstructionsSet = value;
    else
      openXmlElement.SigningInstructionsSet = null;
  }
  
  /// <summary>
  /// User-specified Comments Flag
  /// </summary>
  private static Boolean? GetAllowComments(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.AllowComments?.Value;
  }
  
  private static void SetAllowComments(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowComments = value;
    else
      openXmlElement.AllowComments = null;
  }
  
  /// <summary>
  /// Show Signed Date Flag
  /// </summary>
  private static Boolean? GetShowSignDate(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.ShowSignDate?.Value;
  }
  
  private static void SetShowSignDate(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowSignDate = value;
    else
      openXmlElement.ShowSignDate = null;
  }
  
  /// <summary>
  /// Suggested Signer Line 1
  /// </summary>
  private static String? GetSuggestedSigner(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSigner?.Value;
  }
  
  private static void SetSuggestedSigner(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSigner = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSigner = null;
  }
  
  /// <summary>
  /// Suggested Signer Line 2
  /// </summary>
  private static String? GetSuggestedSigner2(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSigner2?.Value;
  }
  
  private static void SetSuggestedSigner2(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSigner2 = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSigner2 = null;
  }
  
  /// <summary>
  /// Suggested Signer E-mail Address
  /// </summary>
  private static String? GetSuggestedSignerEmail(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.SuggestedSignerEmail?.Value;
  }
  
  private static void SetSuggestedSignerEmail(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SuggestedSignerEmail = new StringValue { Value = value };
    else
      openXmlElement.SuggestedSignerEmail = null;
  }
  
  /// <summary>
  /// Instructions for Signing
  /// </summary>
  private static String? GetSigningInstructions(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.SigningInstructions?.Value;
  }
  
  private static void SetSigningInstructions(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SigningInstructions = new StringValue { Value = value };
    else
      openXmlElement.SigningInstructions = null;
  }
  
  /// <summary>
  /// Additional Signature Information
  /// </summary>
  private static String? GetAdditionalXml(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.AdditionalXml?.Value;
  }
  
  private static void SetAdditionalXml(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AdditionalXml = new StringValue { Value = value };
    else
      openXmlElement.AdditionalXml = null;
  }
  
  /// <summary>
  /// Signature Provider Download URL
  /// </summary>
  private static String? GetSignatureProviderUrl(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement)
  {
    return openXmlElement?.SignatureProviderUrl?.Value;
  }
  
  private static void SetSignatureProviderUrl(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SignatureProviderUrl = new StringValue { Value = value };
    else
      openXmlElement.SignatureProviderUrl = null;
  }
  
  public static DocumentModel.Vml.SignatureLine? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.SignatureLine? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.SignatureLine, new()
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
