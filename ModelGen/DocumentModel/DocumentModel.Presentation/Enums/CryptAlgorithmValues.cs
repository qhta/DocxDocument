namespace DocumentModel.Presentation;

/// <summary>
/// Cryptographic Algorithm Type
/// </summary>
public enum CryptAlgorithmValues
{
  /// <summary>
  /// Any Algorithm Type.
  /// </summary>
  [XmlEnum("typeAny")]
  TypeAny,
  
  /// <summary>
  /// Invalid Algorithm Type.
  /// </summary>
  [XmlEnum("invalid")]
  Invalid,
  
}
