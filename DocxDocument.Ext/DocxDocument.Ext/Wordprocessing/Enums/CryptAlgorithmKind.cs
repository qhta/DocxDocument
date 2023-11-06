namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CryptAlgorithmValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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