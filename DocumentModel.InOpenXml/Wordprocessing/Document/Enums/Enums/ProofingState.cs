namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ProofingStateValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ProofingStateValues))]
public enum ProofingState
{
  /// <summary>
  ///   Check Completed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ProofingStateValues.Clean))]
  Clean,
  /// <summary>
  ///   Check Not Completed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ProofingStateValues.Dirty))]
  Dirty
}