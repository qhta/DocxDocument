namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list formatting attributes that can be applied to the paragraphs in a range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat?view=word-pia"/>
public partial class ListFormat : InteropObject
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
  public List List { get; set; }

  /// <summary>
  /// Returns the list template associated with the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listtemplate?view=word-pia"/>
  public ListTemplate ListTemplate { get; set; }

  /// <summary>
  /// Returns the numeric value of the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listvalue?view=word-pia"/>
  public int ListValue { get; set; }

  /// <summary>
  /// Returns whether the range contains paragraphs from a single list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.singlelist?view=word-pia"/>
  public bool SingleList { get; set; }

  /// <summary>
  /// Returns whether the range uses a single list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.singlelisttemplate?view=word-pia"/>
  public bool SingleListTemplate { get; set; }

  /// <summary>
  /// Returns the list type for the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listtype?view=word-pia"/>
  public ListType ListType { get; set; }

  /// <summary>
  /// Returns the list string for the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.liststring?view=word-pia"/>
  public string? ListString { get; set; }

  /// <summary>
  /// Returns the picture bullet inline shape for the first paragraph in the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.listpicturebullet?view=word-pia"/>
  public InlineShape ListPictureBullet { get; set; }


  #region methods

/// <summary>
  /// Returns whether the specified list template can continue the formatting of the previous list.
  /// </summary>
  /// <param name="listTemplate">The list template to check.</param>
  /// <returns>A value that indicates whether numbering can continue from the previous list.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.cancontinuepreviouslist?view=word-pia"/>
  public Continue CanContinuePreviousList(ListTemplate listTemplate) { throw new NotImplementedException(); }

  #endregion methods
}
