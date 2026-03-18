namespace DocumentModel.Interop;

/// <summary>
/// Contains global application-level attributes used by Microsoft Word when you create and edit e-mail messages and replies.
/// </summary>
public partial interface EmailOptions : InteropObject
{
  /// <summary>
  /// The use theme style.
  /// </summary>
  public bool UseThemeStyle { get; set; }

  /// <summary>
  /// The mark comments with.
  /// </summary>
  public string MarkCommentsWith { get; set; }

  /// <summary>
  /// The mark comments.
  /// </summary>
  public bool MarkComments { get; set; }

  /// <summary>
  /// The email signature.
  /// </summary>
  public EmailSignature EmailSignature { get; }

  /// <summary>
  /// The compose style.
  /// </summary>
  public Style ComposeStyle { get; }

  /// <summary>
  /// The reply style.
  /// </summary>
  public Style ReplyStyle { get; }

  /// <summary>
  /// The theme name.
  /// </summary>
  public string ThemeName { get; set; }

  /// <summary>
  /// The dummy1.
  /// </summary>
  public bool Dummy1 { get; }

  /// <summary>
  /// The dummy2.
  /// </summary>
  public bool Dummy2 { get; }

  /// <summary>
  /// The new color on reply.
  /// </summary>
  public bool NewColorOnReply { get; set; }

  /// <summary>
  /// The plain text style.
  /// </summary>
  public Style PlainTextStyle { get; }

  /// <summary>
  /// The use theme style on reply.
  /// </summary>
  public bool UseThemeStyleOnReply { get; set; }

  /// <summary>
  /// The auto format as you type apply headings.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyHeadings { get; set; }

  /// <summary>
  /// The auto format as you type apply borders.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyBorders { get; set; }

  /// <summary>
  /// The auto format as you type apply bulleted lists.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyBulletedLists { get; set; }

  /// <summary>
  /// The auto format as you type apply numbered lists.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyNumberedLists { get; set; }

  /// <summary>
  /// The auto format as you type replace quotes.
  /// </summary>
  public bool AutoFormatAsYouTypeReplaceQuotes { get; set; }

  /// <summary>
  /// The auto format as you type replace symbols.
  /// </summary>
  public bool AutoFormatAsYouTypeReplaceSymbols { get; set; }

  /// <summary>
  /// The auto format as you type replace ordinals.
  /// </summary>
  public bool AutoFormatAsYouTypeReplaceOrdinals { get; set; }

  /// <summary>
  /// The auto format as you type replace fractions.
  /// </summary>
  public bool AutoFormatAsYouTypeReplaceFractions { get; set; }

  /// <summary>
  /// The auto format as you type replace plain text emphasis.
  /// </summary>
  public bool AutoFormatAsYouTypeReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// The auto format as you type format list item beginning.
  /// </summary>
  public bool AutoFormatAsYouTypeFormatListItemBeginning { get; set; }

  /// <summary>
  /// The auto format as you type define styles.
  /// </summary>
  public bool AutoFormatAsYouTypeDefineStyles { get; set; }

  /// <summary>
  /// The auto format as you type replace hyperlinks.
  /// </summary>
  public bool AutoFormatAsYouTypeReplaceHyperlinks { get; set; }

  /// <summary>
  /// The auto format as you type apply tables.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyTables { get; set; }

  /// <summary>
  /// The auto format as you type apply first indents.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyFirstIndents { get; set; }

  /// <summary>
  /// The auto format as you type apply dates.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyDates { get; set; }

  /// <summary>
  /// The auto format as you type apply closings.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyClosings { get; set; }

  /// <summary>
  /// The auto format as you type match parentheses.
  /// </summary>
  public bool AutoFormatAsYouTypeMatchParentheses { get; set; }

  /// <summary>
  /// The auto format as you type replace far east dashes.
  /// </summary>
  public bool AutoFormatAsYouTypeReplaceFarEastDashes { get; set; }

  /// <summary>
  /// The auto format as you type delete auto spaces.
  /// </summary>
  public bool AutoFormatAsYouTypeDeleteAutoSpaces { get; set; }

  /// <summary>
  /// The auto format as you type insert closings.
  /// </summary>
  public bool AutoFormatAsYouTypeInsertClosings { get; set; }

  /// <summary>
  /// The auto format as you type auto letter wizard.
  /// </summary>
  public bool AutoFormatAsYouTypeAutoLetterWizard { get; set; }

  /// <summary>
  /// The auto format as you type insert overs.
  /// </summary>
  public bool AutoFormatAsYouTypeInsertOvers { get; set; }

  /// <summary>
  /// The rely on css.
  /// </summary>
  public bool RelyOnCSS { get; set; }

  /// <summary>
  /// The htmlfidelity.
  /// </summary>
  public WdEmailHTMLFidelity HTMLFidelity { get; set; }

  /// <summary>
  /// The embed smart tag.
  /// </summary>
  public bool EmbedSmartTag { get; set; }

  /// <summary>
  /// The tab indent key.
  /// </summary>
  public bool TabIndentKey { get; set; }
}
