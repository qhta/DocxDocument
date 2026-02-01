namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ProofingErrorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ProofingErrorValues))]
public enum ProofingErrorKind
{
  /// <summary>
  ///   Start of Region Marked as Spelling Error.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ProofingErrorValues.SpellStart))]
  SpellStart,
  /// <summary>
  ///   End of Region Marked as Spelling Error.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ProofingErrorValues.SpellEnd))]
  SpellEnd,
  /// <summary>
  ///   Start of Region Marked as Grammatical Error.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ProofingErrorValues.GrammarStart))]
  GrammarStart,
  /// <summary>
  ///   End of Region Marked as Grammatical Error.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ProofingErrorValues.GrammarEnd))]
  GrammarEnd
}