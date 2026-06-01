namespace DocumentModel.Interop.Word;

/// <summary>
/// A ContentControlListEntry object represents a list item in a drop-down list or combo box content control. A ContentControlListEntry object is a member of the ContentControlListEntries collection for a ContentControl object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentry?view=word-pia"/>
public partial class ContentControlListEntry : InteropObject
{
  /// <summary>
  /// Gets or sets the display text of the list entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentry.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Gets or sets the value of the list entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentry.value?view=word-pia"/>
  public string Value { get; set; }

  /// <summary>
  /// Gets or sets the index of the list entry in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentry.index?view=word-pia"/>
  public int Index { get; set; }
}
