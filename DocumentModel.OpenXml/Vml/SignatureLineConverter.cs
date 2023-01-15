using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using SignatureLine = DocumentFormat.OpenXml.Vml.Office.SignatureLine;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Digital Signature Line.
/// </summary>
public static class SignatureLineConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(SignatureLine? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(SignatureLine? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Signature Line Flag
  /// </summary>
  public static Boolean? GetIsSignatureLine(SignatureLine? openXmlElement)
  {
    return openXmlElement?.IsSignatureLine?.Value;
  }

  public static void SetIsSignatureLine(SignatureLine? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IsSignatureLine = value;
      else
        openXmlElement.IsSignatureLine = null;
  }

  /// <summary>
  ///   Unique ID
  /// </summary>
  public static String? GetId(SignatureLine? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Signature Provider ID
  /// </summary>
  public static String? GetProviderId(SignatureLine? openXmlElement)
  {
    return openXmlElement?.ProviderId?.Value;
  }

  public static void SetProviderId(SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ProviderId = new StringValue { Value = value };
      else
        openXmlElement.ProviderId = null;
  }

  /// <summary>
  ///   Use Signing Instructions Flag
  /// </summary>
  public static Boolean? GetSigningInstructionsSet(SignatureLine? openXmlElement)
  {
    return openXmlElement?.SigningInstructionsSet?.Value;
  }

  public static void SetSigningInstructionsSet(SignatureLine? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SigningInstructionsSet = value;
      else
        openXmlElement.SigningInstructionsSet = null;
  }

  /// <summary>
  ///   User-specified Comments Flag
  /// </summary>
  public static Boolean? GetAllowComments(SignatureLine? openXmlElement)
  {
    return openXmlElement?.AllowComments?.Value;
  }

  public static void SetAllowComments(SignatureLine? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowComments = value;
      else
        openXmlElement.AllowComments = null;
  }

  /// <summary>
  ///   Show Signed Date Flag
  /// </summary>
  public static Boolean? GetShowSignDate(SignatureLine? openXmlElement)
  {
    return openXmlElement?.ShowSignDate?.Value;
  }

  public static void SetShowSignDate(SignatureLine? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowSignDate = value;
      else
        openXmlElement.ShowSignDate = null;
  }

  /// <summary>
  ///   Suggested Signer Line 1
  /// </summary>
  public static String? GetSuggestedSigner(SignatureLine? openXmlElement)
  {
    return openXmlElement?.SuggestedSigner?.Value;
  }

  public static void SetSuggestedSigner(SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SuggestedSigner = new StringValue { Value = value };
      else
        openXmlElement.SuggestedSigner = null;
  }

  /// <summary>
  ///   Suggested Signer Line 2
  /// </summary>
  public static String? GetSuggestedSigner2(SignatureLine? openXmlElement)
  {
    return openXmlElement?.SuggestedSigner2?.Value;
  }

  public static void SetSuggestedSigner2(SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SuggestedSigner2 = new StringValue { Value = value };
      else
        openXmlElement.SuggestedSigner2 = null;
  }

  /// <summary>
  ///   Suggested Signer E-mail Address
  /// </summary>
  public static String? GetSuggestedSignerEmail(SignatureLine? openXmlElement)
  {
    return openXmlElement?.SuggestedSignerEmail?.Value;
  }

  public static void SetSuggestedSignerEmail(SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SuggestedSignerEmail = new StringValue { Value = value };
      else
        openXmlElement.SuggestedSignerEmail = null;
  }

  /// <summary>
  ///   Instructions for Signing
  /// </summary>
  public static String? GetSigningInstructions(SignatureLine? openXmlElement)
  {
    return openXmlElement?.SigningInstructions?.Value;
  }

  public static void SetSigningInstructions(SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SigningInstructions = new StringValue { Value = value };
      else
        openXmlElement.SigningInstructions = null;
  }

  /// <summary>
  ///   Additional Signature Information
  /// </summary>
  public static String? GetAdditionalXml(SignatureLine? openXmlElement)
  {
    return openXmlElement?.AdditionalXml?.Value;
  }

  public static void SetAdditionalXml(SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AdditionalXml = new StringValue { Value = value };
      else
        openXmlElement.AdditionalXml = null;
  }

  /// <summary>
  ///   Signature Provider Download URL
  /// </summary>
  public static String? GetSignatureProviderUrl(SignatureLine? openXmlElement)
  {
    return openXmlElement?.SignatureProviderUrl?.Value;
  }

  public static void SetSignatureProviderUrl(SignatureLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SignatureProviderUrl = new StringValue { Value = value };
      else
        openXmlElement.SignatureProviderUrl = null;
  }

  public static DocumentModel.Vml.SignatureLine? CreateModelElement(SignatureLine? openXmlElement)
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
    where OpenXmlElementType : SignatureLine, new()
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