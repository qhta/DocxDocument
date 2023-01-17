namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public static class ProofStateConverter
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  private static DocumentModel.Wordprocessing.ProofingStateKind? GetSpelling(DocumentFormat.OpenXml.Wordprocessing.ProofState openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DocumentModel.Wordprocessing.ProofingStateKind>(openXmlElement?.Spelling?.Value);
  }
  
  private static void SetSpelling(DocumentFormat.OpenXml.Wordprocessing.ProofState openXmlElement, DocumentModel.Wordprocessing.ProofingStateKind? value)
  {
    openXmlElement.Spelling = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DocumentModel.Wordprocessing.ProofingStateKind>(value);
  }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  private static DocumentModel.Wordprocessing.ProofingStateKind? GetGrammar(DocumentFormat.OpenXml.Wordprocessing.ProofState openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DocumentModel.Wordprocessing.ProofingStateKind>(openXmlElement?.Grammar?.Value);
  }
  
  private static void SetGrammar(DocumentFormat.OpenXml.Wordprocessing.ProofState openXmlElement, DocumentModel.Wordprocessing.ProofingStateKind? value)
  {
    openXmlElement.Grammar = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DocumentModel.Wordprocessing.ProofingStateKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.ProofState? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ProofState? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ProofState();
      value.Spelling = GetSpelling(openXmlElement);
      value.Grammar = GetGrammar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ProofState? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ProofState, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSpelling(openXmlElement, value?.Spelling);
      SetGrammar(openXmlElement, value?.Grammar);
      return openXmlElement;
    }
    return default;
  }
}
