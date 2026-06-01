namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ViewValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ViewKind
{
  /// <summary>
  ///   Default IView.
  /// </summary>
  None,

  /// <summary>
  ///   Print Layout IView.
  /// </summary>
  Print,

  /// <summary>
  ///   Outline IView.
  /// </summary>
  Outline,

  /// <summary>
  ///   Master IDocument IView.
  /// </summary>
  MasterPages,

  /// <summary>
  ///   Draft IView.
  /// </summary>
  Normal,

  /// <summary>
  ///   Web IPage IView.
  /// </summary>
  Web
}
