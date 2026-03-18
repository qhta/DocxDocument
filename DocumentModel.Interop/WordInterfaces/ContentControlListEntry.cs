namespace DocumentModel.Interop;

/// <summary>
/// A ContentControlListEntry object represents a list item in a drop-down list or combo box content control. A ContentControlListEntry object is a member of the ContentControlListEntries collection for a ContentControl object.
/// </summary>
public partial interface ContentControlListEntry : InteropObject
{
  /// <summary>
  /// The text.
  /// </summary>
  public string Text { get; set; }

  /// <summary>
  /// The value.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; set; }
}
