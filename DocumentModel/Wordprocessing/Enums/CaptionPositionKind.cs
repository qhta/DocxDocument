namespace DocumentModel.Wordprocessing;

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