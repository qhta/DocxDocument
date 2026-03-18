namespace DocumentModel.Interop;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
public partial interface Options : InteropObject
{
  /// <summary>
  /// The allow accented uppercase.
  /// </summary>
  public bool AllowAccentedUppercase { get; set; }

  /// <summary>
  /// The wphelp.
  /// </summary>
  public bool WPHelp { get; set; }

  /// <summary>
  /// The wpdoc nav keys.
  /// </summary>
  public bool WPDocNavKeys { get; set; }

  /// <summary>
  /// The pagination.
  /// </summary>
  public bool Pagination { get; set; }

  /// <summary>
  /// The blue screen.
  /// </summary>
  public bool BlueScreen { get; set; }

  /// <summary>
  /// The enable sound.
  /// </summary>
  public bool EnableSound { get; set; }

  /// <summary>
  /// The confirm conversions.
  /// </summary>
  public bool ConfirmConversions { get; set; }

  /// <summary>
  /// The update links at open.
  /// </summary>
  public bool UpdateLinksAtOpen { get; set; }

  /// <summary>
  /// The send mail attach.
  /// </summary>
  public bool SendMailAttach { get; set; }

  /// <summary>
  /// The measurement unit.
  /// </summary>
  public WdMeasurementUnits MeasurementUnit { get; set; }

  /// <summary>
  /// The button field clicks.
  /// </summary>
  public int ButtonFieldClicks { get; set; }

  /// <summary>
  /// The short menu names.
  /// </summary>
  public bool ShortMenuNames { get; set; }

  /// <summary>
  /// The rtfin clipboard.
  /// </summary>
  public bool RTFInClipboard { get; set; }

  /// <summary>
  /// The update fields at print.
  /// </summary>
  public bool UpdateFieldsAtPrint { get; set; }

  /// <summary>
  /// The print properties.
  /// </summary>
  public bool PrintProperties { get; set; }

  /// <summary>
  /// The print field codes.
  /// </summary>
  public bool PrintFieldCodes { get; set; }

  /// <summary>
  /// The print comments.
  /// </summary>
  public bool PrintComments { get; set; }

  /// <summary>
  /// The print hidden text.
  /// </summary>
  public bool PrintHiddenText { get; set; }

  /// <summary>
  /// The envelope feeder installed.
  /// </summary>
  public bool EnvelopeFeederInstalled { get; }

  /// <summary>
  /// The update links at print.
  /// </summary>
  public bool UpdateLinksAtPrint { get; set; }

  /// <summary>
  /// The print background.
  /// </summary>
  public bool PrintBackground { get; set; }

  /// <summary>
  /// The print drawing objects.
  /// </summary>
  public bool PrintDrawingObjects { get; set; }

  /// <summary>
  /// The default tray.
  /// </summary>
  public string DefaultTray { get; set; }

  /// <summary>
  /// The default tray id.
  /// </summary>
  public int DefaultTrayID { get; set; }

  /// <summary>
  /// The create backup.
  /// </summary>
  public bool CreateBackup { get; set; }

  /// <summary>
  /// The allow fast save.
  /// </summary>
  public bool AllowFastSave { get; set; }

  /// <summary>
  /// The save properties prompt.
  /// </summary>
  public bool SavePropertiesPrompt { get; set; }

  /// <summary>
  /// The save normal prompt.
  /// </summary>
  public bool SaveNormalPrompt { get; set; }

  /// <summary>
  /// The save interval.
  /// </summary>
  public int SaveInterval { get; set; }

  /// <summary>
  /// The background save.
  /// </summary>
  public bool BackgroundSave { get; set; }

  /// <summary>
  /// The inserted text mark.
  /// </summary>
  public WdInsertedTextMark InsertedTextMark { get; set; }

  /// <summary>
  /// The deleted text mark.
  /// </summary>
  public WdDeletedTextMark DeletedTextMark { get; set; }

  /// <summary>
  /// The revised lines mark.
  /// </summary>
  public WdRevisedLinesMark RevisedLinesMark { get; set; }

  /// <summary>
  /// The inserted text color.
  /// </summary>
  public WdColorIndex InsertedTextColor { get; set; }

  /// <summary>
  /// The deleted text color.
  /// </summary>
  public WdColorIndex DeletedTextColor { get; set; }

  /// <summary>
  /// The revised lines color.
  /// </summary>
  public WdColorIndex RevisedLinesColor { get; set; }

  /// <summary>
  /// The overtype.
  /// </summary>
  public bool Overtype { get; set; }

  /// <summary>
  /// The replace selection.
  /// </summary>
  public bool ReplaceSelection { get; set; }

  /// <summary>
  /// The allow drag and drop.
  /// </summary>
  public bool AllowDragAndDrop { get; set; }

  /// <summary>
  /// The auto word selection.
  /// </summary>
  public bool AutoWordSelection { get; set; }

  /// <summary>
  /// The inskey for paste.
  /// </summary>
  public bool INSKeyForPaste { get; set; }

  /// <summary>
  /// The smart cut paste.
  /// </summary>
  public bool SmartCutPaste { get; set; }

  /// <summary>
  /// The tab indent key.
  /// </summary>
  public bool TabIndentKey { get; set; }

  /// <summary>
  /// The picture editor.
  /// </summary>
  public string PictureEditor { get; set; }

  /// <summary>
  /// The animate screen movements.
  /// </summary>
  public bool AnimateScreenMovements { get; set; }

  /// <summary>
  /// The virus protection.
  /// </summary>
  public bool VirusProtection { get; set; }

  /// <summary>
  /// The revised properties mark.
  /// </summary>
  public WdRevisedPropertiesMark RevisedPropertiesMark { get; set; }

  /// <summary>
  /// The revised properties color.
  /// </summary>
  public WdColorIndex RevisedPropertiesColor { get; set; }

  /// <summary>
  /// The snap to grid.
  /// </summary>
  public bool SnapToGrid { get; set; }

  /// <summary>
  /// The snap to shapes.
  /// </summary>
  public bool SnapToShapes { get; set; }

  /// <summary>
  /// The grid distance horizontal.
  /// </summary>
  public float GridDistanceHorizontal { get; set; }

  /// <summary>
  /// The grid distance vertical.
  /// </summary>
  public float GridDistanceVertical { get; set; }

  /// <summary>
  /// The grid origin horizontal.
  /// </summary>
  public float GridOriginHorizontal { get; set; }

  /// <summary>
  /// The grid origin vertical.
  /// </summary>
  public float GridOriginVertical { get; set; }

  /// <summary>
  /// The inline conversion.
  /// </summary>
  public bool InlineConversion { get; set; }

  /// <summary>
  /// The imeautomatic control.
  /// </summary>
  public bool IMEAutomaticControl { get; set; }

  /// <summary>
  /// The auto format apply headings.
  /// </summary>
  public bool AutoFormatApplyHeadings { get; set; }

  /// <summary>
  /// The auto format apply lists.
  /// </summary>
  public bool AutoFormatApplyLists { get; set; }

  /// <summary>
  /// The auto format apply bulleted lists.
  /// </summary>
  public bool AutoFormatApplyBulletedLists { get; set; }

  /// <summary>
  /// The auto format apply other paras.
  /// </summary>
  public bool AutoFormatApplyOtherParas { get; set; }

  /// <summary>
  /// The auto format replace quotes.
  /// </summary>
  public bool AutoFormatReplaceQuotes { get; set; }

  /// <summary>
  /// The auto format replace symbols.
  /// </summary>
  public bool AutoFormatReplaceSymbols { get; set; }

  /// <summary>
  /// The auto format replace ordinals.
  /// </summary>
  public bool AutoFormatReplaceOrdinals { get; set; }

  /// <summary>
  /// The auto format replace fractions.
  /// </summary>
  public bool AutoFormatReplaceFractions { get; set; }

  /// <summary>
  /// The auto format replace plain text emphasis.
  /// </summary>
  public bool AutoFormatReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// The auto format preserve styles.
  /// </summary>
  public bool AutoFormatPreserveStyles { get; set; }

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
  /// The auto format plain text word mail.
  /// </summary>
  public bool AutoFormatPlainTextWordMail { get; set; }

  /// <summary>
  /// The auto format as you type replace hyperlinks.
  /// </summary>
  public bool AutoFormatAsYouTypeReplaceHyperlinks { get; set; }

  /// <summary>
  /// The auto format replace hyperlinks.
  /// </summary>
  public bool AutoFormatReplaceHyperlinks { get; set; }

  /// <summary>
  /// The default highlight color index.
  /// </summary>
  public WdColorIndex DefaultHighlightColorIndex { get; set; }

  /// <summary>
  /// The default border line style.
  /// </summary>
  public WdLineStyle DefaultBorderLineStyle { get; set; }

  /// <summary>
  /// The check spelling as you type.
  /// </summary>
  public bool CheckSpellingAsYouType { get; set; }

  /// <summary>
  /// The check grammar as you type.
  /// </summary>
  public bool CheckGrammarAsYouType { get; set; }

  /// <summary>
  /// The ignore internet and file addresses.
  /// </summary>
  public bool IgnoreInternetAndFileAddresses { get; set; }

  /// <summary>
  /// The show readability statistics.
  /// </summary>
  public bool ShowReadabilityStatistics { get; set; }

  /// <summary>
  /// The ignore uppercase.
  /// </summary>
  public bool IgnoreUppercase { get; set; }

  /// <summary>
  /// The ignore mixed digits.
  /// </summary>
  public bool IgnoreMixedDigits { get; set; }

  /// <summary>
  /// The suggest from main dictionary only.
  /// </summary>
  public bool SuggestFromMainDictionaryOnly { get; set; }

  /// <summary>
  /// The suggest spelling corrections.
  /// </summary>
  public bool SuggestSpellingCorrections { get; set; }

  /// <summary>
  /// The default border line width.
  /// </summary>
  public WdLineWidth DefaultBorderLineWidth { get; set; }

  /// <summary>
  /// The check grammar with spelling.
  /// </summary>
  public bool CheckGrammarWithSpelling { get; set; }

  /// <summary>
  /// The default open format.
  /// </summary>
  public WdOpenFormat DefaultOpenFormat { get; set; }

  /// <summary>
  /// The print draft.
  /// </summary>
  public bool PrintDraft { get; set; }

  /// <summary>
  /// The print reverse.
  /// </summary>
  public bool PrintReverse { get; set; }

  /// <summary>
  /// The map paper size.
  /// </summary>
  public bool MapPaperSize { get; set; }

  /// <summary>
  /// The auto format as you type apply tables.
  /// </summary>
  public bool AutoFormatAsYouTypeApplyTables { get; set; }

  /// <summary>
  /// The auto format apply first indents.
  /// </summary>
  public bool AutoFormatApplyFirstIndents { get; set; }

  /// <summary>
  /// The auto format match parentheses.
  /// </summary>
  public bool AutoFormatMatchParentheses { get; set; }

  /// <summary>
  /// The auto format replace far east dashes.
  /// </summary>
  public bool AutoFormatReplaceFarEastDashes { get; set; }

  /// <summary>
  /// The auto format delete auto spaces.
  /// </summary>
  public bool AutoFormatDeleteAutoSpaces { get; set; }

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
  /// The display grid lines.
  /// </summary>
  public bool DisplayGridLines { get; set; }

  /// <summary>
  /// The match fuzzy case.
  /// </summary>
  public bool MatchFuzzyCase { get; set; }

  /// <summary>
  /// The match fuzzy byte.
  /// </summary>
  public bool MatchFuzzyByte { get; set; }

  /// <summary>
  /// The match fuzzy hiragana.
  /// </summary>
  public bool MatchFuzzyHiragana { get; set; }

  /// <summary>
  /// The match fuzzy small kana.
  /// </summary>
  public bool MatchFuzzySmallKana { get; set; }

  /// <summary>
  /// The match fuzzy dash.
  /// </summary>
  public bool MatchFuzzyDash { get; set; }

  /// <summary>
  /// The match fuzzy iteration mark.
  /// </summary>
  public bool MatchFuzzyIterationMark { get; set; }

  /// <summary>
  /// The match fuzzy kanji.
  /// </summary>
  public bool MatchFuzzyKanji { get; set; }

  /// <summary>
  /// The match fuzzy old kana.
  /// </summary>
  public bool MatchFuzzyOldKana { get; set; }

  /// <summary>
  /// The match fuzzy prolonged sound mark.
  /// </summary>
  public bool MatchFuzzyProlongedSoundMark { get; set; }

  /// <summary>
  /// The match fuzzy dz.
  /// </summary>
  public bool MatchFuzzyDZ { get; set; }

  /// <summary>
  /// The match fuzzy bv.
  /// </summary>
  public bool MatchFuzzyBV { get; set; }

  /// <summary>
  /// The match fuzzy tc.
  /// </summary>
  public bool MatchFuzzyTC { get; set; }

  /// <summary>
  /// The match fuzzy hf.
  /// </summary>
  public bool MatchFuzzyHF { get; set; }

  /// <summary>
  /// The match fuzzy zj.
  /// </summary>
  public bool MatchFuzzyZJ { get; set; }

  /// <summary>
  /// The match fuzzy ay.
  /// </summary>
  public bool MatchFuzzyAY { get; set; }

  /// <summary>
  /// The match fuzzy ki ku.
  /// </summary>
  public bool MatchFuzzyKiKu { get; set; }

  /// <summary>
  /// The match fuzzy punctuation.
  /// </summary>
  public bool MatchFuzzyPunctuation { get; set; }

  /// <summary>
  /// The match fuzzy space.
  /// </summary>
  public bool MatchFuzzySpace { get; set; }

  /// <summary>
  /// The apply far east fonts to ascii.
  /// </summary>
  public bool ApplyFarEastFontsToAscii { get; set; }

  /// <summary>
  /// The convert high ansi to far east.
  /// </summary>
  public bool ConvertHighAnsiToFarEast { get; set; }

  /// <summary>
  /// The print odd pages in ascending order.
  /// </summary>
  public bool PrintOddPagesInAscendingOrder { get; set; }

  /// <summary>
  /// The print even pages in ascending order.
  /// </summary>
  public bool PrintEvenPagesInAscendingOrder { get; set; }

  /// <summary>
  /// The default border color index.
  /// </summary>
  public WdColorIndex DefaultBorderColorIndex { get; set; }

  /// <summary>
  /// The enable misused words dictionary.
  /// </summary>
  public bool EnableMisusedWordsDictionary { get; set; }

  /// <summary>
  /// The allow combined auxiliary forms.
  /// </summary>
  public bool AllowCombinedAuxiliaryForms { get; set; }

  /// <summary>
  /// The hangul hanja fast conversion.
  /// </summary>
  public bool HangulHanjaFastConversion { get; set; }

  /// <summary>
  /// The check hangul endings.
  /// </summary>
  public bool CheckHangulEndings { get; set; }

  /// <summary>
  /// The enable hangul hanja recent ordering.
  /// </summary>
  public bool EnableHangulHanjaRecentOrdering { get; set; }

  /// <summary>
  /// The multiple word conversions mode.
  /// </summary>
  public WdMultipleWordConversionsMode MultipleWordConversionsMode { get; set; }

  /// <summary>
  /// The default border color.
  /// </summary>
  public WdColor DefaultBorderColor { get; set; }

  /// <summary>
  /// The allow pixel units.
  /// </summary>
  public bool AllowPixelUnits { get; set; }

  /// <summary>
  /// The use character unit.
  /// </summary>
  public bool UseCharacterUnit { get; set; }

  /// <summary>
  /// The allow compound noun processing.
  /// </summary>
  public bool AllowCompoundNounProcessing { get; set; }

  /// <summary>
  /// The auto keyboard switching.
  /// </summary>
  public bool AutoKeyboardSwitching { get; set; }

  /// <summary>
  /// The document view direction.
  /// </summary>
  public WdDocumentViewDirection DocumentViewDirection { get; set; }

  /// <summary>
  /// The arabic numeral.
  /// </summary>
  public WdArabicNumeral ArabicNumeral { get; set; }

  /// <summary>
  /// The month names.
  /// </summary>
  public WdMonthNames MonthNames { get; set; }

  /// <summary>
  /// The cursor movement.
  /// </summary>
  public WdCursorMovement CursorMovement { get; set; }

  /// <summary>
  /// The visual selection.
  /// </summary>
  public WdVisualSelection VisualSelection { get; set; }

  /// <summary>
  /// The show diacritics.
  /// </summary>
  public bool ShowDiacritics { get; set; }

  /// <summary>
  /// The show control characters.
  /// </summary>
  public bool ShowControlCharacters { get; set; }

  /// <summary>
  /// The add control characters.
  /// </summary>
  public bool AddControlCharacters { get; set; }

  /// <summary>
  /// The add bi directional marks when saving text file.
  /// </summary>
  public bool AddBiDirectionalMarksWhenSavingTextFile { get; set; }

  /// <summary>
  /// The strict initial alef hamza.
  /// </summary>
  public bool StrictInitialAlefHamza { get; set; }

  /// <summary>
  /// The strict final yaa.
  /// </summary>
  public bool StrictFinalYaa { get; set; }

  /// <summary>
  /// The hebrew mode.
  /// </summary>
  public WdHebSpellStart HebrewMode { get; set; }

  /// <summary>
  /// The arabic mode.
  /// </summary>
  public WdAraSpeller ArabicMode { get; set; }

  /// <summary>
  /// The allow click and type mouse.
  /// </summary>
  public bool AllowClickAndTypeMouse { get; set; }

  /// <summary>
  /// The use german spelling reform.
  /// </summary>
  public bool UseGermanSpellingReform { get; set; }

  /// <summary>
  /// The interpret high ansi.
  /// </summary>
  public WdHighAnsiText InterpretHighAnsi { get; set; }

  /// <summary>
  /// The add heb double quote.
  /// </summary>
  public bool AddHebDoubleQuote { get; set; }

  /// <summary>
  /// The use diff diac color.
  /// </summary>
  public bool UseDiffDiacColor { get; set; }

  /// <summary>
  /// The diacritic color val.
  /// </summary>
  public WdColor DiacriticColorVal { get; set; }

  /// <summary>
  /// The optimize for word97by default.
  /// </summary>
  public bool OptimizeForWord97byDefault { get; set; }

  /// <summary>
  /// The local network file.
  /// </summary>
  public bool LocalNetworkFile { get; set; }

  /// <summary>
  /// The type nreplace.
  /// </summary>
  public bool TypeNReplace { get; set; }

  /// <summary>
  /// The sequence check.
  /// </summary>
  public bool SequenceCheck { get; set; }

  /// <summary>
  /// The background open.
  /// </summary>
  public bool BackgroundOpen { get; set; }

  /// <summary>
  /// The disable featuresby default.
  /// </summary>
  public bool DisableFeaturesbyDefault { get; set; }

  /// <summary>
  /// The paste adjust word spacing.
  /// </summary>
  public bool PasteAdjustWordSpacing { get; set; }

  /// <summary>
  /// The paste adjust paragraph spacing.
  /// </summary>
  public bool PasteAdjustParagraphSpacing { get; set; }

  /// <summary>
  /// The paste adjust table formatting.
  /// </summary>
  public bool PasteAdjustTableFormatting { get; set; }

  /// <summary>
  /// The paste smart style behavior.
  /// </summary>
  public bool PasteSmartStyleBehavior { get; set; }

  /// <summary>
  /// The paste merge from ppt.
  /// </summary>
  public bool PasteMergeFromPPT { get; set; }

  /// <summary>
  /// The paste merge from xl.
  /// </summary>
  public bool PasteMergeFromXL { get; set; }

  /// <summary>
  /// The ctrl click hyperlink to open.
  /// </summary>
  public bool CtrlClickHyperlinkToOpen { get; set; }

  /// <summary>
  /// The picture wrap type.
  /// </summary>
  public WdWrapTypeMerged PictureWrapType { get; set; }

  /// <summary>
  /// The disable features introduced afterby default.
  /// </summary>
  public WdDisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfterbyDefault { get; set; }

  /// <summary>
  /// The paste smart cut paste.
  /// </summary>
  public bool PasteSmartCutPaste { get; set; }

  /// <summary>
  /// The display paste options.
  /// </summary>
  public bool DisplayPasteOptions { get; set; }

  /// <summary>
  /// The prompt update style.
  /// </summary>
  public bool PromptUpdateStyle { get; set; }

  /// <summary>
  /// The default epostage app.
  /// </summary>
  public string DefaultEPostageApp { get; set; }

  /// <summary>
  /// The default text encoding.
  /// </summary>
  public Core.MsoEncoding DefaultTextEncoding { get; set; }

  /// <summary>
  /// The label smart tags.
  /// </summary>
  public bool LabelSmartTags { get; set; }

  /// <summary>
  /// The display smart tag buttons.
  /// </summary>
  public bool DisplaySmartTagButtons { get; set; }

  /// <summary>
  /// The warn before saving printing sending markup.
  /// </summary>
  public bool WarnBeforeSavingPrintingSendingMarkup { get; set; }

  /// <summary>
  /// The store rsidon save.
  /// </summary>
  public bool StoreRSIDOnSave { get; set; }

  /// <summary>
  /// The show format error.
  /// </summary>
  public bool ShowFormatError { get; set; }

  /// <summary>
  /// The format scanning.
  /// </summary>
  public bool FormatScanning { get; set; }

  /// <summary>
  /// The paste merge lists.
  /// </summary>
  public bool PasteMergeLists { get; set; }

  /// <summary>
  /// The auto create new drawings.
  /// </summary>
  public bool AutoCreateNewDrawings { get; set; }

  /// <summary>
  /// The smart para selection.
  /// </summary>
  public bool SmartParaSelection { get; set; }

  /// <summary>
  /// The revisions balloon print orientation.
  /// </summary>
  public WdRevisionsBalloonPrintOrientation RevisionsBalloonPrintOrientation { get; set; }

  /// <summary>
  /// The comments color.
  /// </summary>
  public WdColorIndex CommentsColor { get; set; }

  /// <summary>
  /// The print xmltag.
  /// </summary>
  public bool PrintXMLTag { get; set; }

  /// <summary>
  /// The print backgrounds.
  /// </summary>
  public bool PrintBackgrounds { get; set; }

  /// <summary>
  /// The allow reading mode.
  /// </summary>
  public bool AllowReadingMode { get; set; }

  /// <summary>
  /// The show markup open save.
  /// </summary>
  public bool ShowMarkupOpenSave { get; set; }

  /// <summary>
  /// The smart cursoring.
  /// </summary>
  public bool SmartCursoring { get; set; }

  /// <summary>
  /// The move to text mark.
  /// </summary>
  public WdMoveToTextMark MoveToTextMark { get; set; }

  /// <summary>
  /// The move from text mark.
  /// </summary>
  public WdMoveFromTextMark MoveFromTextMark { get; set; }

  /// <summary>
  /// The bibliography style.
  /// </summary>
  public string BibliographyStyle { get; set; }

  /// <summary>
  /// The bibliography sort.
  /// </summary>
  public string BibliographySort { get; set; }

  /// <summary>
  /// The inserted cell color.
  /// </summary>
  public WdCellColor InsertedCellColor { get; set; }

  /// <summary>
  /// The deleted cell color.
  /// </summary>
  public WdCellColor DeletedCellColor { get; set; }

  /// <summary>
  /// The merged cell color.
  /// </summary>
  public WdCellColor MergedCellColor { get; set; }

  /// <summary>
  /// The split cell color.
  /// </summary>
  public WdCellColor SplitCellColor { get; set; }

  /// <summary>
  /// The show selection floaties.
  /// </summary>
  public bool ShowSelectionFloaties { get; set; }

  /// <summary>
  /// The show menu floaties.
  /// </summary>
  public bool ShowMenuFloaties { get; set; }

  /// <summary>
  /// The show dev tools.
  /// </summary>
  public bool ShowDevTools { get; set; }

  /// <summary>
  /// The enable live preview.
  /// </summary>
  public bool EnableLivePreview { get; set; }

  /// <summary>
  /// The omath auto build up.
  /// </summary>
  public bool OMathAutoBuildUp { get; set; }

  /// <summary>
  /// The always use clear type.
  /// </summary>
  public bool AlwaysUseClearType { get; set; }

  /// <summary>
  /// The paste format within document.
  /// </summary>
  public WdPasteOptions PasteFormatWithinDocument { get; set; }

  /// <summary>
  /// The paste format between documents.
  /// </summary>
  public WdPasteOptions PasteFormatBetweenDocuments { get; set; }

  /// <summary>
  /// The paste format between styled documents.
  /// </summary>
  public WdPasteOptions PasteFormatBetweenStyledDocuments { get; set; }

  /// <summary>
  /// The paste format from external source.
  /// </summary>
  public WdPasteOptions PasteFormatFromExternalSource { get; set; }

  /// <summary>
  /// The paste option keep bullets and numbers.
  /// </summary>
  public bool PasteOptionKeepBulletsAndNumbers { get; set; }

  /// <summary>
  /// The inskey for overtype.
  /// </summary>
  public bool INSKeyForOvertype { get; set; }

  /// <summary>
  /// The repeat word.
  /// </summary>
  public bool RepeatWord { get; set; }

  /// <summary>
  /// The french reform.
  /// </summary>
  public WdFrenchSpeller FrenchReform { get; set; }

  /// <summary>
  /// The contextual speller.
  /// </summary>
  public bool ContextualSpeller { get; set; }

  /// <summary>
  /// The move to text color.
  /// </summary>
  public WdColorIndex MoveToTextColor { get; set; }

  /// <summary>
  /// The move from text color.
  /// </summary>
  public WdColorIndex MoveFromTextColor { get; set; }

  /// <summary>
  /// The omath copy lf.
  /// </summary>
  public bool OMathCopyLF { get; set; }

  /// <summary>
  /// The use normal style for list.
  /// </summary>
  public bool UseNormalStyleForList { get; set; }

  /// <summary>
  /// The allow open in draft view.
  /// </summary>
  public bool AllowOpenInDraftView { get; set; }

  /// <summary>
  /// The enable legacy imemode.
  /// </summary>
  public bool EnableLegacyIMEMode { get; set; }

  /// <summary>
  /// The do not prompt for convert.
  /// </summary>
  public bool DoNotPromptForConvert { get; set; }

  /// <summary>
  /// The precise positioning.
  /// </summary>
  public bool PrecisePositioning { get; set; }

  /// <summary>
  /// The update style list behavior.
  /// </summary>
  public WdUpdateStyleListBehavior UpdateStyleListBehavior { get; set; }

  /// <summary>
  /// The strict taa marboota.
  /// </summary>
  public bool StrictTaaMarboota { get; set; }

  /// <summary>
  /// The strict russian e.
  /// </summary>
  public bool StrictRussianE { get; set; }

  /// <summary>
  /// The spanish mode.
  /// </summary>
  public WdSpanishSpeller SpanishMode { get; set; }

  /// <summary>
  /// The portugal reform.
  /// </summary>
  public WdPortugueseReform PortugalReform { get; set; }

  /// <summary>
  /// The brazil reform.
  /// </summary>
  public WdPortugueseReform BrazilReform { get; set; }

  /// <summary>
  /// The update fields with tracked changes at print.
  /// </summary>
  public bool UpdateFieldsWithTrackedChangesAtPrint { get; set; }

  /// <summary>
  /// The display alignment guides.
  /// </summary>
  public bool DisplayAlignmentGuides { get; set; }

  /// <summary>
  /// The page alignment guides.
  /// </summary>
  public bool PageAlignmentGuides { get; set; }

  /// <summary>
  /// The margin alignment guides.
  /// </summary>
  public bool MarginAlignmentGuides { get; set; }

  /// <summary>
  /// The paragraph alignment guides.
  /// </summary>
  public bool ParagraphAlignmentGuides { get; set; }

  /// <summary>
  /// The enable live drag.
  /// </summary>
  public bool EnableLiveDrag { get; set; }

  /// <summary>
  /// The use sub pixel positioning.
  /// </summary>
  public bool UseSubPixelPositioning { get; set; }

  /// <summary>
  /// The alert if not default.
  /// </summary>
  public bool AlertIfNotDefault { get; set; }

  /// <summary>
  /// The enable proofing tools advertisement.
  /// </summary>
  public bool EnableProofingToolsAdvertisement { get; set; }

  /// <summary>
  /// The prefer cloud save locations.
  /// </summary>
  public bool PreferCloudSaveLocations { get; set; }

  /// <summary>
  /// The sky drive sign in option.
  /// </summary>
  public bool SkyDriveSignInOption { get; set; }

  /// <summary>
  /// The expand headings on open.
  /// </summary>
  public bool ExpandHeadingsOnOpen { get; set; }

  /// <summary>
  /// The use local user info.
  /// </summary>
  public bool UseLocalUserInfo { get; set; }

  /// <summary>
  /// The cloud sign in option.
  /// </summary>
  public bool CloudSignInOption { get; set; }
}
