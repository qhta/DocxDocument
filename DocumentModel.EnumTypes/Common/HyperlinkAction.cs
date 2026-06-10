namespace DocumentModel;
/// <summary>
///   Indicates the type of action to perform on a hyperlink or hyperlink field in a document model.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlNotMapped]
public enum HyperlinkAction
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

