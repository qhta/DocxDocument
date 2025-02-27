namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DocumentConformance enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocumentConformance
{
  /// <summary>
  ///   transitional.
  /// </summary>
  transitional,

  /// <summary>
  ///   strict.
  /// </summary>
  strict
}