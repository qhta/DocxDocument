using DocumentModel.Wordprocessing;

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface Options : InteropObject
{
  /// <summary>
  /// True if accents are retained when a French language character is changed to uppercase.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowaccenteduppercase?view=word-pia"/>
  public bool AllowAccentedUppercase { get; set; }

  /// <summary>
  /// True if pressing Microsoft Word key combinations that produce actions in WordPerfect displays dialog boxes
  /// that describe how to perform the equivalent actions in Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.wphelp?view=word-pia"/>
  public bool WPHelp { get; set; }

  /// <summary>
  /// True to enable in Microsoft Word navigation keys for WordPerfect users.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.wpdocnavkeys?view=word-pia"/>
  public bool WPDocNavKeys { get; set; }

  /// <summary>
  /// True if Microsoft Word repaginates documents in the background.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pagination?view=word-pia"/>
  public bool Pagination { get; set; }

  /// <summary>
  /// True if Microsoft Word displays text as white characters on a blue background.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bluescreen?view=word-pia"/>
  public bool BlueScreen { get; set; }

  /// <summary>
  /// True if Microsoft Word makes the computer respond with a sound whenever an error occurs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablesound?view=word-pia"/>
  public bool EnableSound { get; set; }

  /// <summary>
  /// True if Microsoft Word displays the Convert File dialog box before it opens or inserts a file that isn't a
  /// Word document or template. In the Convert File dialog box, the user chooses the format to convert the file
  /// from.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.confirmconversions?view=word-pia"/>
  public bool ConfirmConversions { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically updates all embedded OLE links in a document when it's opened.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatelinksatopen?view=word-pia"/>
  public bool UpdateLinksAtOpen { get; set; }

  /// <summary>
  /// True if the Send To command on the File menu inserts the active document as an attachment to a mail message.
  /// False if the Send To command inserts the contents of the active document as text in a mail message.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.sendmailattach?view=word-pia"/>
  public bool SendMailAttach { get; set; }

  /// <summary>
  /// Returns or sets the standard measurement unit for Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.measurementunit?view=word-pia"/>
  public MeasurementUnits MeasurementUnit { get; set; }

  /// <summary>
  /// Returns or sets the number of clicks (either one or two) required to run a GOTOBUTTON or MACROBUTTON field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.buttonfieldclicks?view=word-pia"/>
  public int ButtonFieldClicks { get; set; }

  /// <summary>
  /// You have requested Help for a keyword used only on the Macintosh. For information about this keyword,
  /// consult the language reference Help included with Microsoft Office Macintosh Edition.
  /// </summary>
  /// <remarks>This option works only on the Macintosh.</remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.shortmenunames?view=word-pia"/>
  public bool ShortMenuNames { get; set; }

  /// <summary>
  /// You have requested Help for a keyword used only on the Macintosh. For information about this keyword,
  /// consult the language reference Help included with Microsoft Office Macintosh Edition.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.rtfinclipboard?view=word-pia"/>
  public bool RTFInClipboard { get; set; }

  /// <summary>
  /// True if Microsoft Word updates fields automatically before printing a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatefieldsatprint?view=word-pia"/>
  public bool UpdateFieldsAtPrint { get; set; }

  /// <summary>
  /// True if Microsoft Word prints document summary information on a separate page at the end of the document.
  /// False if document summary information is not printed. Summary information is found in the Properties dialog
  /// box (File menu).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printproperties?view=word-pia"/>
  public bool PrintProperties { get; set; }

  /// <summary>
  /// True if Microsoft Word prints field codes instead of field results.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printfieldcodes?view=word-pia"/>
  public bool PrintFieldCodes { get; set; }

  /// <summary>
  /// True if Microsoft Word prints comments, starting on a new page at the end of the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printcomments?view=word-pia"/>
  public bool PrintComments { get; set; }

  /// <summary>
  /// True if hidden text is printed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printhiddentext?view=word-pia"/>
  public bool PrintHiddenText { get; set; }

  /// <summary>
  /// True if the current printer has a special feeder for envelopes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.envelopefeederinstalled?view=word-pia"/>
  public bool EnvelopeFeederInstalled { get; }

  /// <summary>
  /// True if Microsoft Word updates embedded links to other files before printing a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatelinksatprint?view=word-pia"/>
  public bool UpdateLinksAtPrint { get; set; }

  /// <summary>
  /// True if Microsoft Word prints in the background.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printbackground?view=word-pia"/>
  public bool PrintBackground { get; set; }

  /// <summary>
  /// True if Microsoft Word prints drawing objects.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printdrawingobjects?view=word-pia"/>
  public bool PrintDrawingObjects { get; set; }

  /// <summary>
  /// Returns or sets the default tray your printer uses to print documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttray?view=word-pia"/>
  public string DefaultTray { get; set; }

  /// <summary>
  /// Returns or sets the default tray your printer uses to print documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttrayid?view=word-pia"/>
  public int DefaultTrayID { get; set; }

  /// <summary>
  /// True if Microsoft Word creates a backup copy each time a document is saved.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.createbackup?view=word-pia"/>
  public bool CreateBackup { get; set; }

  /// <summary>
  /// True if Microsoft Word saves only changes to a document. When reopening the document, Word uses the saved
  /// changes to reconstruct the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowfastsave?view=word-pia"/>
  public bool AllowFastSave { get; set; }

  /// <summary>
  /// True if Microsoft Word prompts for document property information when saving a new document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.savepropertiesprompt?view=word-pia"/>
  public bool SavePropertiesPrompt { get; set; }

  /// <summary>
  /// True if Microsoft Word prompts the user for confirmation to save changes to the Normal template before it
  /// quits. False if Word automatically saves changes to the Normal template before it quits.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.savenormalprompt?view=word-pia"/>
  public bool SaveNormalPrompt { get; set; }

  /// <summary>
  /// Returns or sets the time interval in minutes for saving AutoRecover information.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.saveinterval?view=word-pia"/>
  public int SaveInterval { get; set; }

  /// <summary>
  /// True if Microsoft Word saves documents in the background. When Word is saving in the background, users can
  /// continue to type and to choose commands.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.backgroundsave?view=word-pia"/>
  public bool BackgroundSave { get; set; }

  /// <summary>
  /// Returns or sets how Microsoft Word formats inserted text while change tracking is enabled (the
  /// TrackRevisions property is True).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedtextmark?view=word-pia"/>
  public InsertedTextMark InsertedTextMark { get; set; }

  /// <summary>
  /// Returns or sets the format of text that is deleted while change tracking is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedtextmark?view=word-pia"/>
  public DeletedTextMark DeletedTextMark { get; set; }

  /// <summary>
  /// Returns or sets the placement of changed lines in a document with tracked changes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedlinesmark?view=word-pia"/>
  public RevisedLinesMark RevisedLinesMark { get; set; }

  /// <summary>
  /// Returns or sets the color of text that is inserted while change tracking is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedtextcolor?view=word-pia"/>
  public ColorIndex InsertedTextColor { get; set; }

  /// <summary>
  /// Returns or sets the color of text that is deleted while change tracking is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedtextcolor?view=word-pia"/>
  public ColorIndex DeletedTextColor { get; set; }

  /// <summary>
  /// Returns or sets the color of changed lines in a document with tracked changes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedlinescolor?view=word-pia"/>
  public ColorIndex RevisedLinesColor { get; set; }

  /// <summary>
  /// True if Overtype mode is active.
  /// </summary>
  /// <remarks>
  /// In Overtype mode, the characters you type replace existing characters one by one.
  /// When Overtype isn't active, the characters you type move existing text to the right.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.overtype?view=word-pia"/>
  public bool Overtype { get; set; }

  /// <summary>
  /// True if the result of typing or pasting replaces the selection. False if the result of typing or pasting is
  /// added before the selection, leaving the selection intact.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.replaceselection?view=word-pia"/>
  public bool ReplaceSelection { get; set; }

  /// <summary>
  /// True if dragging and dropping can be used to move or copy a selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowdraganddrop?view=word-pia"/>
  public bool AllowDragAndDrop { get; set; }

  /// <summary>
  /// True if dragging selects one word at a time instead of one character at a time.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autowordselection?view=word-pia"/>
  public bool AutoWordSelection { get; set; }

  /// <summary>
  /// True if the INS key can be used for pasting the Clipboard contents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inskeyforpaste?view=word-pia"/>
  public bool INSKeyForPaste { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically adjusts the spacing between words and punctuation when cutting and
  /// pasting occurs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartcutpaste?view=word-pia"/>
  public bool SmartCutPaste { get; set; }

  /// <summary>
  /// True if the TAB and BACKSPACE keys can be used to increase and decrease, respectively, the left indent of
  /// paragraphs and if the BACKSPACE key can be used to change right-aligned paragraphs to centered paragraphs
  /// and centered paragraphs to left-aligned paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.tabindentkey?view=word-pia"/>
  public bool TabIndentKey { get; set; }

  /// <summary>
  /// Returns or sets the name of the application to use to edit pictures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pictureeditor?view=word-pia"/>
  public string PictureEditor { get; set; }

  /// <summary>
  /// True if Microsoft Word animates mouse movements, uses animated cursors, and animates actions such as
  /// background saving and find and replace operations.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.animatescreenmovements?view=word-pia"/>
  public bool AnimateScreenMovements { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.virusprotection?view=word-pia"/>
  public bool VirusProtection { get; set; }

  /// <summary>
  /// Returns or sets the mark used to show formatting changes while change tracking is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedpropertiesmark?view=word-pia"/>
  public RevisedPropertiesMark RevisedPropertiesMark { get; set; }

  /// <summary>
  /// Returns or sets the color used to mark formatting changes while change tracking is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedpropertiescolor?view=word-pia"/>
  public ColorIndex RevisedPropertiesColor { get; set; }

  /// <summary>
  /// True if AutoShapes or East Asian characters are automatically aligned with an invisible grid when they are
  /// drawn, moved, or resized in new documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.snaptogrid?view=word-pia"/>
  public bool SnapToGrid { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically aligns AutoShapes or East Asian characters with invisible gridlines
  /// that go through the vertical and horizontal edges of other AutoShapes or East Asian characters in new
  /// documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.snaptoshapes?view=word-pia"/>
  public bool SnapToShapes { get; set; }

  /// <summary>
  /// Returns or sets the amount of horizontal space between the invisible gridlines that Microsoft Word uses when
  /// you draw, move, and resize AutoShapes or East Asian characters in new documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.griddistancehorizontal?view=word-pia"/>
  public float GridDistanceHorizontal { get; set; }

  /// <summary>
  /// Returns or sets the amount of vertical space between the invisible gridlines that Microsoft Word uses when
  /// you draw, move, and resize AutoShapes or East Asian characters in new documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.griddistancevertical?view=word-pia"/>
  public float GridDistanceVertical { get; set; }

  /// <summary>
  /// Returns or sets the point, relative to the left edge of the page, where you want the invisible grid for
  /// drawing, moving, and resizing AutoShapes or East Asian characters to begin in new documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.gridoriginhorizontal?view=word-pia"/>
  public float GridOriginHorizontal { get; set; }

  /// <summary>
  /// Returns or sets the point, relative to the top of the page, where you want the invisible grid for drawing,
  /// moving, and resizing AutoShapes or East Asian characters to begin in new documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.gridoriginvertical?view=word-pia"/>
  public float GridOriginVertical { get; set; }

  /// <summary>
  /// True if Microsoft Word displays an unconfirmed character string in the Japanese Input Method Editor (IME) as
  /// an insertion between existing (confirmed) character strings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inlineconversion?view=word-pia"/>
  public bool InlineConversion { get; set; }

  /// <summary>
  /// True if Microsoft Word is set to automatically open and close the Japanese Input Method Editor (IME).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.imeautomaticcontrol?view=word-pia"/>
  public bool IMEAutomaticControl { get; set; }

  /// <summary>
  /// True if styles are automatically applied to headings when Word formats a document or range automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyheadings?view=word-pia"/>
  public bool AutoFormatApplyHeadings { get; set; }

  /// <summary>
  /// True if styles are automatically applied to lists when Microsoft Word formats a document or range
  /// automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplylists?view=word-pia"/>
  public bool AutoFormatApplyLists { get; set; }

  /// <summary>
  /// True if characters (such as asterisks, hyphens, and greater-than signs) at the beginning of list paragraphs
  /// are replaced with bullets from the Bullets and Numbering dialog box (Format menu) when Microsoft Word
  /// formats a document or range automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplybulletedlists?view=word-pia"/>
  public bool AutoFormatApplyBulletedLists { get; set; }

  /// <summary>
  /// True if styles are automatically applied to paragraphs that aren't headings or list items when Microsoft
  /// Word formats a document or range automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyotherparas?view=word-pia"/>
  public bool AutoFormatApplyOtherParas { get; set; }

  /// <summary>
  /// True if straight quotation marks are automatically changed to smart (curly) quotation marks when Microsoft
  /// Word formats a document or range automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacequotes?view=word-pia"/>
  public bool AutoFormatReplaceQuotes { get; set; }

  /// <summary>
  /// True if two consecutive hyphens (--) are replaced by an en dash (–) or an em dash (— ) when Microsoft Word
  /// formats a document or range automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacesymbols?view=word-pia"/>
  public bool AutoFormatReplaceSymbols { get; set; }

  /// <summary>
  /// True if the ordinal number suffixes "st", "nd", "rd", and "th" are replaced with the same letters in
  /// superscript when Word formats a document or range automatically. For example, "1st" is replaced with "1"
  /// followed by "st" formatted as superscript.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplaceordinals?view=word-pia"/>
  public bool AutoFormatReplaceOrdinals { get; set; }

  /// <summary>
  /// True if typed fractions are replaced with fractions from the current character set when Microsoft Word
  /// formats a document or range automatically. For example, "1/2" is replaced with "½."
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacefractions?view=word-pia"/>
  public bool AutoFormatReplaceFractions { get; set; }

  /// <summary>
  /// True if manual emphasis characters are replaced with character formatting when Microsoft Word formats a
  /// document or range automatically. For example, "bold" is changed to "bold" and "underline" is changed to
  /// "underline."
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplaceplaintextemphasis?view=word-pia"/>
  public bool AutoFormatReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// True if previously applied styles are preserved when Microsoft Word formats a document or range
  /// automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatpreservestyles?view=word-pia"/>
  public bool AutoFormatPreserveStyles { get; set; }

  /// <summary>
  /// True if styles are automatically applied to headings as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyheadings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyHeadings { get; set; }

  /// <summary>
  /// True if a series of three or more hyphens (-), equal signs (=), or underscore characters (_) are
  /// automatically replaced by a specific border line when the ENTER key is pressed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyborders?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBorders { get; set; }

  /// <summary>
  /// True if bullet characters (such as asterisks, hyphens, and greater-than signs) are replaced with bullets
  /// from the Bullets And Numbering dialog box (Format menu) as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplybulletedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBulletedLists { get; set; }

  /// <summary>
  /// True if paragraphs are automatically formatted as numbered lists with a numbering scheme from the Bullets
  /// and Numbering dialog box (Format menu), according to what's typed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplynumberedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyNumberedLists { get; set; }

  /// <summary>
  /// True if straight quotation marks are automatically changed to smart (curly) quotation marks as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacequotes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceQuotes { get; set; }

  /// <summary>
  /// True if two consecutive hyphens (--) are replaced with an en dash (–) or an em dash (— ) as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacesymbols?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceSymbols { get; set; }

  /// <summary>
  /// True if the ordinal number suffixes "st", "nd", "rd", and "th" are replaced with the same letters in
  /// superscript as you type. For example, "1st" is replaced with "1" followed by "st" formatted as superscript.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplaceordinals?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceOrdinals { get; set; }

  /// <summary>
  /// True if typed fractions are replaced with fractions from the current character set as you type. For example,
  /// "1/2" is replaced with "½."
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacefractions?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFractions { get; set; }

  /// <summary>
  /// True if manual emphasis characters are automatically replaced with character formatting as you type. For
  /// example, "bold" is changed to "bold" and "underline" is changed to "underline."
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplaceplaintextemphasis?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// True if Microsoft Word repeats character formatting applied to the beginning of a list item to the next list
  /// item.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeformatlistitembeginning?view=word-pia"/>
  public bool AutoFormatAsYouTypeFormatListItemBeginning { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically creates new styles based on manual formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypedefinestyles?view=word-pia"/>
  public bool AutoFormatAsYouTypeDefineStyles { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically formats plain-text e-mail messages when you open them in Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatplaintextwordmail?view=word-pia"/>
  public bool AutoFormatPlainTextWordMail { get; set; }

  /// <summary>
  /// True if e-mail addresses, server and share names (also known as UNC paths), and Internet addresses (also
  /// known as URLs) are automatically changed to hyperlinks as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacehyperlinks?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceHyperlinks { get; set; }

  /// <summary>
  /// True if e-mail addresses, server and share names (also known as UNC paths), and Internet addresses (also
  /// known as URLs) are automatically formatted whenever Microsoft Word AutoFormats a document or range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacehyperlinks?view=word-pia"/>
  public bool AutoFormatReplaceHyperlinks { get; set; }

  /// <summary>
  /// Returns or sets the color used to highlight text formatted with the Highlight button (Formatting toolbar).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulthighlightcolorindex?view=word-pia"/>
  public ColorIndex DefaultHighlightColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the default border line style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultborderlinestyle?view=word-pia"/>
  public LineStyle DefaultBorderLineStyle { get; set; }

  /// <summary>
  /// True if Microsoft Word checks spelling and marks errors automatically as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkspellingasyoutype?view=word-pia"/>
  public bool CheckSpellingAsYouType { get; set; }

  /// <summary>
  /// True if Microsoft Word checks grammar and marks errors automatically as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkgrammarasyoutype?view=word-pia"/>
  public bool CheckGrammarAsYouType { get; set; }

  /// <summary>
  /// True if file name extensions, MS-DOS paths, e-mail addresses, server and share names (also known as UNC
  /// paths), and Internet addresses (also known as URLs) are ignored while checking spelling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoreinternetandfileaddresses?view=word-pia"/>
  public bool IgnoreInternetAndFileAddresses { get; set; }

  /// <summary>
  /// True if Microsoft Word displays a list of summary statistics, including measures of readability, when it has
  /// finished checking grammar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showreadabilitystatistics?view=word-pia"/>
  public bool ShowReadabilityStatistics { get; set; }

  /// <summary>
  /// True if words in all uppercase letters are ignored while checking spelling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoreuppercase?view=word-pia"/>
  public bool IgnoreUppercase { get; set; }

  /// <summary>
  /// True if words that contain numbers are ignored while checking spelling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoremixeddigits?view=word-pia"/>
  public bool IgnoreMixedDigits { get; set; }

  /// <summary>
  /// True if Microsoft Word draws spelling suggestions from the main dictionary only. False if it draws spelling
  /// suggestions from the main dictionary and any custom dictionaries that have been added.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.suggestfrommaindictionaryonly?view=word-pia"/>
  public bool SuggestFromMainDictionaryOnly { get; set; }

  /// <summary>
  /// True if Microsoft Word always suggests alternative spellings for each misspelled word when checking
  /// spelling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.suggestspellingcorrections?view=word-pia"/>
  public bool SuggestSpellingCorrections { get; set; }

  /// <summary>
  /// Returns or sets the default line width of borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultborderlinewidth?view=word-pia"/>
  public LineWidth DefaultBorderLineWidth { get; set; }

  /// <summary>
  /// True if Microsoft Word checks grammar while checking spelling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkgrammarwithspelling?view=word-pia"/>
  public bool CheckGrammarWithSpelling { get; set; }

  /// <summary>
  /// Returns or sets the default file converter used to open documents. Can be a number returned by the
  /// OpenFormat property, or one of the OpenFormat constants.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultopenformat?view=word-pia"/>
  public OpenFormat DefaultOpenFormat { get; set; }

  /// <summary>
  /// True if Microsoft Word prints using minimal formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printdraft?view=word-pia"/>
  public bool PrintDraft { get; set; }

  /// <summary>
  /// True if Microsoft Word prints pages in reverse order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printreverse?view=word-pia"/>
  public bool PrintReverse { get; set; }

  /// <summary>
  /// True if documents formatted for another country's/region's standard paper size (for example, A4) are
  /// automatically adjusted so that they're printed correctly on your country's/region's standard paper size (for
  /// example, Letter).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.mappapersize?view=word-pia"/>
  public bool MapPaperSize { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically creates a table when you type a plus sign, a series of hyphens, another
  /// plus sign, and so on, and then press ENTER. The plus signs become the column borders, and the hyphens become
  /// the column widths.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplytables?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyTables { get; set; }

  /// <summary>
  /// True if Microsoft Word replaces a space entered at the beginning of a paragraph with a first- line indent
  /// when Word formats a document or range automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyfirstindents?view=word-pia"/>
  public bool AutoFormatApplyFirstIndents { get; set; }

  /// <summary>
  /// True if improperly paired parentheses are corrected when Microsoft Word formats a document or range
  /// automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatmatchparentheses?view=word-pia"/>
  public bool AutoFormatMatchParentheses { get; set; }

  /// <summary>
  /// True if long vowel sound and dash use is corrected when Microsoft Word formats a document or range
  /// automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacefareastdashes?view=word-pia"/>
  public bool AutoFormatReplaceFarEastDashes { get; set; }

  /// <summary>
  /// True if spaces inserted between Japanese and Latin text will be deleted when Microsoft Word formats a
  /// document or range automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatdeleteautospaces?view=word-pia"/>
  public bool AutoFormatDeleteAutoSpaces { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically replace a space entered at the beginning of a paragraph with a
  /// first-line indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyfirstindents?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyFirstIndents { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically apply the Date style to dates as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplydates?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyDates { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically apply the Closing style to letter closings as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyClosings { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically correct improperly paired parentheses.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypematchparentheses?view=word-pia"/>
  public bool AutoFormatAsYouTypeMatchParentheses { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically correct long vowel sounds and dashes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacefareastdashes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFarEastDashes { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically delete spaces inserted between Japanese and Latin text as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypedeleteautospaces?view=word-pia"/>
  public bool AutoFormatAsYouTypeDeleteAutoSpaces { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically insert the corresponding memo closing when the user enters a memo
  /// heading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeinsertclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertClosings { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically start the Letter Wizard when the user enters a letter salutation or
  /// closing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeautoletterwizard?view=word-pia"/>
  public bool AutoFormatAsYouTypeAutoLetterWizard { get; set; }

  /// <summary>
  /// True for Microsoft Word to automatically insert the "ijou" characters when the user enters the "ki" or "an"
  /// character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeinsertovers?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertOvers { get; set; }

  /// <summary>
  /// True if Microsoft Word displays the document grid. This property is the equivalent of the Gridlines command
  /// on the View menu.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaygridlines?view=word-pia"/>
  public bool DisplayGridLines { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between uppercase and lowercase letters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzycase?view=word-pia"/>
  public bool MatchFuzzyCase { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between full-width and half-width characters (Latin or
  /// Japanese) during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzybyte?view=word-pia"/>
  public bool MatchFuzzyByte { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between hiragana and katakana during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyhiragana?view=word-pia"/>
  public bool MatchFuzzyHiragana { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between diphthongs and double consonants during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzysmallkana?view=word-pia"/>
  public bool MatchFuzzySmallKana { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between minus signs, long vowel sounds, and dashes during a
  /// search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzydash?view=word-pia"/>
  public bool MatchFuzzyDash { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between types of repetition marks during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyiterationmark?view=word-pia"/>
  public bool MatchFuzzyIterationMark { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between standard and nonstandard kanji ideography during a
  /// search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzykanji?view=word-pia"/>
  public bool MatchFuzzyKanji { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between new kana and old kana characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyoldkana?view=word-pia"/>
  public bool MatchFuzzyOldKana { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between short and long vowel sounds during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyprolongedsoundmark?view=word-pia"/>
  public bool MatchFuzzyProlongedSoundMark { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between the "di" and "zi" characters and between the "du" and
  /// "zu" characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzydz?view=word-pia"/>
  public bool MatchFuzzyDZ { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between the "ba" and "vua" characters and between the "ha"
  /// and "fua" characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzybv?view=word-pia"/>
  public bool MatchFuzzyBV { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between the "tsui", "tei", and "chi" characters and between
  /// the "dei" and "ji" characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzytc?view=word-pia"/>
  public bool MatchFuzzyTC { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction the "heyu" and "fuyu" characters and between the "beyu" and
  /// "vuyu" characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyhf?view=word-pia"/>
  public bool MatchFuzzyHF { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction the "se" and "shie" characters and between the "ze" and "jie"
  /// characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyzj?view=word-pia"/>
  public bool MatchFuzzyZJ { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between the "a" and "ya" characters following the "i"-row and
  /// "e"-row characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyay?view=word-pia"/>
  public bool MatchFuzzyAY { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between the "ki" and "ku" characters before "sa"- row
  /// characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzykiku?view=word-pia"/>
  public bool MatchFuzzyKiKu { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between types of punctuation marks during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzypunctuation?view=word-pia"/>
  public bool MatchFuzzyPunctuation { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores the distinction between space markers used during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyspace?view=word-pia"/>
  public bool MatchFuzzySpace { get; set; }

  /// <summary>
  /// True if Microsoft Word applies East Asian fonts to Latin text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.applyfareastfontstoascii?view=word-pia"/>
  public bool ApplyFarEastFontsToAscii { get; set; }

  /// <summary>
  /// True if Microsoft Word converts text that is associated with an East Asian font to the appropriate font when
  /// it opens a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.converthighansitofareast?view=word-pia"/>
  public bool ConvertHighAnsiToFarEast { get; set; }

  /// <summary>
  /// True if Microsoft Word prints odd pages in ascending order during manual duplex printing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printoddpagesinascendingorder?view=word-pia"/>
  public bool PrintOddPagesInAscendingOrder { get; set; }

  /// <summary>
  /// True if Microsoft Word prints even pages in ascending order during manual duplex printing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printevenpagesinascendingorder?view=word-pia"/>
  public bool PrintEvenPagesInAscendingOrder { get; set; }

  /// <summary>
  /// Returns or sets the default line color for borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultbordercolorindex?view=word-pia"/>
  public ColorIndex DefaultBorderColorIndex { get; set; }

  /// <summary>
  /// True if Microsoft Word checks for misused words when checking the spelling and grammar in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablemisusedwordsdictionary?view=word-pia"/>
  public bool EnableMisusedWordsDictionary { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores auxiliary verb forms when checking spelling in a Korean language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowcombinedauxiliaryforms?view=word-pia"/>
  public bool AllowCombinedAuxiliaryForms { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically converts a word with only one suggestion during conversion between
  /// Hangul and Hanja.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.hangulhanjafastconversion?view=word-pia"/>
  public bool HangulHanjaFastConversion { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically detects Hangul endings and ignores them during conversion from Hangul
  /// to Hanja.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkhangulendings?view=word-pia"/>
  public bool CheckHangulEndings { get; set; }

  /// <summary>
  /// True if Microsoft Word displays the most recently used words at the top of the suggestions list during
  /// conversion between Hangul and Hanja.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablehangulhanjarecentordering?view=word-pia"/>
  public bool EnableHangulHanjaRecentOrdering { get; set; }

  /// <summary>
  /// Returns or sets the direction for conversion between Hangul and Hanja.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.multiplewordconversionsmode?view=word-pia"/>
  public MultipleWordConversionsMode MultipleWordConversionsMode { get; set; }

  /// <summary>
  /// Returns or sets the default 24-bit color to use for new Border objects. Can be any valid Color constant or
  /// a value returned by Visual Basic's RGB function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultbordercolor?view=word-pia"/>
  public Color DefaultBorderColor { get; set; }

  /// <summary>
  /// True if Microsoft Word uses pixels as the default unit of measurement for HTML features that support
  /// measurements.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowpixelunits?view=word-pia"/>
  public bool AllowPixelUnits { get; set; }

  /// <summary>
  /// True if Microsoft Word uses characters as the default measurement unit for the current document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usecharacterunit?view=word-pia"/>
  public bool UseCharacterUnit { get; set; }

  /// <summary>
  /// True if Microsoft Word ignores compound nouns when checking spelling in a Korean language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowcompoundnounprocessing?view=word-pia"/>
  public bool AllowCompoundNounProcessing { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically switches the keyboard language to match what you’re typing at any given
  /// time.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autokeyboardswitching?view=word-pia"/>
  public bool AutoKeyboardSwitching { get; set; }

  /// <summary>
  /// Returns or sets the alignment and reading order for the entire document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.documentviewdirection?view=word-pia"/>
  public DocumentViewDirection DocumentViewDirection { get; set; }

  /// <summary>
  /// Returns or sets the numeral style for an Arabic language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.arabicnumeral?view=word-pia"/>
  public ArabicNumeral ArabicNumeral { get; set; }

  /// <summary>
  /// Returns or sets the direction for conversion between Hangul and Hanja.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.monthnames?view=word-pia"/>
  public MonthNames MonthNames { get; set; }

  /// <summary>
  /// Returns or sets how the insertion point progresses within bidirectional text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.cursormovement?view=word-pia"/>
  public CursorMovement CursorMovement { get; set; }

  /// <summary>
  /// Returns or sets the selection behavior based on visual cursor movement in a right-to-left language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.visualselection?view=word-pia"/>
  public VisualSelection VisualSelection { get; set; }

  /// <summary>
  /// True if diacritics are visible in a right-to-left language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showdiacritics?view=word-pia"/>
  public bool ShowDiacritics { get; set; }

  /// <summary>
  /// True if bidirectional control characters are visible in the current document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showcontrolcharacters?view=word-pia"/>
  public bool ShowControlCharacters { get; set; }

  /// <summary>
  /// True if Microsoft Word adds bidirectional control characters when cutting and copying text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addcontrolcharacters?view=word-pia"/>
  public bool AddControlCharacters { get; set; }

  /// <summary>
  /// True if Microsoft Word adds bidirectional control characters when saving a document as a text file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addbidirectionalmarkswhensavingtextfile?view=word-pia"/>
  public bool AddBiDirectionalMarksWhenSavingTextFile { get; set; }

  /// <summary>
  /// True if the spelling checker uses spelling rules regarding Arabic words beginning with an alef hamza.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictinitialalefhamza?view=word-pia"/>
  public bool StrictInitialAlefHamza { get; set; }

  /// <summary>
  /// True if the spelling checker uses spelling rules regarding Arabic words ending with the letter yaa.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictfinalyaa?view=word-pia"/>
  public bool StrictFinalYaa { get; set; }

  /// <summary>
  /// Returns or sets the mode for the Hebrew spelling checker.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.hebrewmode?view=word-pia"/>
  public HebSpellStart HebrewMode { get; set; }

  /// <summary>
  /// Returns or sets the mode for the Arabic spelling checker.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.arabicmode?view=word-pia"/>
  public AraSpeller ArabicMode { get; set; }

  /// <summary>
  /// True if Click and Type functionality is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowclickandtypemouse?view=word-pia"/>
  public bool AllowClickAndTypeMouse { get; set; }

  /// <summary>
  /// True if Microsoft Word uses the German post-reform spelling rules when checking spelling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usegermanspellingreform?view=word-pia"/>
  public bool UseGermanSpellingReform { get; set; }

  /// <summary>
  /// Returns or sets the high-ANSI text interpretation behavior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.interprethighansi?view=word-pia"/>
  public HighAnsiText InterpretHighAnsi { get; set; }

  /// <summary>
  /// True if Microsoft Word encloses number formats in double quotation marks (").
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addhebdoublequote?view=word-pia"/>
  public bool AddHebDoubleQuote { get; set; }

  /// <summary>
  /// True if you can set the color of diacritics in the current document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usediffdiaccolor?view=word-pia"/>
  public bool UseDiffDiacColor { get; set; }

  /// <summary>
  /// Returns or sets the 24-bit color to be used for diacritics in a right-to-left language document. Can be any
  /// valid Color constant or a value returned by Visual Basic's RGB function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.diacriticcolorval?view=word-pia"/>
  public Color DiacriticColorVal { get; set; }

  /// <summary>
  /// True if Microsoft Word optimizes all new documents for viewing in Word 97 by disabling any incompatible
  /// formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.optimizeforword97bydefault?view=word-pia"/>
  public bool OptimizeForWord97byDefault { get; set; }

  /// <summary>
  /// True if Microsoft Word creates a local copy of a file on the user's machine when editing a file stored on a
  /// network server.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.localnetworkfile?view=word-pia"/>
  public bool LocalNetworkFile { get; set; }

  /// <summary>
  /// True for Microsoft Word to replace illegal South Asian characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.typenreplace?view=word-pia"/>
  public bool TypeNReplace { get; set; }

  /// <summary>
  /// True to check the sequence of independent characters for South Asian text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.sequencecheck?view=word-pia"/>
  public bool SequenceCheck { get; set; }

  /// <summary>
  /// True for Microsoft Word to open Web documents in the background.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.backgroundopen?view=word-pia"/>
  public bool BackgroundOpen { get; set; }

  /// <summary>
  /// True for Microsoft Word to disable in all documents all features introduced after the version of Word
  /// specified in the DisableFeaturesIntroducedAfterbyDefault property. The default value is False.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.disablefeaturesbydefault?view=word-pia"/>
  public bool DisableFeaturesbyDefault { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically adjusts the spacing of words when cutting and pasting selections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjustwordspacing?view=word-pia"/>
  public bool PasteAdjustWordSpacing { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically adjusts the spacing of paragraphs when cutting and pasting selections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjustparagraphspacing?view=word-pia"/>
  public bool PasteAdjustParagraphSpacing { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically adjusts the formatting of tables when cutting and pasting selections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjusttableformatting?view=word-pia"/>
  public bool PasteAdjustTableFormatting { get; set; }

  /// <summary>
  /// True if Microsoft Word intelligently merges styles when pasting a selection from a different document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastesmartstylebehavior?view=word-pia"/>
  public bool PasteSmartStyleBehavior { get; set; }

  /// <summary>
  /// True to merge text formatting when pasting from Microsoft PowerPoint.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergefromppt?view=word-pia"/>
  public bool PasteMergeFromPPT { get; set; }

  /// <summary>
  /// True to merge table formatting when pasting from Microsoft Excel.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergefromxl?view=word-pia"/>
  public bool PasteMergeFromXL { get; set; }

  /// <summary>
  /// True if Microsoft Word requires holding down the CTRL key while clicking to open a hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ctrlclickhyperlinktoopen?view=word-pia"/>
  public bool CtrlClickHyperlinkToOpen { get; set; }

  /// <summary>
  /// Sets or returns a WrapTypeMerged constant that indicates how Microsoft Word wraps text around pictures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.picturewraptype?view=word-pia"/>
  public WrapTypeMerged PictureWrapType { get; set; }

  /// <summary>
  /// Disables all features introduced after a specified version for all documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.disablefeaturesintroducedafterbydefault?view=word-pia"/>
  public DisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfterbyDefault { get; set; }

  /// <summary>
  /// True if Microsoft Word intelligently pastes selections into a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastesmartcutpaste?view=word-pia"/>
  public bool PasteSmartCutPaste { get; set; }

  /// <summary>
  /// True for Microsoft Word to display the Paste Options button, which displays directly under newly pasted
  /// text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaypasteoptions?view=word-pia"/>
  public bool DisplayPasteOptions { get; set; }

  /// <summary>
  /// True displays a message asking the user to verify whether they want to reformat a style or reapply the
  /// original style formatting when changing the formatting of styles. False reapplies the style formatting to
  /// the selection without verifying whether the user wants to change the style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.promptupdatestyle?view=word-pia"/>
  public bool PromptUpdateStyle { get; set; }

  /// <summary>
  /// Sets or returns a String that represents the path and file name of the default electronic postage
  /// application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultepostageapp?view=word-pia"/>
  public string DefaultEPostageApp { get; set; }

  /// <summary>
  /// Returns or sets a Encoding constant representing the code page, or character set, that Microsoft Word
  /// uses for all documents saved as encoded text files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttextencoding?view=word-pia"/>
  public Core.Encoding DefaultTextEncoding { get; set; }

  /// <summary>
  /// True for Microsoft Word to mark text in documents with smart tag information.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.labelsmarttags?view=word-pia"/>
  public bool LabelSmartTags { get; set; }

  /// <summary>
  /// True for Microsoft Word to display a button directly above a smart tag when a mouse pointer is positioned
  /// over it.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaysmarttagbuttons?view=word-pia"/>
  public bool DisplaySmartTagButtons { get; set; }

  /// <summary>
  /// True for Microsoft Word to display a warning when saving, printing, or sending as e-mail a document
  /// containing comments or tracked changes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.warnbeforesavingprintingsendingmarkup?view=word-pia"/>
  public bool WarnBeforeSavingPrintingSendingMarkup { get; set; }

  /// <summary>
  /// True for Microsoft Word to assign a random number to changes in a document, each time a document is saved,
  /// to facilitate comparing and merging documents. Word stores the random numbers in a table and updates the
  /// table after each save.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.storersidonsave?view=word-pia"/>
  public bool StoreRSIDOnSave { get; set; }

  /// <summary>
  /// True for Microsoft Word to mark inconsistencies in formatting by placing a squiggly underline beneath text
  /// formatted similarly to other formatting that is used more frequently in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showformaterror?view=word-pia"/>
  public bool ShowFormatError { get; set; }

  /// <summary>
  /// True for Microsoft Word to keep track of all formatting in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.formatscanning?view=word-pia"/>
  public bool FormatScanning { get; set; }

  /// <summary>
  /// True to merge the formatting of pasted lists with surrounding lists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergelists?view=word-pia"/>
  public bool PasteMergeLists { get; set; }

  /// <summary>
  /// True for Microsoft Word to draw newly created shapes in a drawing canvas.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autocreatenewdrawings?view=word-pia"/>
  public bool AutoCreateNewDrawings { get; set; }

  /// <summary>
  /// True for Microsoft Word to include the paragraph mark in a selection when selecting most or all of a
  /// paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartparaselection?view=word-pia"/>
  public bool SmartParaSelection { get; set; }

  /// <summary>
  /// Returns or sets a RevisionsBalloonPrintOrientation constant that represents the direction of revision and
  /// comment balloons when they are printed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisionsballoonprintorientation?view=word-pia"/>
  public RevisionsBalloonPrintOrientation RevisionsBalloonPrintOrientation { get; set; }

  /// <summary>
  /// Returns or sets a ColorIndex constant that represents the color of comments in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.commentscolor?view=word-pia"/>
  public ColorIndex CommentsColor { get; set; }

  /// <summary>
  /// Returns a Boolean that represents whether to print the XML tags when printing a document. Corresponds to the
  /// XML tags check box on the Print tab in the Options dialog box. True indicates that tags are printed. False
  /// indicates tags are not printed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printxmltag?view=word-pia"/>
  public bool PrintXMLTag { get; set; }

  /// <summary>
  /// Returns a Boolean that represents whether background colors and images are printed when a document is
  /// printed. True indicates that background colors and images are printed. False indicates that background
  /// colors and images are not printed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printbackgrounds?view=word-pia"/>
  public bool PrintBackgrounds { get; set; }

  /// <summary>
  /// True indicates that Microsoft Word opens documents in Reading Layout view. Corresponds to the Allow starting
  /// in Reading Layout check box on the General tab of the Options dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowreadingmode?view=word-pia"/>
  public bool AllowReadingMode { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Word displays hidden markup when opening or
  /// saving a file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showmarkupopensave?view=word-pia"/>
  public bool ShowMarkupOpenSave { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether smart cursoring is enabled. True enables smart cursoring.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartcursoring?view=word-pia"/>
  public bool SmartCursoring { get; set; }

  /// <summary>
  /// Returns or sets a MoveToTextMark constant that represents the type of revision mark to use for moved text.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movetotextmark?view=word-pia"/>
  public MoveToTextMark MoveToTextMark { get; set; }

  /// <summary>
  /// Returns or sets a MoveFromTextMark constant that represents the type of revision mark to use for moved
  /// text. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movefromtextmark?view=word-pia"/>
  public MoveFromTextMark MoveFromTextMark { get; set; }

  /// <summary>
  /// Returns or sets a String that represents the name of the style to use for formatting bibliographies.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bibliographystyle?view=word-pia"/>
  public string BibliographyStyle { get; set; }

  /// <summary>
  /// Returns or sets a String that represents the order in which to display sources in the Source Manager dialog
  /// box. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bibliographysort?view=word-pia"/>
  public string BibliographySort { get; set; }

  /// <summary>
  /// Returns or sets a CellColor constant that represents the color for an inserted table cell. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedcellcolor?view=word-pia"/>
  public CellColor InsertedCellColor { get; set; }

  /// <summary>
  /// Returns or sets a CellColor constant that represents the color for a deleted cell. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedcellcolor?view=word-pia"/>
  public CellColor DeletedCellColor { get; set; }

  /// <summary>
  /// Returns or sets a CellColor constant that represents the color for merged table cells. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.mergedcellcolor?view=word-pia"/>
  public CellColor MergedCellColor { get; set; }

  /// <summary>
  /// Returns or sets a CellColor that represents the color for split table cells. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.splitcellcolor?view=word-pia"/>
  public CellColor SplitCellColor { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether mini toolbars display when a user selects text.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showselectionfloaties?view=word-pia"/>
  public bool ShowSelectionFloaties { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to display mini toolbars when the user right- clicks in
  /// the document window. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showmenufloaties?view=word-pia"/>
  public bool ShowMenuFloaties { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether the Developer tab is displayed in the Ribbon. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showdevtools?view=word-pia"/>
  public bool ShowDevTools { get; set; }

  /// <summary>
  /// Sets or returns a Boolean that represents whether to show or hide gallery previews that appear when using
  /// galleries that support previewing. True shows a preview in your document before applying the command.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelivepreview?view=word-pia"/>
  public bool EnableLivePreview { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word automatically converts equations to
  /// professional format. True indicates that Word automatically converts equations to professional format.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.omathautobuildup?view=word-pia"/>
  public bool OMathAutoBuildUp { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.alwaysusecleartype?view=word-pia"/>
  public bool AlwaysUseClearType { get; set; }

  /// <summary>
  /// Returns or sets a PasteOptions constant that represents how text is pasted when text is copied or cut and
  /// then pasted in the same document. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatwithindocument?view=word-pia"/>
  public PasteOptions PasteFormatWithinDocument { get; set; }

  /// <summary>
  /// Returns or sets a PasteOptions constant that represents how text is pasted when text is copied from
  /// another Microsoft Office Word document. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatbetweendocuments?view=word-pia"/>
  public PasteOptions PasteFormatBetweenDocuments { get; set; }

  /// <summary>
  /// Returns or sets a PasteOptions constant that represents how text is pasted when text is copied from a
  /// document that uses styles. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatbetweenstyleddocuments?view=word-pia"/>
  public PasteOptions PasteFormatBetweenStyledDocuments { get; set; }

  /// <summary>
  /// Returns or sets a PasteOptions constant that represents how text is pasted when text is copied from an
  /// external source, such as a Web page. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatfromexternalsource?view=word-pia"/>
  public PasteOptions PasteFormatFromExternalSource { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to keep bullets and numbering when selecting Keep text
  /// only from the Paste Options context menu. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteoptionkeepbulletsandnumbers?view=word-pia"/>
  public bool PasteOptionKeepBulletsAndNumbers { get; set; }

  /// <summary>
  /// True if the INS key can be used for switching Overtype on and off. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inskeyforovertype?view=word-pia"/>
  public bool INSKeyForOvertype { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to mark words that are repeated when spelling is checked.
  /// True flags repeated words. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.repeatword?view=word-pia"/>
  public bool RepeatWord { get; set; }

  /// <summary>
  /// Returns or sets a FrenchSpeller constant that represents which spelling dictionary to use for regions of
  /// text with language formatting set to French. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.frenchreform?view=word-pia"/>
  public FrenchSpeller FrenchReform { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to use the contextual speller to check spelling based on
  /// the context of a word and the words around it. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.contextualspeller?view=word-pia"/>
  public bool ContextualSpeller { get; set; }

  /// <summary>
  /// Returns or sets a ColorIndex constant that represents the color of moved text. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movetotextcolor?view=word-pia"/>
  public ColorIndex MoveToTextColor { get; set; }

  /// <summary>
  /// Returns or sets a ColorIndex constant that represents the color of moved text. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movefromtextcolor?view=word-pia"/>
  public ColorIndex MoveFromTextColor { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents how equations are represented in plain text. True indicates
  /// equations are represented in Linear Format. False indicates equations are represented in MathML. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.omathcopylf?view=word-pia"/>
  public bool OMathCopyLF { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word uses the Normal style for bullets
  /// and numbering. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usenormalstyleforlist?view=word-pia"/>
  public bool UseNormalStyleForList { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to allow users to open documents in draft view.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowopenindraftview?view=word-pia"/>
  public bool AllowOpenInDraftView { get; set; }

  /// <summary>
  /// Returns or sets aBoolean that represents whether to enable legacy IME mode. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelegacyimemode?view=word-pia"/>
  public bool EnableLegacyIMEMode { get; set; }

  /// <summary>
  /// Sets or returns a Boolean that represents whether to prompt a warning dialog when the Convert command is
  /// invoked for documents that are in compatibility mode. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.donotpromptforconvert?view=word-pia"/>
  public bool DoNotPromptForConvert { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Word optimizes character positioning for print layout
  /// rather than on-screen readability. True disables the default setting that compresses character spacing to
  /// facilitate on-screen readability and enables character spacing for print media. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.precisepositioning?view=word-pia"/>
  public bool PrecisePositioning { get; set; }

  /// <summary>
  /// Gets or sets a UpdateStyleListBehavior constant that specifies the behavior Word 2010 should take when
  /// updating a style to match a selection that contains numbering or bullets.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatestylelistbehavior?view=word-pia"/>
  public UpdateStyleListBehavior UpdateStyleListBehavior { get; set; }

  /// <summary>
  /// Gets or sets whether the spelling checker uses spelling rules to flag Arabic words ending with haa instead
  /// of taa marboota.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.stricttaamarboota?view=word-pia"/>
  public bool StrictTaaMarboota { get; set; }

  /// <summary>
  /// Gets or sets whether the spelling checker uses spelling rules regarding Russian words that use the strict ë
  /// character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictrussiane?view=word-pia"/>
  public bool StrictRussianE { get; set; }

  /// <summary>
  /// Gets or sets the mode for the Spanish speller.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.spanishmode?view=word-pia"/>
  public SpanishSpeller SpanishMode { get; set; }

  /// <summary>
  /// Gets or sets the mode for the European Portuguese speller.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.portugalreform?view=word-pia"/>
  public PortugueseReform PortugalReform { get; set; }

  /// <summary>
  /// Gets or sets the mode for the Brazilian Portuguese speller.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.brazilreform?view=word-pia"/>
  public PortugueseReform BrazilReform { get; set; }

  /// <summary>
  /// Gets or sets whether Word 2010 allows fields containing tracked changes to update before printing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatefieldswithtrackedchangesatprint?view=word-pia"/>
  public bool UpdateFieldsWithTrackedChangesAtPrint { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that specifies whether alignment guides are enabled in the user
  /// interface. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displayalignmentguides?view=word-pia"/>
  public bool DisplayAlignmentGuides { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that specifies whether page alignment guides are displayed in the
  /// user interface. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pagealignmentguides?view=word-pia"/>
  public bool PageAlignmentGuides { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that specifies whether margin alignment guides are displayed in the
  /// user interface. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.marginalignmentguides?view=word-pia"/>
  public bool MarginAlignmentGuides { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that specifies whether paragraph alignment guides are displayed in
  /// the user interface. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.paragraphalignmentguides?view=word-pia"/>
  public bool ParagraphAlignmentGuides { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that is True if live drag is enabled. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelivedrag?view=word-pia"/>
  public bool EnableLiveDrag { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that specifies whether sub-pixel positioning is enabled. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usesubpixelpositioning?view=word-pia"/>
  public bool UseSubPixelPositioning { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that is True if users are notified if Word is not the default program
  /// for viewing and editing documents. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.alertifnotdefault?view=word-pia"/>
  public bool AlertIfNotDefault { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) value that, when True, specifies that users be notified when
  /// additional proofing tools are available for download. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enableproofingtoolsadvertisement?view=word-pia"/>
  public bool EnableProofingToolsAdvertisement { get; set; }

  /// <summary>
  /// True to save new documents in web locations by default. Read/write Boolean (bool in C#).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.prefercloudsavelocations?view=word-pia"/>
  public bool PreferCloudSaveLocations { get; set; }

  /// <summary>
  /// Returns or sets whether sky drive sign in option.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.skydrivesigninoption?view=word-pia"/>
  public bool SkyDriveSignInOption { get; set; }

  /// <summary>
  /// True to expand all headings in the document when the document opens. Read/write Boolean (bool in C#).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.expandheadingsonopen?view=word-pia"/>
  public bool ExpandHeadingsOnOpen { get; set; }

  /// <summary>
  /// Returns or sets a Boolean; True if Microsoft Word identifies the document author based upon the User name
  /// and Initials settings on the General tab of the Options dialog box, and False if Word identifies the author
  /// based on the account information with which the user signed in to Office. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.uselocaluserinfo?view=word-pia"/>
  public bool UseLocalUserInfo { get; set; }

  /// <summary>
  /// Returns or sets whether cloud sign in option.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.cloudsigninoption?view=word-pia"/>
  public bool CloudSignInOption { get; set; }
}
