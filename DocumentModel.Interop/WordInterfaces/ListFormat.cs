namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list formatting attributes that can be applied to the paragraphs in a range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat?view=word-pia"/>
public partial interface IListFormat : IInteropObject
{
  /// <summary>
  /// Returns or sets the list level number for the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listlevelnumber?view=word-pia"/>
  public int ListLevelNumber { get; set; }

  /// <summary>
  /// Returns the first valid list that is applied to the paragraphs in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.list?view=word-pia"/>
  public List List { get; }

  /// <summary>
  /// Returns the list template associated with the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listtemplate?view=word-pia"/>
  public ListTemplate ListTemplate { get; }

  /// <summary>
  /// Returns the numeric value of the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listvalue?view=word-pia"/>
  public int ListValue { get; }

  /// <summary>
  /// Returns whether the range contains paragraphs from a single list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.singlelist?view=word-pia"/>
  public bool SingleList { get; }

  /// <summary>
  /// Returns whether the range uses a single list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.singlelisttemplate?view=word-pia"/>
  public bool SingleListTemplate { get; }

  /// <summary>
  /// Returns the list type for the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listtype?view=word-pia"/>
  public ListType ListType { get; }

  /// <summary>
  /// Returns the list string for the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.liststring?view=word-pia"/>
  public string ListString { get; }

  /// <summary>
  /// Returns the picture bullet inline shape for the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listpicturebullet?view=word-pia"/>
  public InlineShape ListPictureBullet { get; }
}
