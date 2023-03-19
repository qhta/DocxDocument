namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CommentExtensible Class.
/// </summary>
public class CommentExtensible: ModelElement
{
  /// <summary>
  ///   durableId, this property is only available in Office 2021 and later.
  /// </summary>
  public HexInt? DurableId { get; set; }

  /// <summary>
  ///   dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DateUtc { get; set; }

  /// <summary>
  ///   intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  public Boolean? IntelligentPlaceholder { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}