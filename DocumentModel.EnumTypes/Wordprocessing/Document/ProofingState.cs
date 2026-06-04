namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ProofingStateValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues))]
public enum ProofingState
{
  /// <summary>
  ///   Check Completed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues.Clean))]
  Clean,
  /// <summary>
  ///   Check Not Completed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues.Dirty))]
  Dirty
}