namespace DocumentModel;

/// <summary>
/// This class represents a hyperlink information that is an item of a HyperlinkList extended document property.
/// Although in OpenXml this property is of Variant type, it must be converted to this class to enable proper serialization.
/// </summary>
public class HyperlinkInfo
{
  /// <summary>
  /// Application specific data associated with the hyperlink.
  /// </summary>
  [DataMember]
  public Int32 N1 { get; set; }

  /// <summary>
  /// Application specific data associated with the hyperlink.
  /// </summary>
  [DataMember]
  public Int32 N2 { get; set; }

  /// <summary>
  /// Application specific data associated with the hyperlink.
  /// </summary>
  [DataMember]
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
  [DataMember]
  public HyperlinkAttachment Attachment { get; set; }

  /// <summary>
  ///  The high 16 bits store hyperlink action with one of the possible values:
  ///  0 - None
  ///  1 - Change the link to new hyperlink value
  ///  2 - Remove hyperlink from object
  /// </summary>
  [DataMember]
  public HyperlinkAction Action { get; set; }

  /// <summary>
  /// lpwstr - This specifies the hyperlink target.
  /// </summary>
  [DataMember]
  public string? Target { get; set; }

  /// <summary>
  /// lpwstr	This specifies the location of the hyperlink.
  /// </summary>
  [DataMember]
  public string? Location { get; set; }
}