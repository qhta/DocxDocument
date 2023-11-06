namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CryptAlgorithmClassValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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