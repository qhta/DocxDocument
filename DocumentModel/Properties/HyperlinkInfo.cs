namespace DocumentModel.Properties;

/// <summary>
///   Hyperlink info as HyperlinkList item.
/// </summary>
public class HyperlinkInfo : ModelElement
{
  /// <summary>
  /// Application specific data associated with the hyperlink.
  /// </summary>
  public Int32 N1 { get; set; }

  /// <summary>
  /// Application specific data associated with the hyperlink.
  /// </summary>
  public Int32 N2 { get; set; }

  /// <summary>
  /// Application specific data associated with the hyperlink.
  /// </summary>
  public Int32 N3 { get; set; }

  /// <summary>
  ///  The lower 16 bits specify hyperlink type with one of the possible values:
  ///  0 - Graphic shown as background of document
  ///  1 - Graphic shown in document
  ///  2 - Graphic used to fill a shape
  ///  3 - Graphic used for shape outline
  ///  4 - Hyperlink attached to a shape
  ///  5 - Hyperlink attached to a WordprocessingML  field
  ///  6 - Hyperlink attached to a SpreadsheetML  range
  /// </summary>
  public HyperlinkAttachment Attachment { get; set; }

  /// <summary>
  ///  The high 16 bits store hyperlink action with one of the possible values:
  ///  0 - None
  ///  1 - Change the link to new hyperlink value
  ///  2 - Remove hyperlink from object
  /// </summary>
  public HyperlinkAction Action { get; set; }

  /// <summary>
  /// lpwstr - This specifies the hyperlink target.
  /// </summary>
  public String? Target { get; set; }

  /// <summary>
  /// lpwstr	This specifies the location of the hyperlink.
  /// </summary>
  public String? Location { get; set; }
}