namespace DocumentModel.Wordprocessing;

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