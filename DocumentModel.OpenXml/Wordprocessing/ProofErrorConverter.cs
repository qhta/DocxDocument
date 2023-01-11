namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public static class ProofErrorConverter
{
  /// <summary>
  /// Proofing Error Anchor Type
  /// </summary>
  public static DocumentModel.Wordprocessing.ProofingErrorKind? GetType(DocumentFormat.OpenXml.Wordprocessing.ProofError? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues, DocumentModel.Wordprocessing.ProofingErrorKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.ProofError? openXmlElement, DocumentModel.Wordprocessing.ProofingErrorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues, DocumentModel.Wordprocessing.ProofingErrorKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.ProofError? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ProofError? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ProofError, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
