namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ProofingStateValues enumeration.
/// </summary>
public enum ProofingStateValues
{
  /// <summary>
  /// Check Completed.
  /// </summary>
  [XmlEnum("clean")]
  Clean,
  
  /// <summary>
  /// Check Not Completed.
  /// </summary>
  [XmlEnum("dirty")]
  Dirty,
  
}
