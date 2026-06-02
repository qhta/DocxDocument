namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single built-in or user-defined style.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style?view=word-pia"/>
public interface IStyle : IInteropObject
{
  /// <summary>
  /// Returns the name of a built-in style in the language of the user. Read/write String.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.namelocal?view=word-pia"/>
  public string NameLocal { get; set; }

  /// <summary>
  /// Returns or sets an existing style on which you can base the formatting of another style. Read/write Object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.basestyle?view=word-pia"/>
  public object BaseStyle { get; set; }

  /// <summary>
  /// Returns the description of the specified style. Read-only String.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.description?view=word-pia"/>
  public string Description { get; }

  /// <summary>
  /// Returns the style type. Read-only Style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.type?view=word-pia"/>
  public StyleType Type { get; }

  /// <summary>
  /// True if the specified object is one of the built-in styles or caption labels in Microsoft Word. Read-only
  /// Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.builtin?view=word-pia"/>
  public bool BuiltIn { get; }

  /// <summary>
  /// Returns or sets the style to be applied automatically to a new paragraph inserted after a paragraph formatted
  /// with the specified style. Read/write Object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.nextparagraphstyle?view=word-pia"/>
  public object NextParagraphStyle { get; set; }

  /// <summary>
  /// True if the specified style is a built-in style that has been modified or applied in the document or a new
  /// style that has been created in the document. Read-only Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.inuse?view=word-pia"/>
  public bool InUse { get; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns or sets a ParagraphFormat object that represents the paragraph settings for the specified style.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// Returns or sets a Font object that represents the character formatting of the specified object. Read/write
  /// Font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// Returns a Frame object that represents the frame formatting for the specified style. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.frame?view=word-pia"/>
  public Frame Frame { get; }

  /// <summary>
  /// Returns or sets the language for the specified object. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.languageid?view=word-pia"/>
  public LanguageID LanguageID { get; set; }

  /// <summary>
  /// True if the style is automatically redefined based on the selection. False if Microsoft Word prompts for
  /// confirmation before redefining the style based on the selection. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.automaticallyupdate?view=word-pia"/>
  public bool AutomaticallyUpdate { get; set; }

  /// <summary>
  /// Returns a ListTemplate object that represents the list formatting for the specified Style object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.listtemplate?view=word-pia"/>
  public ListTemplate ListTemplate { get; }

  /// <summary>
  /// Returns the list level for the specified style. Read-only Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.listlevelnumber?view=word-pia"/>
  public int ListLevelNumber { get; }

  /// <summary>
  /// Returns or sets an East Asian language for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.languageidfareast?view=word-pia"/>
  public LanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.hidden?view=word-pia"/>
  public bool Hidden { get; set; }

  /// <summary>
  /// True if the spelling and grammar checker ignores text formatted with this style. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// Sets or returns an Object that represents a link between a paragraph and a character style. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.linkstyle?view=word-pia"/>
  public object LinkStyle { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.visibility?view=word-pia"/>
  public bool Visibility { get; set; }

  /// <summary>
  /// True if the spelling and grammar checker ignores text formatted with this style. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.nospacebetweenparagraphsofsamestyle?view=word-pia"/>
  public bool NoSpaceBetweenParagraphsOfSameStyle { get; set; }

  /// <summary>
  /// Returns a TableStyle object representing properties that can be applied to a table using a table style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.table?view=word-pia"/>
  public TableStyle Table { get; }

  /// <summary>
  /// True if the specified style is locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Returns or sets a Integer that represents the priority for sorting styles in the Styles task pane. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.priority?view=word-pia"/>
  public int Priority { get; set; }

  /// <summary>
  /// Set True to clear the Hidden property when this style is used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.unhidewhenused?view=word-pia"/>
  public bool UnhideWhenUsed { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether the style corresponds to an available quick style.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.quickstyle?view=word-pia"/>
  public bool QuickStyle { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether a style is a linked style that can be used for both
  /// paragraph and character formatting. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.linked?view=word-pia"/>
  public bool Linked { get; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.style.delete?view=word-pia"/>
  public void Delete();

  #endregion methods
}
