namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Automatic Caption Positioning Values
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CaptionPositionKind
{
  /// <summary>
  ///   Position Caption Above Object.
  /// </summary>
  Above,

  /// <summary>
  ///   Position Caption Below Object.
  /// </summary>
  Below
}
