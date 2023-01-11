namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Digital Signature Line.
/// </summary>
public static class SignatureLineConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Signature Line Flag
  /// </summary>
  public static Boolean? GetIsSignatureLine(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetIsSignatureLine(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Unique ID
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Signature Provider ID
  /// </summary>
  public static String? GetProviderId(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return openXmlElement?.ProviderId?.Value;
  }
  
  public static void SetProviderId(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ProviderId = new StringValue { Value = value };
      else
        openXmlElement.ProviderId = null;
  }
  
  /// <summary>
  /// Use Signing Instructions Flag
  /// </summary>
  public static Boolean? GetSigningInstructionsSet(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetSigningInstructionsSet(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// User-specified Comments Flag
  /// </summary>
  public static Boolean? GetAllowComments(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowComments(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Show Signed Date Flag
  /// </summary>
  public static Boolean? GetShowSignDate(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetShowSignDate(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Suggested Signer Line 1
  /// </summary>
  public static String? GetSuggestedSigner(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return openXmlElement?.SuggestedSigner?.Value;
  }
  
  public static void SetSuggestedSigner(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SuggestedSigner = new StringValue { Value = value };
      else
        openXmlElement.SuggestedSigner = null;
  }
  
  /// <summary>
  /// Suggested Signer Line 2
  /// </summary>
  public static String? GetSuggestedSigner2(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return openXmlElement?.SuggestedSigner2?.Value;
  }
  
  public static void SetSuggestedSigner2(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SuggestedSigner2 = new StringValue { Value = value };
      else
        openXmlElement.SuggestedSigner2 = null;
  }
  
  /// <summary>
  /// Suggested Signer E-mail Address
  /// </summary>
  public static String? GetSuggestedSignerEmail(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return openXmlElement?.SuggestedSignerEmail?.Value;
  }
  
  public static void SetSuggestedSignerEmail(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SuggestedSignerEmail = new StringValue { Value = value };
      else
        openXmlElement.SuggestedSignerEmail = null;
  }
  
  /// <summary>
  /// Instructions for Signing
  /// </summary>
  public static String? GetSigningInstructions(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return openXmlElement?.SigningInstructions?.Value;
  }
  
  public static void SetSigningInstructions(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SigningInstructions = new StringValue { Value = value };
      else
        openXmlElement.SigningInstructions = null;
  }
  
  /// <summary>
  /// Additional Signature Information
  /// </summary>
  public static String? GetAdditionalXml(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return openXmlElement?.AdditionalXml?.Value;
  }
  
  public static void SetAdditionalXml(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AdditionalXml = new StringValue { Value = value };
      else
        openXmlElement.AdditionalXml = null;
  }
  
  /// <summary>
  /// Signature Provider Download URL
  /// </summary>
  public static String? GetSignatureProviderUrl(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    return openXmlElement?.SignatureProviderUrl?.Value;
  }
  
  public static void SetSignatureProviderUrl(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
