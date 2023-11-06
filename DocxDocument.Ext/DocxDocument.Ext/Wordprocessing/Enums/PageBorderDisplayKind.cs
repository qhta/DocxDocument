namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageBorderDisplayValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum PageBorderDisplayKind
{
  /// <summary>
  ///   Display Page Border on All Pages.
  /// </summary>
  AllPages,

  /// <summary>
  ///   Display Page Border on First Page.
  /// </summary>
  FirstPage,

  /// <summary>
  ///   Display Page Border on All Pages Except First.
  /// </summary>
  NotFirstPage
}