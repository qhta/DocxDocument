namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single built-in or user-defined style.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style?view=word-pia"/>
public partial interface Style : InteropObject
{
  /// <summary>
  /// Returns or sets the name local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.namelocal?view=word-pia"/>
  public string NameLocal { get; set; }

  /// <summary>
  /// Returns or sets the base style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.basestyle?view=word-pia"/>
  public object BaseStyle { get; set; }

  /// <summary>
  /// Returns the description.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.description?view=word-pia"/>
  public string Description { get; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.type?view=word-pia"/>
  public WdStyleType Type { get; }

  /// <summary>
  /// Returns whether built in.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.builtin?view=word-pia"/>
  public bool BuiltIn { get; }

  /// <summary>
  /// Returns or sets the next paragraph style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.nextparagraphstyle?view=word-pia"/>
  public object NextParagraphStyle { get; set; }

  /// <summary>
  /// Returns whether in use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.inuse?view=word-pia"/>
  public bool InUse { get; }

  /// <summary>
  /// Returns the shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Returns or sets the borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns or sets the paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// Returns or sets the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// Returns the frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.frame?view=word-pia"/>
  public Frame Frame { get; }

  /// <summary>
  /// Returns or sets the language i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// Returns or sets whether automatically update.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.automaticallyupdate?view=word-pia"/>
  public bool AutomaticallyUpdate { get; set; }

  /// <summary>
  /// Returns the list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.listtemplate?view=word-pia"/>
  public ListTemplate ListTemplate { get; }

  /// <summary>
  /// Returns the list level number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.listlevelnumber?view=word-pia"/>
  public int ListLevelNumber { get; }

  /// <summary>
  /// Returns or sets the language i d far east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Returns or sets whether hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.hidden?view=word-pia"/>
  public bool Hidden { get; set; }

  /// <summary>
  /// Returns or sets the no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// Returns or sets the link style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.linkstyle?view=word-pia"/>
  public object LinkStyle { get; set; }

  /// <summary>
  /// Returns or sets whether visibility.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.visibility?view=word-pia"/>
  public bool Visibility { get; set; }

  /// <summary>
  /// Returns or sets whether no space between paragraphs of same style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.nospacebetweenparagraphsofsamestyle?view=word-pia"/>
  public bool NoSpaceBetweenParagraphsOfSameStyle { get; set; }

  /// <summary>
  /// Returns the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.table?view=word-pia"/>
  public TableStyle Table { get; }

  /// <summary>
  /// Returns or sets whether locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Returns or sets the priority.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.priority?view=word-pia"/>
  public int Priority { get; set; }

  /// <summary>
  /// Returns or sets whether unhide when used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.unhidewhenused?view=word-pia"/>
  public bool UnhideWhenUsed { get; set; }

  /// <summary>
  /// Returns or sets whether quick style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.quickstyle?view=word-pia"/>
  public bool QuickStyle { get; set; }

  /// <summary>
  /// Returns whether linked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.linked?view=word-pia"/>
  public bool Linked { get; }
}
