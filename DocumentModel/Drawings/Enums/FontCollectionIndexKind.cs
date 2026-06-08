namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IFont Collection IIndex
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FontCollectionIndexKind
{
  /// <summary>
  ///   Major IFont.
  /// </summary>
  Major,

  /// <summary>
  ///   Minor IFont.
  /// </summary>
  Minor,

  /// <summary>
  ///   None.
  /// </summary>
  None
}
