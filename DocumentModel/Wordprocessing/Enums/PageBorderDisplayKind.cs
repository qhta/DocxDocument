namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageBorderDisplayValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageBorderDisplayKind
{
  /// <summary>
  ///   Display IPage IBorder on All IPages.
  /// </summary>
  AllPages,

  /// <summary>
  ///   Display IPage IBorder on First IPage.
  /// </summary>
  FirstPage,

  /// <summary>
  ///   Display IPage IBorder on All IPages Except First.
  /// </summary>
  NotFirstPage
}
