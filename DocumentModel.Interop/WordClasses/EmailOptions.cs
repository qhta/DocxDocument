namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains global application-level attributes used by Microsoft Word when you create and edit e-mail messages and replies.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions?view=word-pia"/>
public partial class EmailOptions : InteropObject
{
  /// <summary>
  /// Gets or sets a value indicating whether theme styles are used for email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.usethemestyle?view=word-pia"/>
  public bool UseThemeStyle { get; set; }

  /// <summary>
  /// Gets or sets the text used to mark comments in email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.markcommentswith?view=word-pia"/>
  public string? MarkCommentsWith { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether comments are marked in email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.markcomments?view=word-pia"/>
  public bool MarkComments { get; set; }

  /// <summary>
  /// Gets the email signature settings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.emailsignature?view=word-pia"/>
  public EmailSignature EmailSignature { get; set; }

  /// <summary>
  /// Gets the style used when composing email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.composestyle?view=word-pia"/>
  public Style ComposeStyle { get; set; }

  /// <summary>
  /// Gets the style used when replying to email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.replystyle?view=word-pia"/>
  public Style ReplyStyle { get; set; }

  /// <summary>
  /// Gets or sets the theme name used for email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.themename?view=word-pia"/>
  public string? ThemeName { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.dummy1?view=word-pia"/>
  public bool Dummy1 { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.dummy2?view=word-pia"/>
  public bool Dummy2 { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether a new color is used for replies.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.newcoloronreply?view=word-pia"/>
  public bool NewColorOnReply { get; set; }

  /// <summary>
  /// Gets the style used for plain-text email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.plaintextstyle?view=word-pia"/>
  public Style PlainTextStyle { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether theme styles are used for replies.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.usethemestyleonreply?view=word-pia"/>
  public bool UseThemeStyleOnReply { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type applies heading styles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplyheadings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyHeadings { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type applies borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplyborders?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBorders { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type applies bulleted lists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplybulletedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBulletedLists { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type applies numbered lists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplynumberedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyNumberedLists { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type replaces straight quotes with smart quotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacequotes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceQuotes { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type replaces symbol characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacesymbols?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceSymbols { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type replaces ordinals with superscripts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplaceordinals?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceOrdinals { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type replaces fractions with fraction characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacefractions?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFractions { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type replaces plain-text emphasis with formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplaceplaintextemphasis?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type formats list item beginnings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeformatlistitembeginning?view=word-pia"/>
  public bool AutoFormatAsYouTypeFormatListItemBeginning { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type defines styles automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypedefinestyles?view=word-pia"/>
  public bool AutoFormatAsYouTypeDefineStyles { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type replaces typed hyperlinks with active links.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacehyperlinks?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceHyperlinks { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type applies automatic table formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplytables?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyTables { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type applies first-line indents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplyfirstindents?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyFirstIndents { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type applies date formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplydates?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyDates { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type applies closing formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeapplyclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyClosings { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type matches parentheses.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypematchparentheses?view=word-pia"/>
  public bool AutoFormatAsYouTypeMatchParentheses { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type replaces Far East dashes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypereplacefareastdashes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFarEastDashes { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type deletes automatic spaces.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypedeleteautospaces?view=word-pia"/>
  public bool AutoFormatAsYouTypeDeleteAutoSpaces { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type inserts closings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeinsertclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertClosings { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type uses the automatic letter wizard.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeautoletterwizard?view=word-pia"/>
  public bool AutoFormatAsYouTypeAutoLetterWizard { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether AutoFormat As You Type inserts overs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.autoformatasyoutypeinsertovers?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertOvers { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether formatting is saved by using cascading style sheets (CSS).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.relyoncss?view=word-pia"/>
  public bool RelyOnCSS { get; set; }

  /// <summary>
  /// Gets or sets the HTML fidelity level for email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.htmlfidelity?view=word-pia"/>
  public EmailHTMLFidelity HTMLFidelity { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether Smart Tags are embedded in email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.embedsmarttag?view=word-pia"/>
  public bool EmbedSmartTag { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the TAB key indents content in email messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailoptions.tabindentkey?view=word-pia"/>
  public bool TabIndentKey { get; set; }
}
