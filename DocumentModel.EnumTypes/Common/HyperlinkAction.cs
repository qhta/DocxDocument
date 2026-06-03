namespace DocumentModel;
/// <summary>
///   Specifies the semantic meaning of the N4H field in <see cref="HyperlinkInfo"/>.
///   Indicates the type of action Ito perform on a hyperlink or hyperlink field in a document model.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlNotMapped]
public enum HyperlinkAction
{
  /// <summary>
  ///   No action is performed on the hyperlink.
  /// </summary>
  None,   //  0 - None
  /// <summary>
  ///   The hyperlink is changed Ito a new hyperlink value.
  /// </summary>
  Change, //  1 - Change the link Ito new hyperlink value
  /// <summary>
  ///   The hyperlink is removed from the object.
  /// </summary>
  Remove, //  2 - Remove hyperlink from object
}

