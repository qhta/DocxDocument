namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ProofingStateValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ProofingStateKind
{
  /// <summary>
  ///   Check Completed.
  /// </summary>
  Clean,
  /// <summary>
  ///   Check Not Completed.
  /// </summary>
  Dirty
}