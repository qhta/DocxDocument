using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface IOptions : IModelObject
{

  /// <summary>
  /// True if Microsoft Word automatically creates a table when you type a plus sign, a series of hyphens, another
  /// plus sign, and so on, and then press ENTER. The plus signs become the column borders, and the hyphens become
  /// the column widths.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplytables?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeApplyTables { get; set; }

  /// <summary>
  /// True if Microsoft Word replaces a space entered at the beginning of a paragraph with a first- line indent
  /// when Word formats a document or range automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyfirstindents?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatApplyFirstIndents { get; set; }

  /// <summary>
  /// True if improperly paired parentheses are corrected when Microsoft Word formats a document or range
  /// automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatmatchparentheses?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatMatchParentheses { get; set; }

  /// <summary>
  /// True if long vowel sound and dash use is corrected when Microsoft Word formats a document or range
  /// automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacefareastdashes?view=word-pia"/>
  [MultiCategory("Auto format")]
  [MultiCategory("East Asian")]
  public bool? AutoFormatReplaceFarEastDashes { get; set; }

  /// <summary>
  /// True if spaces inserted between Japanese and Latin text will be deleted when Microsoft Word formats a
  /// document or range automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatdeleteautospaces?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatDeleteAutoSpaces { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically replace a space entered at the beginning of a paragraph with a
  /// first-line indent.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyfirstindents?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeApplyFirstIndents { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically apply the Date style to dates as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplydates?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeApplyDates { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically apply the Closing style to letter closings as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyclosings?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeApplyClosings { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically correct improperly paired parentheses.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypematchparentheses?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeMatchParentheses { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically correct long vowel sounds and dashes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacefareastdashes?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeReplaceFarEastDashes { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically delete spaces inserted between Japanese and Latin text as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypedeleteautospaces?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeDeleteAutoSpaces { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically insert the corresponding memo closing when the user enters a memo
  /// heading.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeinsertclosings?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeInsertClosings { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically start the Letter Wizard when the user enters a letter salutation or
  /// closing.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeautoletterwizard?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeAutoLetterWizard { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically insert the "ijou" characters when the user enters the "ki" or "an"
  /// character.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeinsertovers?view=word-pia"/>
  [MultiCategory("Auto format")]
  [MultiCategory("East Asian")]
  public bool? AutoFormatAsYouTypeInsertOvers { get; set; }

  /// <summary>
  /// True if styles are automatically applied to headings when Word formats a document or range automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyheadings?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatApplyHeadings { get; set; }

  /// <summary>
  /// True if styles are automatically applied to lists when Microsoft Word formats a document or range
  /// automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplylists?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatApplyLists { get; set; }

  /// <summary>
  /// True if characters (such as asterisks, hyphens, and greater-than signs) at the beginning of list paragraphs
  /// are replaced with bullets from the Bullets and Numbering dialog box (Format menu) when Microsoft Word
  /// formats a document or range automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplybulletedlists?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatApplyBulletedLists { get; set; }

  /// <summary>
  /// True if styles are automatically applied to paragraphs that aren't headings or list items when Microsoft
  /// Word formats a document or range automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyotherparas?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatApplyOtherParas { get; set; }

  /// <summary>
  /// True if straight quotation marks are automatically changed to smart (curly) quotation marks when Microsoft
  /// Word formats a document or range automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacequotes?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatReplaceQuotes { get; set; }

  /// <summary>
  /// True if two consecutive hyphens (--) are replaced by an en dash (–) or an em dash (— ) when Microsoft Word
  /// formats a document or range automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacesymbols?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatReplaceSymbols { get; set; }

  /// <summary>
  /// True if the ordinal number suffixes "st", "nd", "rd", and "th" are replaced with the same letters in
  /// superscript when Word formats a document or range automatically. For example, "1st" is replaced with "1"
  /// followed by "st" formatted as superscript.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplaceordinals?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatReplaceOrdinals { get; set; }

  /// <summary>
  /// True if typed fractions are replaced with fractions from the current character set when Microsoft Word
  /// formats a document or range automatically. For example, "1/2" is replaced with "½."
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacefractions?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatReplaceFractions { get; set; }

  /// <summary>
  /// True if manual emphasis characters are replaced with character formatting when Microsoft Word formats a
  /// document or range automatically. For example, "bold" is changed to "bold" and "underline" is changed to
  /// "underline."
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplaceplaintextemphasis?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// True if previously applied styles are preserved when Microsoft Word formats a document or range
  /// automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatpreservestyles?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatPreserveStyles { get; set; }

  /// <summary>
  /// True if styles are automatically applied to headings as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyheadings?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeApplyHeadings { get; set; }

  /// <summary>
  /// True if a series of three or more hyphens (-), equal signs (=), or underscore characters (_) are
  /// automatically replaced by a specific border line when the ENTER key is pressed.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyborders?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeApplyBorders { get; set; }

  /// <summary>
  /// True if bullet characters (such as asterisks, hyphens, and greater-than signs) are replaced with bullets
  /// from the Bullets And Numbering dialog box (Format menu) as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplybulletedlists?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeApplyBulletedLists { get; set; }

  /// <summary>
  /// True if paragraphs are automatically formatted as numbered lists with a numbering scheme from the Bullets
  /// and Numbering dialog box (Format menu), according to what's typed.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplynumberedlists?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeApplyNumberedLists { get; set; }

  /// <summary>
  /// True if straight quotation marks are automatically changed to smart (curly) quotation marks as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacequotes?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeReplaceQuotes { get; set; }

  /// <summary>
  /// True if two consecutive hyphens (--) are replaced with an en dash (–) or an em dash (— ) as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacesymbols?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeReplaceSymbols { get; set; }

  /// <summary>
  /// True if the ordinal number suffixes "st", "nd", "rd", and "th" are replaced with the same letters in
  /// superscript as you type. For example, "1st" is replaced with "1" followed by "st" formatted as superscript.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplaceordinals?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeReplaceOrdinals { get; set; }

  /// <summary>
  /// True if typed fractions are replaced with fractions from the current character set as you type. For example,
  /// "1/2" is replaced with "½."
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacefractions?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeReplaceFractions { get; set; }

  /// <summary>
  /// True if manual emphasis characters are automatically replaced with character formatting as you type. For
  /// example, "bold" is changed to "bold" and "underline" is changed to "underline."
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplaceplaintextemphasis?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// True if Microsoft Word repeats character formatting applied to the beginning of a list item to the next list
  /// item.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeformatlistitembeginning?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeFormatListItemBeginning { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically creates new styles based on manual formatting.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypedefinestyles?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeDefineStyles { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically formats plain-text e-mail messages when you open them in Word.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatplaintextwordmail?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatPlainTextWordMail { get; set; }

  /// <summary>
  /// True if e-mail addresses, server and share names (also known as UNC paths), and Internet addresses (also
  /// known as URLs) are automatically changed to hyperlinks as you type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacehyperlinks?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatAsYouTypeReplaceHyperlinks { get; set; }

  /// <summary>
  /// True if e-mail addresses, server and share names (also known as UNC paths), and Internet addresses (also
  /// known as URLs) are automatically formatted whenever Microsoft Word AutoFormats a document or range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacehyperlinks?view=word-pia"/>
  [MultiCategory("Auto format")]
  public bool? AutoFormatReplaceHyperlinks { get; set; }
}
