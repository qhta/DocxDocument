namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CryptAlgorithmValues enumeration.
/// </summary>
public enum CryptAlgorithm
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
