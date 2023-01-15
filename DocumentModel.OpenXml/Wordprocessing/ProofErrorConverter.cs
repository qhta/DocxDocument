using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using ProofError = DocumentFormat.OpenXml.Wordprocessing.ProofError;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the ProofError Class.
/// </summary>
public static class ProofErrorConverter
{
  /// <summary>
  ///   Proofing Error Anchor Type
  /// </summary>
  public static ProofingErrorKind? GetType(ProofError? openXmlElement)
  {
    return EnumValueConverter.GetValue<ProofingErrorValues, ProofingErrorKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(ProofError? openXmlElement, ProofingErrorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<ProofingErrorValues, ProofingErrorKind>(value);
  }

  public static DocumentModel.Wordprocessing.ProofError? CreateModelElement(ProofError? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ProofError();
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ProofError? value)
    where OpenXmlElementType : ProofError, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}