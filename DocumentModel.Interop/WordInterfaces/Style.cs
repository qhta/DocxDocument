namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single built-in or user-defined style.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style?view=word-pia"/>
public partial interface Style : InteropObject
{
  /// <summary>
  /// The name local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.namelocal?view=word-pia"/>
  public string NameLocal { get; set; }

  /// <summary>
  /// The base style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.basestyle?view=word-pia"/>
  public object BaseStyle { get; set; }

  /// <summary>
  /// The description.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.description?view=word-pia"/>
  public string Description { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.type?view=word-pia"/>
  public WdStyleType Type { get; }

  /// <summary>
  /// The built in.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.builtin?view=word-pia"/>
  public bool BuiltIn { get; }

  /// <summary>
  /// The next paragraph style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.nextparagraphstyle?view=word-pia"/>
  public object NextParagraphStyle { get; set; }

  /// <summary>
  /// The in use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.inuse?view=word-pia"/>
  public bool InUse { get; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// The frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.frame?view=word-pia"/>
  public Frame Frame { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The automatically update.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.automaticallyupdate?view=word-pia"/>
  public bool AutomaticallyUpdate { get; set; }

  /// <summary>
  /// The list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.listtemplate?view=word-pia"/>
  public ListTemplate ListTemplate { get; }

  /// <summary>
  /// The list level number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.listlevelnumber?view=word-pia"/>
  public int ListLevelNumber { get; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.hidden?view=word-pia"/>
  public bool Hidden { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// The link style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.linkstyle?view=word-pia"/>
  public object LinkStyle { get; set; }

  /// <summary>
  /// The visibility.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.visibility?view=word-pia"/>
  public bool Visibility { get; set; }

  /// <summary>
  /// The no space between paragraphs of same style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.nospacebetweenparagraphsofsamestyle?view=word-pia"/>
  public bool NoSpaceBetweenParagraphsOfSameStyle { get; set; }

  /// <summary>
  /// The table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.table?view=word-pia"/>
  public TableStyle Table { get; }

  /// <summary>
  /// The locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// The priority.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.priority?view=word-pia"/>
  public int Priority { get; set; }

  /// <summary>
  /// The unhide when used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.unhidewhenused?view=word-pia"/>
  public bool UnhideWhenUsed { get; set; }

  /// <summary>
  /// The quick style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.quickstyle?view=word-pia"/>
  public bool QuickStyle { get; set; }

  /// <summary>
  /// The linked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.linked?view=word-pia"/>
  public bool Linked { get; }
}
