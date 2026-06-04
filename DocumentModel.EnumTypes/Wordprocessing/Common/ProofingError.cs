namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ProofingErrorValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues))]
public enum ProofingError
{
  /// <summary>
  ///   Start of Region Marked as Spelling Error.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues.SpellStart))]
  SpellStart,
  /// <summary>
  ///   End of Region Marked as Spelling Error.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues.SpellEnd))]
  SpellEnd,
  /// <summary>
  ///   Start of Region Marked as Grammatical Error.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues.GrammarStart))]
  GrammarStart,
  /// <summary>
  ///   End of Region Marked as Grammatical Error.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues.GrammarEnd))]
  GrammarEnd
}