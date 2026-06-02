namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single caption label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel?view=word-pia"/>
public partial interface ICaptionLabel : IInteropObject
{
  /// <summary>
  /// Gets the name of the caption label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets a value indicating whether the caption label is built in.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.builtin?view=word-pia"/>
  public bool BuiltIn { get; }

  /// <summary>
  /// Gets the built-in ID for the caption label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.id?view=word-pia"/>
  public CaptionLabelID ID { get; }

  /// <summary>
  /// Gets or sets a value indicating whether chapter numbers are included in captions for this label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.includechapternumber?view=word-pia"/>
  public bool IncludeChapterNumber { get; set; }

  /// <summary>
  /// Gets or sets the numbering style for captions that use this label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.numberstyle?view=word-pia"/>
  public CaptionNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// Gets or sets the heading style level used for chapter numbering in captions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.chapterstylelevel?view=word-pia"/>
  public int ChapterStyleLevel { get; set; }

  /// <summary>
  /// Gets or sets the separator between the chapter number and caption number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.separator?view=word-pia"/>
  public SeparatorType Separator { get; set; }

  /// <summary>
  /// Gets or sets the position of captions relative to the associated item.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.position?view=word-pia"/>
  public CaptionPosition Position { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.delete?view=word-pia"/>
  public void Delete();

  #endregion methods
}
