namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list formatting attributes that can be applied to the paragraphs in a range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat?view=word-pia"/>
public partial interface ListFormat : InteropObject
{
  /// <summary>
  /// Returns or sets the list level number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listlevelnumber?view=word-pia"/>
  public int ListLevelNumber { get; set; }

  /// <summary>
  /// Returns the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.list?view=word-pia"/>
  public List List { get; }

  /// <summary>
  /// Returns the list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listtemplate?view=word-pia"/>
  public ListTemplate ListTemplate { get; }

  /// <summary>
  /// Returns the list value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listvalue?view=word-pia"/>
  public int ListValue { get; }

  /// <summary>
  /// Returns whether single list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.singlelist?view=word-pia"/>
  public bool SingleList { get; }

  /// <summary>
  /// Returns whether single list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.singlelisttemplate?view=word-pia"/>
  public bool SingleListTemplate { get; }

  /// <summary>
  /// Returns the list type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listtype?view=word-pia"/>
  public WdListType ListType { get; }

  /// <summary>
  /// Returns the list string.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.liststring?view=word-pia"/>
  public string ListString { get; }

  /// <summary>
  /// Returns the list picture bullet.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listpicturebullet?view=word-pia"/>
  public InlineShape ListPictureBullet { get; }
}
