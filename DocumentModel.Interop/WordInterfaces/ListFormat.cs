namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list formatting attributes that can be applied to the paragraphs in a range.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat?view=word-pia"/>
public partial interface ListFormat : InteropObject
{
  /// <summary>
  /// The list level number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listlevelnumber?view=word-pia"/>
  public int ListLevelNumber { get; set; }

  /// <summary>
  /// The list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.list?view=word-pia"/>
  public List List { get; }

  /// <summary>
  /// The list template.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listtemplate?view=word-pia"/>
  public ListTemplate ListTemplate { get; }

  /// <summary>
  /// The list value.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listvalue?view=word-pia"/>
  public int ListValue { get; }

  /// <summary>
  /// The single list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.singlelist?view=word-pia"/>
  public bool SingleList { get; }

  /// <summary>
  /// The single list template.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.singlelisttemplate?view=word-pia"/>
  public bool SingleListTemplate { get; }

  /// <summary>
  /// The list type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listtype?view=word-pia"/>
  public WdListType ListType { get; }

  /// <summary>
  /// The list string.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.liststring?view=word-pia"/>
  public string ListString { get; }

  /// <summary>
  /// The list picture bullet.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listpicturebullet?view=word-pia"/>
  public InlineShape ListPictureBullet { get; }
}
