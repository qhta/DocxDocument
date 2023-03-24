namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ViewValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ViewKind
{
  /// <summary>
  ///   Default View.
  /// </summary>
  None,

  /// <summary>
  ///   Print Layout View.
  /// </summary>
  Print,

  /// <summary>
  ///   Outline View.
  /// </summary>
  Outline,

  /// <summary>
  ///   Master Document View.
  /// </summary>
  MasterPages,

  /// <summary>
  ///   Draft View.
  /// </summary>
  Normal,

  /// <summary>
  ///   Web Page View.
  /// </summary>
  Web
}