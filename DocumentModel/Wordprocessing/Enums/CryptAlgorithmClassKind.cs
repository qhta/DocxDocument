namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CryptAlgorithmClassValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CryptAlgorithmClassKind
{
  /// <summary>
  ///   Hashing.
  /// </summary>
  Hash,

  /// <summary>
  ///   custom.
  /// </summary>
  Custom
}