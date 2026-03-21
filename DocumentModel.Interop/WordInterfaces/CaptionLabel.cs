namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single caption label.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel?view=word-pia"/>
public partial interface CaptionLabel : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The built in.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.builtin?view=word-pia"/>
  public bool BuiltIn { get; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.id?view=word-pia"/>
  public WdCaptionLabelID ID { get; }

  /// <summary>
  /// The include chapter number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.includechapternumber?view=word-pia"/>
  public bool IncludeChapterNumber { get; set; }

  /// <summary>
  /// The number style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.numberstyle?view=word-pia"/>
  public WdCaptionNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The chapter style level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.chapterstylelevel?view=word-pia"/>
  public int ChapterStyleLevel { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.separator?view=word-pia"/>
  public WdSeparatorType Separator { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabel.position?view=word-pia"/>
  public WdCaptionPosition Position { get; set; }
}
