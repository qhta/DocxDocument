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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIsSignatureLine(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Unique ID
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Signature Provider ID
  /// </summary>
  public static String? GetProviderId(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetProviderId(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Use Signing Instructions Flag
  /// </summary>
  public static Boolean? GetSigningInstructionsSet(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSigningInstructionsSet(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// User-specified Comments Flag
  /// </summary>
  public static Boolean? GetAllowComments(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowComments(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Show Signed Date Flag
  /// </summary>
  public static Boolean? GetShowSignDate(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowSignDate(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Suggested Signer Line 1
  /// </summary>
  public static String? GetSuggestedSigner(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSuggestedSigner(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Suggested Signer Line 2
  /// </summary>
  public static String? GetSuggestedSigner2(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSuggestedSigner2(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Suggested Signer E-mail Address
  /// </summary>
  public static String? GetSuggestedSignerEmail(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSuggestedSignerEmail(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Instructions for Signing
  /// </summary>
  public static String? GetSigningInstructions(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSigningInstructions(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Additional Signature Information
  /// </summary>
  public static String? GetAdditionalXml(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAdditionalXml(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Signature Provider Download URL
  /// </summary>
  public static String? GetSignatureProviderUrl(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSignatureProviderUrl(DocumentFormat.OpenXml.Vml.Office.SignatureLine? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
