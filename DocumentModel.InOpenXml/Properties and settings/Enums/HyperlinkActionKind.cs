namespace DocumentModel;
/// <summary>
///   Specifies the semantic meaning of the N4H field in <see cref="HyperlinkInfo"/>.
///   Indicates the type of action to perform on a hyperlink or hyperlink field in a document model.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlType(typeof(DXVT.Variant))]
public enum HyperlinkActionKind
{
  /// <summary>
  ///   No action is performed on the hyperlink.
  /// </summary>
  None,   //  0 - None
  /// <summary>
  ///   The hyperlink is changed to a new hyperlink value.
  /// </summary>
  Change, //  1 - Change the link to new hyperlink value
  /// <summary>
  ///   The hyperlink is removed from the object.
  /// </summary>
  Remove, //  2 - Remove hyperlink from object
}
