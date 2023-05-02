namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FrameScrollbarVisibilityValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FrameScrollbarVisibilityKind
{
  /// <summary>
  ///   Always Show Scrollbar.
  /// </summary>
  On,

  /// <summary>
  ///   Never Show Scrollbar.
  /// </summary>
  Off,

  /// <summary>
  ///   Automatically Show Scrollbar As Needed.
  /// </summary>
  Auto
}