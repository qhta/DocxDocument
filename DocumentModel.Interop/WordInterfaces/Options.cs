namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface Options : InteropObject
{
  /// <summary>
  /// Returns or sets whether allow accented uppercase.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowaccenteduppercase?view=word-pia"/>
  public bool AllowAccentedUppercase { get; set; }

  /// <summary>
  /// Returns or sets whether w p help.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.wphelp?view=word-pia"/>
  public bool WPHelp { get; set; }

  /// <summary>
  /// Returns or sets whether w p doc nav keys.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.wpdocnavkeys?view=word-pia"/>
  public bool WPDocNavKeys { get; set; }

  /// <summary>
  /// Returns or sets whether pagination.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pagination?view=word-pia"/>
  public bool Pagination { get; set; }

  /// <summary>
  /// Returns or sets whether blue screen.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bluescreen?view=word-pia"/>
  public bool BlueScreen { get; set; }

  /// <summary>
  /// Returns or sets whether enable sound.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablesound?view=word-pia"/>
  public bool EnableSound { get; set; }

  /// <summary>
  /// Returns or sets whether confirm conversions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.confirmconversions?view=word-pia"/>
  public bool ConfirmConversions { get; set; }

  /// <summary>
  /// Returns or sets whether update links at open.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatelinksatopen?view=word-pia"/>
  public bool UpdateLinksAtOpen { get; set; }

  /// <summary>
  /// Returns or sets whether send mail attach.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.sendmailattach?view=word-pia"/>
  public bool SendMailAttach { get; set; }

  /// <summary>
  /// Returns or sets the measurement unit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.measurementunit?view=word-pia"/>
  public WdMeasurementUnits MeasurementUnit { get; set; }

  /// <summary>
  /// Returns or sets the button field clicks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.buttonfieldclicks?view=word-pia"/>
  public int ButtonFieldClicks { get; set; }

  /// <summary>
  /// Returns or sets whether short menu names.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.shortmenunames?view=word-pia"/>
  public bool ShortMenuNames { get; set; }

  /// <summary>
  /// Returns or sets whether r t f in clipboard.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.rtfinclipboard?view=word-pia"/>
  public bool RTFInClipboard { get; set; }

  /// <summary>
  /// Returns or sets whether update fields at print.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatefieldsatprint?view=word-pia"/>
  public bool UpdateFieldsAtPrint { get; set; }

  /// <summary>
  /// Returns or sets whether print properties.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printproperties?view=word-pia"/>
  public bool PrintProperties { get; set; }

  /// <summary>
  /// Returns or sets whether print field codes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printfieldcodes?view=word-pia"/>
  public bool PrintFieldCodes { get; set; }

  /// <summary>
  /// Returns or sets whether print comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printcomments?view=word-pia"/>
  public bool PrintComments { get; set; }

  /// <summary>
  /// Returns or sets whether print hidden text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printhiddentext?view=word-pia"/>
  public bool PrintHiddenText { get; set; }

  /// <summary>
  /// Returns whether envelope feeder installed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.envelopefeederinstalled?view=word-pia"/>
  public bool EnvelopeFeederInstalled { get; }

  /// <summary>
  /// Returns or sets whether update links at print.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatelinksatprint?view=word-pia"/>
  public bool UpdateLinksAtPrint { get; set; }

  /// <summary>
  /// Returns or sets whether print background.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printbackground?view=word-pia"/>
  public bool PrintBackground { get; set; }

  /// <summary>
  /// Returns or sets whether print drawing objects.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printdrawingobjects?view=word-pia"/>
  public bool PrintDrawingObjects { get; set; }

  /// <summary>
  /// Returns or sets the default tray.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttray?view=word-pia"/>
  public string DefaultTray { get; set; }

  /// <summary>
  /// Returns or sets the default tray i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttrayid?view=word-pia"/>
  public int DefaultTrayID { get; set; }

  /// <summary>
  /// Returns or sets whether create backup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.createbackup?view=word-pia"/>
  public bool CreateBackup { get; set; }

  /// <summary>
  /// Returns or sets whether allow fast save.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowfastsave?view=word-pia"/>
  public bool AllowFastSave { get; set; }

  /// <summary>
  /// Returns or sets whether save properties prompt.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.savepropertiesprompt?view=word-pia"/>
  public bool SavePropertiesPrompt { get; set; }

  /// <summary>
  /// Returns or sets whether save normal prompt.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.savenormalprompt?view=word-pia"/>
  public bool SaveNormalPrompt { get; set; }

  /// <summary>
  /// Returns or sets the save interval.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.saveinterval?view=word-pia"/>
  public int SaveInterval { get; set; }

  /// <summary>
  /// Returns or sets whether background save.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.backgroundsave?view=word-pia"/>
  public bool BackgroundSave { get; set; }

  /// <summary>
  /// Returns or sets the inserted text mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedtextmark?view=word-pia"/>
  public WdInsertedTextMark InsertedTextMark { get; set; }

  /// <summary>
  /// Returns or sets the deleted text mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedtextmark?view=word-pia"/>
  public WdDeletedTextMark DeletedTextMark { get; set; }

  /// <summary>
  /// Returns or sets the revised lines mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedlinesmark?view=word-pia"/>
  public WdRevisedLinesMark RevisedLinesMark { get; set; }

  /// <summary>
  /// Returns or sets the inserted text color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedtextcolor?view=word-pia"/>
  public WdColorIndex InsertedTextColor { get; set; }

  /// <summary>
  /// Returns or sets the deleted text color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedtextcolor?view=word-pia"/>
  public WdColorIndex DeletedTextColor { get; set; }

  /// <summary>
  /// Returns or sets the revised lines color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedlinescolor?view=word-pia"/>
  public WdColorIndex RevisedLinesColor { get; set; }

  /// <summary>
  /// Returns or sets whether overtype.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.overtype?view=word-pia"/>
  public bool Overtype { get; set; }

  /// <summary>
  /// Returns or sets whether replace selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.replaceselection?view=word-pia"/>
  public bool ReplaceSelection { get; set; }

  /// <summary>
  /// Returns or sets whether allow drag and drop.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowdraganddrop?view=word-pia"/>
  public bool AllowDragAndDrop { get; set; }

  /// <summary>
  /// Returns or sets whether auto word selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autowordselection?view=word-pia"/>
  public bool AutoWordSelection { get; set; }

  /// <summary>
  /// Returns or sets whether i n s key for paste.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inskeyforpaste?view=word-pia"/>
  public bool INSKeyForPaste { get; set; }

  /// <summary>
  /// Returns or sets whether smart cut paste.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartcutpaste?view=word-pia"/>
  public bool SmartCutPaste { get; set; }

  /// <summary>
  /// Returns or sets whether tab indent key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.tabindentkey?view=word-pia"/>
  public bool TabIndentKey { get; set; }

  /// <summary>
  /// Returns or sets the picture editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pictureeditor?view=word-pia"/>
  public string PictureEditor { get; set; }

  /// <summary>
  /// Returns or sets whether animate screen movements.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.animatescreenmovements?view=word-pia"/>
  public bool AnimateScreenMovements { get; set; }

  /// <summary>
  /// Returns or sets whether virus protection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.virusprotection?view=word-pia"/>
  public bool VirusProtection { get; set; }

  /// <summary>
  /// Returns or sets the revised properties mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedpropertiesmark?view=word-pia"/>
  public WdRevisedPropertiesMark RevisedPropertiesMark { get; set; }

  /// <summary>
  /// Returns or sets the revised properties color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedpropertiescolor?view=word-pia"/>
  public WdColorIndex RevisedPropertiesColor { get; set; }

  /// <summary>
  /// Returns or sets whether snap to grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.snaptogrid?view=word-pia"/>
  public bool SnapToGrid { get; set; }

  /// <summary>
  /// Returns or sets whether snap to shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.snaptoshapes?view=word-pia"/>
  public bool SnapToShapes { get; set; }

  /// <summary>
  /// Returns or sets the grid distance horizontal.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.griddistancehorizontal?view=word-pia"/>
  public float GridDistanceHorizontal { get; set; }

  /// <summary>
  /// Returns or sets the grid distance vertical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.griddistancevertical?view=word-pia"/>
  public float GridDistanceVertical { get; set; }

  /// <summary>
  /// Returns or sets the grid origin horizontal.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.gridoriginhorizontal?view=word-pia"/>
  public float GridOriginHorizontal { get; set; }

  /// <summary>
  /// Returns or sets the grid origin vertical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.gridoriginvertical?view=word-pia"/>
  public float GridOriginVertical { get; set; }

  /// <summary>
  /// Returns or sets whether inline conversion.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inlineconversion?view=word-pia"/>
  public bool InlineConversion { get; set; }

  /// <summary>
  /// Returns or sets whether i m e automatic control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.imeautomaticcontrol?view=word-pia"/>
  public bool IMEAutomaticControl { get; set; }

  /// <summary>
  /// Returns or sets whether auto format apply headings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyheadings?view=word-pia"/>
  public bool AutoFormatApplyHeadings { get; set; }

  /// <summary>
  /// Returns or sets whether auto format apply lists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplylists?view=word-pia"/>
  public bool AutoFormatApplyLists { get; set; }

  /// <summary>
  /// Returns or sets whether auto format apply bulleted lists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplybulletedlists?view=word-pia"/>
  public bool AutoFormatApplyBulletedLists { get; set; }

  /// <summary>
  /// Returns or sets whether auto format apply other paras.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyotherparas?view=word-pia"/>
  public bool AutoFormatApplyOtherParas { get; set; }

  /// <summary>
  /// Returns or sets whether auto format replace quotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacequotes?view=word-pia"/>
  public bool AutoFormatReplaceQuotes { get; set; }

  /// <summary>
  /// Returns or sets whether auto format replace symbols.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacesymbols?view=word-pia"/>
  public bool AutoFormatReplaceSymbols { get; set; }

  /// <summary>
  /// Returns or sets whether auto format replace ordinals.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplaceordinals?view=word-pia"/>
  public bool AutoFormatReplaceOrdinals { get; set; }

  /// <summary>
  /// Returns or sets whether auto format replace fractions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacefractions?view=word-pia"/>
  public bool AutoFormatReplaceFractions { get; set; }

  /// <summary>
  /// Returns or sets whether auto format replace plain text emphasis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplaceplaintextemphasis?view=word-pia"/>
  public bool AutoFormatReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// Returns or sets whether auto format preserve styles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatpreservestyles?view=word-pia"/>
  public bool AutoFormatPreserveStyles { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type apply headings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyheadings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyHeadings { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type apply borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyborders?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBorders { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type apply bulleted lists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplybulletedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBulletedLists { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type apply numbered lists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplynumberedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyNumberedLists { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type replace quotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacequotes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceQuotes { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type replace symbols.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacesymbols?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceSymbols { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type replace ordinals.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplaceordinals?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceOrdinals { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type replace fractions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacefractions?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFractions { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type replace plain text emphasis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplaceplaintextemphasis?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type format list item beginning.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeformatlistitembeginning?view=word-pia"/>
  public bool AutoFormatAsYouTypeFormatListItemBeginning { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type define styles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypedefinestyles?view=word-pia"/>
  public bool AutoFormatAsYouTypeDefineStyles { get; set; }

  /// <summary>
  /// Returns or sets whether auto format plain text word mail.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatplaintextwordmail?view=word-pia"/>
  public bool AutoFormatPlainTextWordMail { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type replace hyperlinks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacehyperlinks?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceHyperlinks { get; set; }

  /// <summary>
  /// Returns or sets whether auto format replace hyperlinks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacehyperlinks?view=word-pia"/>
  public bool AutoFormatReplaceHyperlinks { get; set; }

  /// <summary>
  /// Returns or sets the default highlight color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulthighlightcolorindex?view=word-pia"/>
  public WdColorIndex DefaultHighlightColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the default border line style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultborderlinestyle?view=word-pia"/>
  public WdLineStyle DefaultBorderLineStyle { get; set; }

  /// <summary>
  /// Returns or sets whether check spelling as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkspellingasyoutype?view=word-pia"/>
  public bool CheckSpellingAsYouType { get; set; }

  /// <summary>
  /// Returns or sets whether check grammar as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkgrammarasyoutype?view=word-pia"/>
  public bool CheckGrammarAsYouType { get; set; }

  /// <summary>
  /// Returns or sets whether ignore internet and file addresses.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoreinternetandfileaddresses?view=word-pia"/>
  public bool IgnoreInternetAndFileAddresses { get; set; }

  /// <summary>
  /// Returns or sets whether show readability statistics.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showreadabilitystatistics?view=word-pia"/>
  public bool ShowReadabilityStatistics { get; set; }

  /// <summary>
  /// Returns or sets whether ignore uppercase.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoreuppercase?view=word-pia"/>
  public bool IgnoreUppercase { get; set; }

  /// <summary>
  /// Returns or sets whether ignore mixed digits.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoremixeddigits?view=word-pia"/>
  public bool IgnoreMixedDigits { get; set; }

  /// <summary>
  /// Returns or sets whether suggest from main dictionary only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.suggestfrommaindictionaryonly?view=word-pia"/>
  public bool SuggestFromMainDictionaryOnly { get; set; }

  /// <summary>
  /// Returns or sets whether suggest spelling corrections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.suggestspellingcorrections?view=word-pia"/>
  public bool SuggestSpellingCorrections { get; set; }

  /// <summary>
  /// Returns or sets the default border line width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultborderlinewidth?view=word-pia"/>
  public WdLineWidth DefaultBorderLineWidth { get; set; }

  /// <summary>
  /// Returns or sets whether check grammar with spelling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkgrammarwithspelling?view=word-pia"/>
  public bool CheckGrammarWithSpelling { get; set; }

  /// <summary>
  /// Returns or sets the default open format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultopenformat?view=word-pia"/>
  public WdOpenFormat DefaultOpenFormat { get; set; }

  /// <summary>
  /// Returns or sets whether print draft.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printdraft?view=word-pia"/>
  public bool PrintDraft { get; set; }

  /// <summary>
  /// Returns or sets whether print reverse.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printreverse?view=word-pia"/>
  public bool PrintReverse { get; set; }

  /// <summary>
  /// Returns or sets whether map paper size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.mappapersize?view=word-pia"/>
  public bool MapPaperSize { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type apply tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplytables?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyTables { get; set; }

  /// <summary>
  /// Returns or sets whether auto format apply first indents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyfirstindents?view=word-pia"/>
  public bool AutoFormatApplyFirstIndents { get; set; }

  /// <summary>
  /// Returns or sets whether auto format match parentheses.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatmatchparentheses?view=word-pia"/>
  public bool AutoFormatMatchParentheses { get; set; }

  /// <summary>
  /// Returns or sets whether auto format replace far east dashes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacefareastdashes?view=word-pia"/>
  public bool AutoFormatReplaceFarEastDashes { get; set; }

  /// <summary>
  /// Returns or sets whether auto format delete auto spaces.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatdeleteautospaces?view=word-pia"/>
  public bool AutoFormatDeleteAutoSpaces { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type apply first indents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyfirstindents?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyFirstIndents { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type apply dates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplydates?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyDates { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type apply closings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyClosings { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type match parentheses.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypematchparentheses?view=word-pia"/>
  public bool AutoFormatAsYouTypeMatchParentheses { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type replace far east dashes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacefareastdashes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFarEastDashes { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type delete auto spaces.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypedeleteautospaces?view=word-pia"/>
  public bool AutoFormatAsYouTypeDeleteAutoSpaces { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type insert closings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeinsertclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertClosings { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type auto letter wizard.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeautoletterwizard?view=word-pia"/>
  public bool AutoFormatAsYouTypeAutoLetterWizard { get; set; }

  /// <summary>
  /// Returns or sets whether auto format as you type insert overs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeinsertovers?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertOvers { get; set; }

  /// <summary>
  /// Returns or sets whether display grid lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaygridlines?view=word-pia"/>
  public bool DisplayGridLines { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy case.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzycase?view=word-pia"/>
  public bool MatchFuzzyCase { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy byte.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzybyte?view=word-pia"/>
  public bool MatchFuzzyByte { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy hiragana.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyhiragana?view=word-pia"/>
  public bool MatchFuzzyHiragana { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy small kana.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzysmallkana?view=word-pia"/>
  public bool MatchFuzzySmallKana { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy dash.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzydash?view=word-pia"/>
  public bool MatchFuzzyDash { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy iteration mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyiterationmark?view=word-pia"/>
  public bool MatchFuzzyIterationMark { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy kanji.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzykanji?view=word-pia"/>
  public bool MatchFuzzyKanji { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy old kana.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyoldkana?view=word-pia"/>
  public bool MatchFuzzyOldKana { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy prolonged sound mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyprolongedsoundmark?view=word-pia"/>
  public bool MatchFuzzyProlongedSoundMark { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy d z.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzydz?view=word-pia"/>
  public bool MatchFuzzyDZ { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy b v.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzybv?view=word-pia"/>
  public bool MatchFuzzyBV { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy t c.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzytc?view=word-pia"/>
  public bool MatchFuzzyTC { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy h f.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyhf?view=word-pia"/>
  public bool MatchFuzzyHF { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy z j.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyzj?view=word-pia"/>
  public bool MatchFuzzyZJ { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy a y.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyay?view=word-pia"/>
  public bool MatchFuzzyAY { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy ki ku.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzykiku?view=word-pia"/>
  public bool MatchFuzzyKiKu { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy punctuation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzypunctuation?view=word-pia"/>
  public bool MatchFuzzyPunctuation { get; set; }

  /// <summary>
  /// Returns or sets whether match fuzzy space.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyspace?view=word-pia"/>
  public bool MatchFuzzySpace { get; set; }

  /// <summary>
  /// Returns or sets whether apply far east fonts to ascii.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.applyfareastfontstoascii?view=word-pia"/>
  public bool ApplyFarEastFontsToAscii { get; set; }

  /// <summary>
  /// Returns or sets whether convert high ansi to far east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.converthighansitofareast?view=word-pia"/>
  public bool ConvertHighAnsiToFarEast { get; set; }

  /// <summary>
  /// Returns or sets whether print odd pages in ascending order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printoddpagesinascendingorder?view=word-pia"/>
  public bool PrintOddPagesInAscendingOrder { get; set; }

  /// <summary>
  /// Returns or sets whether print even pages in ascending order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printevenpagesinascendingorder?view=word-pia"/>
  public bool PrintEvenPagesInAscendingOrder { get; set; }

  /// <summary>
  /// Returns or sets the default border color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultbordercolorindex?view=word-pia"/>
  public WdColorIndex DefaultBorderColorIndex { get; set; }

  /// <summary>
  /// Returns or sets whether enable misused words dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablemisusedwordsdictionary?view=word-pia"/>
  public bool EnableMisusedWordsDictionary { get; set; }

  /// <summary>
  /// Returns or sets whether allow combined auxiliary forms.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowcombinedauxiliaryforms?view=word-pia"/>
  public bool AllowCombinedAuxiliaryForms { get; set; }

  /// <summary>
  /// Returns or sets whether hangul hanja fast conversion.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.hangulhanjafastconversion?view=word-pia"/>
  public bool HangulHanjaFastConversion { get; set; }

  /// <summary>
  /// Returns or sets whether check hangul endings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkhangulendings?view=word-pia"/>
  public bool CheckHangulEndings { get; set; }

  /// <summary>
  /// Returns or sets whether enable hangul hanja recent ordering.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablehangulhanjarecentordering?view=word-pia"/>
  public bool EnableHangulHanjaRecentOrdering { get; set; }

  /// <summary>
  /// Returns or sets the multiple word conversions mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.multiplewordconversionsmode?view=word-pia"/>
  public WdMultipleWordConversionsMode MultipleWordConversionsMode { get; set; }

  /// <summary>
  /// Returns or sets the default border color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultbordercolor?view=word-pia"/>
  public WdColor DefaultBorderColor { get; set; }

  /// <summary>
  /// Returns or sets whether allow pixel units.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowpixelunits?view=word-pia"/>
  public bool AllowPixelUnits { get; set; }

  /// <summary>
  /// Returns or sets whether use character unit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usecharacterunit?view=word-pia"/>
  public bool UseCharacterUnit { get; set; }

  /// <summary>
  /// Returns or sets whether allow compound noun processing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowcompoundnounprocessing?view=word-pia"/>
  public bool AllowCompoundNounProcessing { get; set; }

  /// <summary>
  /// Returns or sets whether auto keyboard switching.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autokeyboardswitching?view=word-pia"/>
  public bool AutoKeyboardSwitching { get; set; }

  /// <summary>
  /// Returns or sets the document view direction.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.documentviewdirection?view=word-pia"/>
  public WdDocumentViewDirection DocumentViewDirection { get; set; }

  /// <summary>
  /// Returns or sets the arabic numeral.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.arabicnumeral?view=word-pia"/>
  public WdArabicNumeral ArabicNumeral { get; set; }

  /// <summary>
  /// Returns or sets the month names.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.monthnames?view=word-pia"/>
  public WdMonthNames MonthNames { get; set; }

  /// <summary>
  /// Returns or sets the cursor movement.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.cursormovement?view=word-pia"/>
  public WdCursorMovement CursorMovement { get; set; }

  /// <summary>
  /// Returns or sets the visual selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.visualselection?view=word-pia"/>
  public WdVisualSelection VisualSelection { get; set; }

  /// <summary>
  /// Returns or sets whether show diacritics.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showdiacritics?view=word-pia"/>
  public bool ShowDiacritics { get; set; }

  /// <summary>
  /// Returns or sets whether show control characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showcontrolcharacters?view=word-pia"/>
  public bool ShowControlCharacters { get; set; }

  /// <summary>
  /// Returns or sets whether add control characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addcontrolcharacters?view=word-pia"/>
  public bool AddControlCharacters { get; set; }

  /// <summary>
  /// Returns or sets whether add bi directional marks when saving text file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addbidirectionalmarkswhensavingtextfile?view=word-pia"/>
  public bool AddBiDirectionalMarksWhenSavingTextFile { get; set; }

  /// <summary>
  /// Returns or sets whether strict initial alef hamza.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictinitialalefhamza?view=word-pia"/>
  public bool StrictInitialAlefHamza { get; set; }

  /// <summary>
  /// Returns or sets whether strict final yaa.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictfinalyaa?view=word-pia"/>
  public bool StrictFinalYaa { get; set; }

  /// <summary>
  /// Returns or sets the hebrew mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.hebrewmode?view=word-pia"/>
  public WdHebSpellStart HebrewMode { get; set; }

  /// <summary>
  /// Returns or sets the arabic mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.arabicmode?view=word-pia"/>
  public WdAraSpeller ArabicMode { get; set; }

  /// <summary>
  /// Returns or sets whether allow click and type mouse.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowclickandtypemouse?view=word-pia"/>
  public bool AllowClickAndTypeMouse { get; set; }

  /// <summary>
  /// Returns or sets whether use german spelling reform.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usegermanspellingreform?view=word-pia"/>
  public bool UseGermanSpellingReform { get; set; }

  /// <summary>
  /// Returns or sets the interpret high ansi.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.interprethighansi?view=word-pia"/>
  public WdHighAnsiText InterpretHighAnsi { get; set; }

  /// <summary>
  /// Returns or sets whether add heb double quote.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addhebdoublequote?view=word-pia"/>
  public bool AddHebDoubleQuote { get; set; }

  /// <summary>
  /// Returns or sets whether use diff diac color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usediffdiaccolor?view=word-pia"/>
  public bool UseDiffDiacColor { get; set; }

  /// <summary>
  /// Returns or sets the diacritic color val.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.diacriticcolorval?view=word-pia"/>
  public WdColor DiacriticColorVal { get; set; }

  /// <summary>
  /// Returns or sets whether optimize for word97by default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.optimizeforword97bydefault?view=word-pia"/>
  public bool OptimizeForWord97byDefault { get; set; }

  /// <summary>
  /// Returns or sets whether local network file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.localnetworkfile?view=word-pia"/>
  public bool LocalNetworkFile { get; set; }

  /// <summary>
  /// Returns or sets whether type n replace.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.typenreplace?view=word-pia"/>
  public bool TypeNReplace { get; set; }

  /// <summary>
  /// Returns or sets whether sequence check.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.sequencecheck?view=word-pia"/>
  public bool SequenceCheck { get; set; }

  /// <summary>
  /// Returns or sets whether background open.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.backgroundopen?view=word-pia"/>
  public bool BackgroundOpen { get; set; }

  /// <summary>
  /// Returns or sets whether disable featuresby default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.disablefeaturesbydefault?view=word-pia"/>
  public bool DisableFeaturesbyDefault { get; set; }

  /// <summary>
  /// Returns or sets whether paste adjust word spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjustwordspacing?view=word-pia"/>
  public bool PasteAdjustWordSpacing { get; set; }

  /// <summary>
  /// Returns or sets whether paste adjust paragraph spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjustparagraphspacing?view=word-pia"/>
  public bool PasteAdjustParagraphSpacing { get; set; }

  /// <summary>
  /// Returns or sets whether paste adjust table formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjusttableformatting?view=word-pia"/>
  public bool PasteAdjustTableFormatting { get; set; }

  /// <summary>
  /// Returns or sets whether paste smart style behavior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastesmartstylebehavior?view=word-pia"/>
  public bool PasteSmartStyleBehavior { get; set; }

  /// <summary>
  /// Returns or sets whether paste merge from p p t.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergefromppt?view=word-pia"/>
  public bool PasteMergeFromPPT { get; set; }

  /// <summary>
  /// Returns or sets whether paste merge from x l.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergefromxl?view=word-pia"/>
  public bool PasteMergeFromXL { get; set; }

  /// <summary>
  /// Returns or sets whether ctrl click hyperlink to open.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ctrlclickhyperlinktoopen?view=word-pia"/>
  public bool CtrlClickHyperlinkToOpen { get; set; }

  /// <summary>
  /// Returns or sets the picture wrap type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.picturewraptype?view=word-pia"/>
  public WdWrapTypeMerged PictureWrapType { get; set; }

  /// <summary>
  /// Returns or sets the disable features introduced afterby default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.disablefeaturesintroducedafterbydefault?view=word-pia"/>
  public WdDisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfterbyDefault { get; set; }

  /// <summary>
  /// Returns or sets whether paste smart cut paste.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastesmartcutpaste?view=word-pia"/>
  public bool PasteSmartCutPaste { get; set; }

  /// <summary>
  /// Returns or sets whether display paste options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaypasteoptions?view=word-pia"/>
  public bool DisplayPasteOptions { get; set; }

  /// <summary>
  /// Returns or sets whether prompt update style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.promptupdatestyle?view=word-pia"/>
  public bool PromptUpdateStyle { get; set; }

  /// <summary>
  /// Returns or sets the default e postage app.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultepostageapp?view=word-pia"/>
  public string DefaultEPostageApp { get; set; }

  /// <summary>
  /// Returns or sets the default text encoding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttextencoding?view=word-pia"/>
  public Core.MsoEncoding DefaultTextEncoding { get; set; }

  /// <summary>
  /// Returns or sets whether label smart tags.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.labelsmarttags?view=word-pia"/>
  public bool LabelSmartTags { get; set; }

  /// <summary>
  /// Returns or sets whether display smart tag buttons.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaysmarttagbuttons?view=word-pia"/>
  public bool DisplaySmartTagButtons { get; set; }

  /// <summary>
  /// Returns or sets whether warn before saving printing sending markup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.warnbeforesavingprintingsendingmarkup?view=word-pia"/>
  public bool WarnBeforeSavingPrintingSendingMarkup { get; set; }

  /// <summary>
  /// Returns or sets whether store r s i d on save.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.storersidonsave?view=word-pia"/>
  public bool StoreRSIDOnSave { get; set; }

  /// <summary>
  /// Returns or sets whether show format error.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showformaterror?view=word-pia"/>
  public bool ShowFormatError { get; set; }

  /// <summary>
  /// Returns or sets whether format scanning.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.formatscanning?view=word-pia"/>
  public bool FormatScanning { get; set; }

  /// <summary>
  /// Returns or sets whether paste merge lists.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergelists?view=word-pia"/>
  public bool PasteMergeLists { get; set; }

  /// <summary>
  /// Returns or sets whether auto create new drawings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autocreatenewdrawings?view=word-pia"/>
  public bool AutoCreateNewDrawings { get; set; }

  /// <summary>
  /// Returns or sets whether smart para selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartparaselection?view=word-pia"/>
  public bool SmartParaSelection { get; set; }

  /// <summary>
  /// Returns or sets the revisions balloon print orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisionsballoonprintorientation?view=word-pia"/>
  public WdRevisionsBalloonPrintOrientation RevisionsBalloonPrintOrientation { get; set; }

  /// <summary>
  /// Returns or sets the comments color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.commentscolor?view=word-pia"/>
  public WdColorIndex CommentsColor { get; set; }

  /// <summary>
  /// Returns or sets whether print x m l tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printxmltag?view=word-pia"/>
  public bool PrintXMLTag { get; set; }

  /// <summary>
  /// Returns or sets whether print backgrounds.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printbackgrounds?view=word-pia"/>
  public bool PrintBackgrounds { get; set; }

  /// <summary>
  /// Returns or sets whether allow reading mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowreadingmode?view=word-pia"/>
  public bool AllowReadingMode { get; set; }

  /// <summary>
  /// Returns or sets whether show markup open save.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showmarkupopensave?view=word-pia"/>
  public bool ShowMarkupOpenSave { get; set; }

  /// <summary>
  /// Returns or sets whether smart cursoring.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartcursoring?view=word-pia"/>
  public bool SmartCursoring { get; set; }

  /// <summary>
  /// Returns or sets the move to text mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movetotextmark?view=word-pia"/>
  public WdMoveToTextMark MoveToTextMark { get; set; }

  /// <summary>
  /// Returns or sets the move from text mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movefromtextmark?view=word-pia"/>
  public WdMoveFromTextMark MoveFromTextMark { get; set; }

  /// <summary>
  /// Returns or sets the bibliography style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bibliographystyle?view=word-pia"/>
  public string BibliographyStyle { get; set; }

  /// <summary>
  /// Returns or sets the bibliography sort.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bibliographysort?view=word-pia"/>
  public string BibliographySort { get; set; }

  /// <summary>
  /// Returns or sets the inserted cell color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedcellcolor?view=word-pia"/>
  public WdCellColor InsertedCellColor { get; set; }

  /// <summary>
  /// Returns or sets the deleted cell color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedcellcolor?view=word-pia"/>
  public WdCellColor DeletedCellColor { get; set; }

  /// <summary>
  /// Returns or sets the merged cell color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.mergedcellcolor?view=word-pia"/>
  public WdCellColor MergedCellColor { get; set; }

  /// <summary>
  /// Returns or sets the split cell color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.splitcellcolor?view=word-pia"/>
  public WdCellColor SplitCellColor { get; set; }

  /// <summary>
  /// Returns or sets whether show selection floaties.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showselectionfloaties?view=word-pia"/>
  public bool ShowSelectionFloaties { get; set; }

  /// <summary>
  /// Returns or sets whether show menu floaties.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showmenufloaties?view=word-pia"/>
  public bool ShowMenuFloaties { get; set; }

  /// <summary>
  /// Returns or sets whether show dev tools.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showdevtools?view=word-pia"/>
  public bool ShowDevTools { get; set; }

  /// <summary>
  /// Returns or sets whether enable live preview.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelivepreview?view=word-pia"/>
  public bool EnableLivePreview { get; set; }

  /// <summary>
  /// Returns or sets whether o math auto build up.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.omathautobuildup?view=word-pia"/>
  public bool OMathAutoBuildUp { get; set; }

  /// <summary>
  /// Returns or sets whether always use clear type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.alwaysusecleartype?view=word-pia"/>
  public bool AlwaysUseClearType { get; set; }

  /// <summary>
  /// Returns or sets the paste format within document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatwithindocument?view=word-pia"/>
  public WdPasteOptions PasteFormatWithinDocument { get; set; }

  /// <summary>
  /// Returns or sets the paste format between documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatbetweendocuments?view=word-pia"/>
  public WdPasteOptions PasteFormatBetweenDocuments { get; set; }

  /// <summary>
  /// Returns or sets the paste format between styled documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatbetweenstyleddocuments?view=word-pia"/>
  public WdPasteOptions PasteFormatBetweenStyledDocuments { get; set; }

  /// <summary>
  /// Returns or sets the paste format from external source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatfromexternalsource?view=word-pia"/>
  public WdPasteOptions PasteFormatFromExternalSource { get; set; }

  /// <summary>
  /// Returns or sets whether paste option keep bullets and numbers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteoptionkeepbulletsandnumbers?view=word-pia"/>
  public bool PasteOptionKeepBulletsAndNumbers { get; set; }

  /// <summary>
  /// Returns or sets whether i n s key for overtype.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inskeyforovertype?view=word-pia"/>
  public bool INSKeyForOvertype { get; set; }

  /// <summary>
  /// Returns or sets whether repeat word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.repeatword?view=word-pia"/>
  public bool RepeatWord { get; set; }

  /// <summary>
  /// Returns or sets the french reform.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.frenchreform?view=word-pia"/>
  public WdFrenchSpeller FrenchReform { get; set; }

  /// <summary>
  /// Returns or sets whether contextual speller.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.contextualspeller?view=word-pia"/>
  public bool ContextualSpeller { get; set; }

  /// <summary>
  /// Returns or sets the move to text color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movetotextcolor?view=word-pia"/>
  public WdColorIndex MoveToTextColor { get; set; }

  /// <summary>
  /// Returns or sets the move from text color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movefromtextcolor?view=word-pia"/>
  public WdColorIndex MoveFromTextColor { get; set; }

  /// <summary>
  /// Returns or sets whether o math copy l f.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.omathcopylf?view=word-pia"/>
  public bool OMathCopyLF { get; set; }

  /// <summary>
  /// Returns or sets whether use normal style for list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usenormalstyleforlist?view=word-pia"/>
  public bool UseNormalStyleForList { get; set; }

  /// <summary>
  /// Returns or sets whether allow open in draft view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowopenindraftview?view=word-pia"/>
  public bool AllowOpenInDraftView { get; set; }

  /// <summary>
  /// Returns or sets whether enable legacy i m e mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelegacyimemode?view=word-pia"/>
  public bool EnableLegacyIMEMode { get; set; }

  /// <summary>
  /// Returns or sets whether do not prompt for convert.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.donotpromptforconvert?view=word-pia"/>
  public bool DoNotPromptForConvert { get; set; }

  /// <summary>
  /// Returns or sets whether precise positioning.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.precisepositioning?view=word-pia"/>
  public bool PrecisePositioning { get; set; }

  /// <summary>
  /// Returns or sets the update style list behavior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatestylelistbehavior?view=word-pia"/>
  public WdUpdateStyleListBehavior UpdateStyleListBehavior { get; set; }

  /// <summary>
  /// Returns or sets whether strict taa marboota.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.stricttaamarboota?view=word-pia"/>
  public bool StrictTaaMarboota { get; set; }

  /// <summary>
  /// Returns or sets whether strict russian e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictrussiane?view=word-pia"/>
  public bool StrictRussianE { get; set; }

  /// <summary>
  /// Returns or sets the spanish mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.spanishmode?view=word-pia"/>
  public WdSpanishSpeller SpanishMode { get; set; }

  /// <summary>
  /// Returns or sets the portugal reform.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.portugalreform?view=word-pia"/>
  public WdPortugueseReform PortugalReform { get; set; }

  /// <summary>
  /// Returns or sets the brazil reform.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.brazilreform?view=word-pia"/>
  public WdPortugueseReform BrazilReform { get; set; }

  /// <summary>
  /// Returns or sets whether update fields with tracked changes at print.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatefieldswithtrackedchangesatprint?view=word-pia"/>
  public bool UpdateFieldsWithTrackedChangesAtPrint { get; set; }

  /// <summary>
  /// Returns or sets whether display alignment guides.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displayalignmentguides?view=word-pia"/>
  public bool DisplayAlignmentGuides { get; set; }

  /// <summary>
  /// Returns or sets whether page alignment guides.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pagealignmentguides?view=word-pia"/>
  public bool PageAlignmentGuides { get; set; }

  /// <summary>
  /// Returns or sets whether margin alignment guides.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.marginalignmentguides?view=word-pia"/>
  public bool MarginAlignmentGuides { get; set; }

  /// <summary>
  /// Returns or sets whether paragraph alignment guides.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.paragraphalignmentguides?view=word-pia"/>
  public bool ParagraphAlignmentGuides { get; set; }

  /// <summary>
  /// Returns or sets whether enable live drag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelivedrag?view=word-pia"/>
  public bool EnableLiveDrag { get; set; }

  /// <summary>
  /// Returns or sets whether use sub pixel positioning.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usesubpixelpositioning?view=word-pia"/>
  public bool UseSubPixelPositioning { get; set; }

  /// <summary>
  /// Returns or sets whether alert if not default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.alertifnotdefault?view=word-pia"/>
  public bool AlertIfNotDefault { get; set; }

  /// <summary>
  /// Returns or sets whether enable proofing tools advertisement.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enableproofingtoolsadvertisement?view=word-pia"/>
  public bool EnableProofingToolsAdvertisement { get; set; }

  /// <summary>
  /// Returns or sets whether prefer cloud save locations.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.prefercloudsavelocations?view=word-pia"/>
  public bool PreferCloudSaveLocations { get; set; }

  /// <summary>
  /// Returns or sets whether sky drive sign in option.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.skydrivesigninoption?view=word-pia"/>
  public bool SkyDriveSignInOption { get; set; }

  /// <summary>
  /// Returns or sets whether expand headings on open.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.expandheadingsonopen?view=word-pia"/>
  public bool ExpandHeadingsOnOpen { get; set; }

  /// <summary>
  /// Returns or sets whether use local user info.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.uselocaluserinfo?view=word-pia"/>
  public bool UseLocalUserInfo { get; set; }

  /// <summary>
  /// Returns or sets whether cloud sign in option.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.cloudsigninoption?view=word-pia"/>
  public bool CloudSignInOption { get; set; }
}
