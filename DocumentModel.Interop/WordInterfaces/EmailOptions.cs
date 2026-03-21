namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains global application-level attributes used by Microsoft Word when you create and edit e-mail messages and replies.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions?view=word-pia"/>
public partial interface EmailOptions : InteropObject
{
  /// <summary>
  /// The use theme style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.usethemestyle?view=word-pia"/>
  public bool UseThemeStyle { get; set; }

  /// <summary>
  /// The mark comments with.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.markcommentswith?view=word-pia"/>
  public string MarkCommentsWith { get; set; }

  /// <summary>
  /// The mark comments.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.markcomments?view=word-pia"/>
  public bool MarkComments { get; set; }

  /// <summary>
  /// The email signature.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.emailsignature?view=word-pia"/>
  public EmailSignature EmailSignature { get; }

  /// <summary>
  /// The compose style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.composestyle?view=word-pia"/>
  public Style ComposeStyle { get; }

  /// <summary>
  /// The reply style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.replystyle?view=word-pia"/>
  public Style ReplyStyle { get; }

  /// <summary>
  /// The theme name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.themename?view=word-pia"/>
  public string ThemeName { get; set; }

  /// <summary>
  /// The dummy1.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.dummy1?view=word-pia"/>
  public bool Dummy1 { get; }

  /// <summary>
  /// The dummy2.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.dummy2?view=word-pia"/>
  public bool Dummy2 { get; }

  /// <summary>
  /// The new color on reply.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.newcoloronreply?view=word-pia"/>
  public bool NewColorOnReply { get; set; }

  /// <summary>
  /// The plain text style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.plaintextstyle?view=word-pia"/>
  public Style PlainTextStyle { get; }

  /// <summary>
  /// The use theme style on reply.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.usethemestyleonreply?view=word-pia"/>
  public bool UseThemeStyleOnReply { get; set; }

  /// <summary>
  /// The auto format as you type apply headings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplyheadings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyHeadings { get; set; }

  /// <summary>
  /// The auto format as you type apply borders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplyborders?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBorders { get; set; }

  /// <summary>
  /// The auto format as you type apply bulleted lists.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplybulletedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBulletedLists { get; set; }

  /// <summary>
  /// The auto format as you type apply numbered lists.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplynumberedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyNumberedLists { get; set; }

  /// <summary>
  /// The auto format as you type replace quotes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacequotes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceQuotes { get; set; }

  /// <summary>
  /// The auto format as you type replace symbols.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacesymbols?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceSymbols { get; set; }

  /// <summary>
  /// The auto format as you type replace ordinals.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplaceordinals?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceOrdinals { get; set; }

  /// <summary>
  /// The auto format as you type replace fractions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacefractions?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFractions { get; set; }

  /// <summary>
  /// The auto format as you type replace plain text emphasis.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplaceplaintextemphasis?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// The auto format as you type format list item beginning.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeformatlistitembeginning?view=word-pia"/>
  public bool AutoFormatAsYouTypeFormatListItemBeginning { get; set; }

  /// <summary>
  /// The auto format as you type define styles.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypedefinestyles?view=word-pia"/>
  public bool AutoFormatAsYouTypeDefineStyles { get; set; }

  /// <summary>
  /// The auto format as you type replace hyperlinks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacehyperlinks?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceHyperlinks { get; set; }

  /// <summary>
  /// The auto format as you type apply tables.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplytables?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyTables { get; set; }

  /// <summary>
  /// The auto format as you type apply first indents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplyfirstindents?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyFirstIndents { get; set; }

  /// <summary>
  /// The auto format as you type apply dates.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplydates?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyDates { get; set; }

  /// <summary>
  /// The auto format as you type apply closings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplyclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyClosings { get; set; }

  /// <summary>
  /// The auto format as you type match parentheses.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypematchparentheses?view=word-pia"/>
  public bool AutoFormatAsYouTypeMatchParentheses { get; set; }

  /// <summary>
  /// The auto format as you type replace far east dashes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacefareastdashes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFarEastDashes { get; set; }

  /// <summary>
  /// The auto format as you type delete auto spaces.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypedeleteautospaces?view=word-pia"/>
  public bool AutoFormatAsYouTypeDeleteAutoSpaces { get; set; }

  /// <summary>
  /// The auto format as you type insert closings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeinsertclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertClosings { get; set; }

  /// <summary>
  /// The auto format as you type auto letter wizard.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeautoletterwizard?view=word-pia"/>
  public bool AutoFormatAsYouTypeAutoLetterWizard { get; set; }

  /// <summary>
  /// The auto format as you type insert overs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeinsertovers?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertOvers { get; set; }

  /// <summary>
  /// The rely on css.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.relyoncss?view=word-pia"/>
  public bool RelyOnCSS { get; set; }

  /// <summary>
  /// The htmlfidelity.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.htmlfidelity?view=word-pia"/>
  public WdEmailHTMLFidelity HTMLFidelity { get; set; }

  /// <summary>
  /// The embed smart tag.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.embedsmarttag?view=word-pia"/>
  public bool EmbedSmartTag { get; set; }

  /// <summary>
  /// The tab indent key.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.tabindentkey?view=word-pia"/>
  public bool TabIndentKey { get; set; }
}
