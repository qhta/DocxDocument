namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CryptAlgorithmValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CryptAlgorithmKind
{
  /// <summary>
  ///   Any Type.
  /// </summary>
  TypeAny,
  /// <summary>
  ///   custom.
  /// </summary>
  Custom
}