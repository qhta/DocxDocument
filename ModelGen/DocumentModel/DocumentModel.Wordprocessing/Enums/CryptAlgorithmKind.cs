namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CryptAlgorithmValues enumeration.
/// </summary>
public enum CryptAlgorithmKind
{
  /// <summary>
  /// Any Type.
  /// </summary>
  [XmlEnum("typeAny")]
  TypeAny,
  
  /// <summary>
  /// custom.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
