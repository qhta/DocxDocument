namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public static class ProofStateConverter
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  public static DocumentModel.Wordprocessing.ProofingStateKind? GetSpelling(DocumentFormat.OpenXml.Wordprocessing.ProofState? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DocumentModel.Wordprocessing.ProofingStateKind>(openXmlElement?.Spelling?.Value);
  }
  
  public static void SetSpelling(DocumentFormat.OpenXml.Wordprocessing.ProofState? openXmlElement, DocumentModel.Wordprocessing.ProofingStateKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Spelling = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DocumentModel.Wordprocessing.ProofingStateKind>(value);
  }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  public static DocumentModel.Wordprocessing.ProofingStateKind? GetGrammar(DocumentFormat.OpenXml.Wordprocessing.ProofState? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DocumentModel.Wordprocessing.ProofingStateKind>(openXmlElement?.Grammar?.Value);
  }
  
  public static void SetGrammar(DocumentFormat.OpenXml.Wordprocessing.ProofState? openXmlElement, DocumentModel.Wordprocessing.ProofingStateKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Grammar = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DocumentModel.Wordprocessing.ProofingStateKind>(value);
  }
  
}
