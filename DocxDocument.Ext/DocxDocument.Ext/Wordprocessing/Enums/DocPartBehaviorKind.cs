namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DocPartBehaviorValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum DocPartBehaviorKind
{
  /// <summary>
  ///   Insert Content At Specified Location.
  /// </summary>
  Content,

  /// <summary>
  ///   Ensure Entry Is In New Paragraph.
  /// </summary>
  Paragraph,

  /// <summary>
  ///   Ensure Entry Is On New Page.
  /// </summary>
  Page
}