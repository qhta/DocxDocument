namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface Options : InteropObject
{
  /// <summary>
  /// The allow accented uppercase.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowaccenteduppercase?view=word-pia"/>
  public bool AllowAccentedUppercase { get; set; }

  /// <summary>
  /// The wphelp.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.wphelp?view=word-pia"/>
  public bool WPHelp { get; set; }

  /// <summary>
  /// The wpdoc nav keys.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.wpdocnavkeys?view=word-pia"/>
  public bool WPDocNavKeys { get; set; }

  /// <summary>
  /// The pagination.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pagination?view=word-pia"/>
  public bool Pagination { get; set; }

  /// <summary>
  /// The blue screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bluescreen?view=word-pia"/>
  public bool BlueScreen { get; set; }

  /// <summary>
  /// The enable sound.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablesound?view=word-pia"/>
  public bool EnableSound { get; set; }

  /// <summary>
  /// The confirm conversions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.confirmconversions?view=word-pia"/>
  public bool ConfirmConversions { get; set; }

  /// <summary>
  /// The update links at open.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatelinksatopen?view=word-pia"/>
  public bool UpdateLinksAtOpen { get; set; }

  /// <summary>
  /// The send mail attach.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.sendmailattach?view=word-pia"/>
  public bool SendMailAttach { get; set; }

  /// <summary>
  /// The measurement unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.measurementunit?view=word-pia"/>
  public WdMeasurementUnits MeasurementUnit { get; set; }

  /// <summary>
  /// The button field clicks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.buttonfieldclicks?view=word-pia"/>
  public int ButtonFieldClicks { get; set; }

  /// <summary>
  /// The short menu names.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.shortmenunames?view=word-pia"/>
  public bool ShortMenuNames { get; set; }

  /// <summary>
  /// The rtfin clipboard.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.rtfinclipboard?view=word-pia"/>
  public bool RTFInClipboard { get; set; }

  /// <summary>
  /// The update fields at print.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatefieldsatprint?view=word-pia"/>
  public bool UpdateFieldsAtPrint { get; set; }

  /// <summary>
  /// The print properties.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printproperties?view=word-pia"/>
  public bool PrintProperties { get; set; }

  /// <summary>
  /// The print field codes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printfieldcodes?view=word-pia"/>
  public bool PrintFieldCodes { get; set; }

  /// <summary>
  /// The print comments.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printcomments?view=word-pia"/>
  public bool PrintComments { get; set; }

  /// <summary>
  /// The print hidden text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printhiddentext?view=word-pia"/>
  public bool PrintHiddenText { get; set; }

  /// <summary>
  /// The envelope feeder installed.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.envelopefeederinstalled?view=word-pia"/>
  public bool EnvelopeFeederInstalled { get; }

  /// <summary>
  /// The update links at print.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatelinksatprint?view=word-pia"/>
  public bool UpdateLinksAtPrint { get; set; }

  /// <summary>
  /// The print background.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printbackground?view=word-pia"/>
  public bool PrintBackground { get; set; }

  /// <summary>
  /// The print drawing objects.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printdrawingobjects?view=word-pia"/>
  public bool PrintDrawingObjects { get; set; }

  /// <summary>
  /// The default tray.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttray?view=word-pia"/>
  public string DefaultTray { get; set; }

  /// <summary>
  /// The default tray id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttrayid?view=word-pia"/>
  public int DefaultTrayID { get; set; }

  /// <summary>
  /// The create backup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.createbackup?view=word-pia"/>
  public bool CreateBackup { get; set; }

  /// <summary>
  /// The allow fast save.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowfastsave?view=word-pia"/>
  public bool AllowFastSave { get; set; }

  /// <summary>
  /// The save properties prompt.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.savepropertiesprompt?view=word-pia"/>
  public bool SavePropertiesPrompt { get; set; }

  /// <summary>
  /// The save normal prompt.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.savenormalprompt?view=word-pia"/>
  public bool SaveNormalPrompt { get; set; }

  /// <summary>
  /// The save interval.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.saveinterval?view=word-pia"/>
  public int SaveInterval { get; set; }

  /// <summary>
  /// The background save.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.backgroundsave?view=word-pia"/>
  public bool BackgroundSave { get; set; }

  /// <summary>
  /// The inserted text mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedtextmark?view=word-pia"/>
  public WdInsertedTextMark InsertedTextMark { get; set; }

  /// <summary>
  /// The deleted text mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedtextmark?view=word-pia"/>
  public WdDeletedTextMark DeletedTextMark { get; set; }

  /// <summary>
  /// The revised lines mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedlinesmark?view=word-pia"/>
  public WdRevisedLinesMark RevisedLinesMark { get; set; }

  /// <summary>
  /// The inserted text color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedtextcolor?view=word-pia"/>
  public WdColorIndex InsertedTextColor { get; set; }

  /// <summary>
  /// The deleted text color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedtextcolor?view=word-pia"/>
  public WdColorIndex DeletedTextColor { get; set; }

  /// <summary>
  /// The revised lines color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedlinescolor?view=word-pia"/>
  public WdColorIndex RevisedLinesColor { get; set; }

  /// <summary>
  /// The overtype.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.overtype?view=word-pia"/>
  public bool Overtype { get; set; }

  /// <summary>
  /// The replace selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.replaceselection?view=word-pia"/>
  public bool ReplaceSelection { get; set; }

  /// <summary>
  /// The allow drag and drop.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowdraganddrop?view=word-pia"/>
  public bool AllowDragAndDrop { get; set; }

  /// <summary>
  /// The auto word selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autowordselection?view=word-pia"/>
  public bool AutoWordSelection { get; set; }

  /// <summary>
  /// The inskey for paste.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inskeyforpaste?view=word-pia"/>
  public bool INSKeyForPaste { get; set; }

  /// <summary>
  /// The smart cut paste.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartcutpaste?view=word-pia"/>
  public bool SmartCutPaste { get; set; }

  /// <summary>
  /// The tab indent key.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.tabindentkey?view=word-pia"/>
  public bool TabIndentKey { get; set; }

  /// <summary>
  /// The picture editor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pictureeditor?view=word-pia"/>
  public string PictureEditor { get; set; }

  /// <summary>
  /// The animate screen movements.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.animatescreenmovements?view=word-pia"/>
  public bool AnimateScreenMovements { get; set; }

  /// <summary>
  /// The virus protection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.virusprotection?view=word-pia"/>
  public bool VirusProtection { get; set; }

  /// <summary>
  /// The revised properties mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedpropertiesmark?view=word-pia"/>
  public WdRevisedPropertiesMark RevisedPropertiesMark { get; set; }

  /// <summary>
  /// The revised properties color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedpropertiescolor?view=word-pia"/>
  public WdColorIndex RevisedPropertiesColor { get; set; }

  /// <summary>
  /// The snap to grid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.snaptogrid?view=word-pia"/>
  public bool SnapToGrid { get; set; }

  /// <summary>
  /// The snap to shapes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.snaptoshapes?view=word-pia"/>
  public bool SnapToShapes { get; set; }

  /// <summary>
  /// The grid distance horizontal.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.griddistancehorizontal?view=word-pia"/>
  public float GridDistanceHorizontal { get; set; }

  /// <summary>
  /// The grid distance vertical.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.griddistancevertical?view=word-pia"/>
  public float GridDistanceVertical { get; set; }

  /// <summary>
  /// The grid origin horizontal.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.gridoriginhorizontal?view=word-pia"/>
  public float GridOriginHorizontal { get; set; }

  /// <summary>
  /// The grid origin vertical.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.gridoriginvertical?view=word-pia"/>
  public float GridOriginVertical { get; set; }

  /// <summary>
  /// The inline conversion.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inlineconversion?view=word-pia"/>
  public bool InlineConversion { get; set; }

  /// <summary>
  /// The imeautomatic control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.imeautomaticcontrol?view=word-pia"/>
  public bool IMEAutomaticControl { get; set; }

  /// <summary>
  /// The auto format apply headings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyheadings?view=word-pia"/>
  public bool AutoFormatApplyHeadings { get; set; }

  /// <summary>
  /// The auto format apply lists.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplylists?view=word-pia"/>
  public bool AutoFormatApplyLists { get; set; }

  /// <summary>
  /// The auto format apply bulleted lists.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplybulletedlists?view=word-pia"/>
  public bool AutoFormatApplyBulletedLists { get; set; }

  /// <summary>
  /// The auto format apply other paras.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyotherparas?view=word-pia"/>
  public bool AutoFormatApplyOtherParas { get; set; }

  /// <summary>
  /// The auto format replace quotes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacequotes?view=word-pia"/>
  public bool AutoFormatReplaceQuotes { get; set; }

  /// <summary>
  /// The auto format replace symbols.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacesymbols?view=word-pia"/>
  public bool AutoFormatReplaceSymbols { get; set; }

  /// <summary>
  /// The auto format replace ordinals.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplaceordinals?view=word-pia"/>
  public bool AutoFormatReplaceOrdinals { get; set; }

  /// <summary>
  /// The auto format replace fractions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacefractions?view=word-pia"/>
  public bool AutoFormatReplaceFractions { get; set; }

  /// <summary>
  /// The auto format replace plain text emphasis.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplaceplaintextemphasis?view=word-pia"/>
  public bool AutoFormatReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// The auto format preserve styles.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatpreservestyles?view=word-pia"/>
  public bool AutoFormatPreserveStyles { get; set; }

  /// <summary>
  /// The auto format as you type apply headings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyheadings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyHeadings { get; set; }

  /// <summary>
  /// The auto format as you type apply borders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyborders?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBorders { get; set; }

  /// <summary>
  /// The auto format as you type apply bulleted lists.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplybulletedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyBulletedLists { get; set; }

  /// <summary>
  /// The auto format as you type apply numbered lists.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplynumberedlists?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyNumberedLists { get; set; }

  /// <summary>
  /// The auto format as you type replace quotes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacequotes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceQuotes { get; set; }

  /// <summary>
  /// The auto format as you type replace symbols.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacesymbols?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceSymbols { get; set; }

  /// <summary>
  /// The auto format as you type replace ordinals.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplaceordinals?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceOrdinals { get; set; }

  /// <summary>
  /// The auto format as you type replace fractions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacefractions?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFractions { get; set; }

  /// <summary>
  /// The auto format as you type replace plain text emphasis.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplaceplaintextemphasis?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplacePlainTextEmphasis { get; set; }

  /// <summary>
  /// The auto format as you type format list item beginning.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeformatlistitembeginning?view=word-pia"/>
  public bool AutoFormatAsYouTypeFormatListItemBeginning { get; set; }

  /// <summary>
  /// The auto format as you type define styles.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypedefinestyles?view=word-pia"/>
  public bool AutoFormatAsYouTypeDefineStyles { get; set; }

  /// <summary>
  /// The auto format plain text word mail.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatplaintextwordmail?view=word-pia"/>
  public bool AutoFormatPlainTextWordMail { get; set; }

  /// <summary>
  /// The auto format as you type replace hyperlinks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacehyperlinks?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceHyperlinks { get; set; }

  /// <summary>
  /// The auto format replace hyperlinks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacehyperlinks?view=word-pia"/>
  public bool AutoFormatReplaceHyperlinks { get; set; }

  /// <summary>
  /// The default highlight color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulthighlightcolorindex?view=word-pia"/>
  public WdColorIndex DefaultHighlightColorIndex { get; set; }

  /// <summary>
  /// The default border line style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultborderlinestyle?view=word-pia"/>
  public WdLineStyle DefaultBorderLineStyle { get; set; }

  /// <summary>
  /// The check spelling as you type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkspellingasyoutype?view=word-pia"/>
  public bool CheckSpellingAsYouType { get; set; }

  /// <summary>
  /// The check grammar as you type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkgrammarasyoutype?view=word-pia"/>
  public bool CheckGrammarAsYouType { get; set; }

  /// <summary>
  /// The ignore internet and file addresses.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoreinternetandfileaddresses?view=word-pia"/>
  public bool IgnoreInternetAndFileAddresses { get; set; }

  /// <summary>
  /// The show readability statistics.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showreadabilitystatistics?view=word-pia"/>
  public bool ShowReadabilityStatistics { get; set; }

  /// <summary>
  /// The ignore uppercase.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoreuppercase?view=word-pia"/>
  public bool IgnoreUppercase { get; set; }

  /// <summary>
  /// The ignore mixed digits.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ignoremixeddigits?view=word-pia"/>
  public bool IgnoreMixedDigits { get; set; }

  /// <summary>
  /// The suggest from main dictionary only.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.suggestfrommaindictionaryonly?view=word-pia"/>
  public bool SuggestFromMainDictionaryOnly { get; set; }

  /// <summary>
  /// The suggest spelling corrections.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.suggestspellingcorrections?view=word-pia"/>
  public bool SuggestSpellingCorrections { get; set; }

  /// <summary>
  /// The default border line width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultborderlinewidth?view=word-pia"/>
  public WdLineWidth DefaultBorderLineWidth { get; set; }

  /// <summary>
  /// The check grammar with spelling.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkgrammarwithspelling?view=word-pia"/>
  public bool CheckGrammarWithSpelling { get; set; }

  /// <summary>
  /// The default open format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultopenformat?view=word-pia"/>
  public WdOpenFormat DefaultOpenFormat { get; set; }

  /// <summary>
  /// The print draft.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printdraft?view=word-pia"/>
  public bool PrintDraft { get; set; }

  /// <summary>
  /// The print reverse.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printreverse?view=word-pia"/>
  public bool PrintReverse { get; set; }

  /// <summary>
  /// The map paper size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.mappapersize?view=word-pia"/>
  public bool MapPaperSize { get; set; }

  /// <summary>
  /// The auto format as you type apply tables.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplytables?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyTables { get; set; }

  /// <summary>
  /// The auto format apply first indents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatapplyfirstindents?view=word-pia"/>
  public bool AutoFormatApplyFirstIndents { get; set; }

  /// <summary>
  /// The auto format match parentheses.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatmatchparentheses?view=word-pia"/>
  public bool AutoFormatMatchParentheses { get; set; }

  /// <summary>
  /// The auto format replace far east dashes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatreplacefareastdashes?view=word-pia"/>
  public bool AutoFormatReplaceFarEastDashes { get; set; }

  /// <summary>
  /// The auto format delete auto spaces.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatdeleteautospaces?view=word-pia"/>
  public bool AutoFormatDeleteAutoSpaces { get; set; }

  /// <summary>
  /// The auto format as you type apply first indents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyfirstindents?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyFirstIndents { get; set; }

  /// <summary>
  /// The auto format as you type apply dates.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplydates?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyDates { get; set; }

  /// <summary>
  /// The auto format as you type apply closings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeapplyclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeApplyClosings { get; set; }

  /// <summary>
  /// The auto format as you type match parentheses.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypematchparentheses?view=word-pia"/>
  public bool AutoFormatAsYouTypeMatchParentheses { get; set; }

  /// <summary>
  /// The auto format as you type replace far east dashes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypereplacefareastdashes?view=word-pia"/>
  public bool AutoFormatAsYouTypeReplaceFarEastDashes { get; set; }

  /// <summary>
  /// The auto format as you type delete auto spaces.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypedeleteautospaces?view=word-pia"/>
  public bool AutoFormatAsYouTypeDeleteAutoSpaces { get; set; }

  /// <summary>
  /// The auto format as you type insert closings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeinsertclosings?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertClosings { get; set; }

  /// <summary>
  /// The auto format as you type auto letter wizard.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeautoletterwizard?view=word-pia"/>
  public bool AutoFormatAsYouTypeAutoLetterWizard { get; set; }

  /// <summary>
  /// The auto format as you type insert overs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autoformatasyoutypeinsertovers?view=word-pia"/>
  public bool AutoFormatAsYouTypeInsertOvers { get; set; }

  /// <summary>
  /// The display grid lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaygridlines?view=word-pia"/>
  public bool DisplayGridLines { get; set; }

  /// <summary>
  /// The match fuzzy case.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzycase?view=word-pia"/>
  public bool MatchFuzzyCase { get; set; }

  /// <summary>
  /// The match fuzzy byte.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzybyte?view=word-pia"/>
  public bool MatchFuzzyByte { get; set; }

  /// <summary>
  /// The match fuzzy hiragana.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyhiragana?view=word-pia"/>
  public bool MatchFuzzyHiragana { get; set; }

  /// <summary>
  /// The match fuzzy small kana.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzysmallkana?view=word-pia"/>
  public bool MatchFuzzySmallKana { get; set; }

  /// <summary>
  /// The match fuzzy dash.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzydash?view=word-pia"/>
  public bool MatchFuzzyDash { get; set; }

  /// <summary>
  /// The match fuzzy iteration mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyiterationmark?view=word-pia"/>
  public bool MatchFuzzyIterationMark { get; set; }

  /// <summary>
  /// The match fuzzy kanji.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzykanji?view=word-pia"/>
  public bool MatchFuzzyKanji { get; set; }

  /// <summary>
  /// The match fuzzy old kana.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyoldkana?view=word-pia"/>
  public bool MatchFuzzyOldKana { get; set; }

  /// <summary>
  /// The match fuzzy prolonged sound mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyprolongedsoundmark?view=word-pia"/>
  public bool MatchFuzzyProlongedSoundMark { get; set; }

  /// <summary>
  /// The match fuzzy dz.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzydz?view=word-pia"/>
  public bool MatchFuzzyDZ { get; set; }

  /// <summary>
  /// The match fuzzy bv.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzybv?view=word-pia"/>
  public bool MatchFuzzyBV { get; set; }

  /// <summary>
  /// The match fuzzy tc.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzytc?view=word-pia"/>
  public bool MatchFuzzyTC { get; set; }

  /// <summary>
  /// The match fuzzy hf.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyhf?view=word-pia"/>
  public bool MatchFuzzyHF { get; set; }

  /// <summary>
  /// The match fuzzy zj.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyzj?view=word-pia"/>
  public bool MatchFuzzyZJ { get; set; }

  /// <summary>
  /// The match fuzzy ay.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyay?view=word-pia"/>
  public bool MatchFuzzyAY { get; set; }

  /// <summary>
  /// The match fuzzy ki ku.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzykiku?view=word-pia"/>
  public bool MatchFuzzyKiKu { get; set; }

  /// <summary>
  /// The match fuzzy punctuation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzypunctuation?view=word-pia"/>
  public bool MatchFuzzyPunctuation { get; set; }

  /// <summary>
  /// The match fuzzy space.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyspace?view=word-pia"/>
  public bool MatchFuzzySpace { get; set; }

  /// <summary>
  /// The apply far east fonts to ascii.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.applyfareastfontstoascii?view=word-pia"/>
  public bool ApplyFarEastFontsToAscii { get; set; }

  /// <summary>
  /// The convert high ansi to far east.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.converthighansitofareast?view=word-pia"/>
  public bool ConvertHighAnsiToFarEast { get; set; }

  /// <summary>
  /// The print odd pages in ascending order.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printoddpagesinascendingorder?view=word-pia"/>
  public bool PrintOddPagesInAscendingOrder { get; set; }

  /// <summary>
  /// The print even pages in ascending order.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printevenpagesinascendingorder?view=word-pia"/>
  public bool PrintEvenPagesInAscendingOrder { get; set; }

  /// <summary>
  /// The default border color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultbordercolorindex?view=word-pia"/>
  public WdColorIndex DefaultBorderColorIndex { get; set; }

  /// <summary>
  /// The enable misused words dictionary.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablemisusedwordsdictionary?view=word-pia"/>
  public bool EnableMisusedWordsDictionary { get; set; }

  /// <summary>
  /// The allow combined auxiliary forms.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowcombinedauxiliaryforms?view=word-pia"/>
  public bool AllowCombinedAuxiliaryForms { get; set; }

  /// <summary>
  /// The hangul hanja fast conversion.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.hangulhanjafastconversion?view=word-pia"/>
  public bool HangulHanjaFastConversion { get; set; }

  /// <summary>
  /// The check hangul endings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkhangulendings?view=word-pia"/>
  public bool CheckHangulEndings { get; set; }

  /// <summary>
  /// The enable hangul hanja recent ordering.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablehangulhanjarecentordering?view=word-pia"/>
  public bool EnableHangulHanjaRecentOrdering { get; set; }

  /// <summary>
  /// The multiple word conversions mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.multiplewordconversionsmode?view=word-pia"/>
  public WdMultipleWordConversionsMode MultipleWordConversionsMode { get; set; }

  /// <summary>
  /// The default border color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultbordercolor?view=word-pia"/>
  public WdColor DefaultBorderColor { get; set; }

  /// <summary>
  /// The allow pixel units.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowpixelunits?view=word-pia"/>
  public bool AllowPixelUnits { get; set; }

  /// <summary>
  /// The use character unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usecharacterunit?view=word-pia"/>
  public bool UseCharacterUnit { get; set; }

  /// <summary>
  /// The allow compound noun processing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowcompoundnounprocessing?view=word-pia"/>
  public bool AllowCompoundNounProcessing { get; set; }

  /// <summary>
  /// The auto keyboard switching.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autokeyboardswitching?view=word-pia"/>
  public bool AutoKeyboardSwitching { get; set; }

  /// <summary>
  /// The document view direction.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.documentviewdirection?view=word-pia"/>
  public WdDocumentViewDirection DocumentViewDirection { get; set; }

  /// <summary>
  /// The arabic numeral.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.arabicnumeral?view=word-pia"/>
  public WdArabicNumeral ArabicNumeral { get; set; }

  /// <summary>
  /// The month names.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.monthnames?view=word-pia"/>
  public WdMonthNames MonthNames { get; set; }

  /// <summary>
  /// The cursor movement.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.cursormovement?view=word-pia"/>
  public WdCursorMovement CursorMovement { get; set; }

  /// <summary>
  /// The visual selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.visualselection?view=word-pia"/>
  public WdVisualSelection VisualSelection { get; set; }

  /// <summary>
  /// The show diacritics.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showdiacritics?view=word-pia"/>
  public bool ShowDiacritics { get; set; }

  /// <summary>
  /// The show control characters.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showcontrolcharacters?view=word-pia"/>
  public bool ShowControlCharacters { get; set; }

  /// <summary>
  /// The add control characters.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addcontrolcharacters?view=word-pia"/>
  public bool AddControlCharacters { get; set; }

  /// <summary>
  /// The add bi directional marks when saving text file.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addbidirectionalmarkswhensavingtextfile?view=word-pia"/>
  public bool AddBiDirectionalMarksWhenSavingTextFile { get; set; }

  /// <summary>
  /// The strict initial alef hamza.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictinitialalefhamza?view=word-pia"/>
  public bool StrictInitialAlefHamza { get; set; }

  /// <summary>
  /// The strict final yaa.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictfinalyaa?view=word-pia"/>
  public bool StrictFinalYaa { get; set; }

  /// <summary>
  /// The hebrew mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.hebrewmode?view=word-pia"/>
  public WdHebSpellStart HebrewMode { get; set; }

  /// <summary>
  /// The arabic mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.arabicmode?view=word-pia"/>
  public WdAraSpeller ArabicMode { get; set; }

  /// <summary>
  /// The allow click and type mouse.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowclickandtypemouse?view=word-pia"/>
  public bool AllowClickAndTypeMouse { get; set; }

  /// <summary>
  /// The use german spelling reform.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usegermanspellingreform?view=word-pia"/>
  public bool UseGermanSpellingReform { get; set; }

  /// <summary>
  /// The interpret high ansi.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.interprethighansi?view=word-pia"/>
  public WdHighAnsiText InterpretHighAnsi { get; set; }

  /// <summary>
  /// The add heb double quote.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addhebdoublequote?view=word-pia"/>
  public bool AddHebDoubleQuote { get; set; }

  /// <summary>
  /// The use diff diac color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usediffdiaccolor?view=word-pia"/>
  public bool UseDiffDiacColor { get; set; }

  /// <summary>
  /// The diacritic color val.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.diacriticcolorval?view=word-pia"/>
  public WdColor DiacriticColorVal { get; set; }

  /// <summary>
  /// The optimize for word97by default.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.optimizeforword97bydefault?view=word-pia"/>
  public bool OptimizeForWord97byDefault { get; set; }

  /// <summary>
  /// The local network file.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.localnetworkfile?view=word-pia"/>
  public bool LocalNetworkFile { get; set; }

  /// <summary>
  /// The type nreplace.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.typenreplace?view=word-pia"/>
  public bool TypeNReplace { get; set; }

  /// <summary>
  /// The sequence check.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.sequencecheck?view=word-pia"/>
  public bool SequenceCheck { get; set; }

  /// <summary>
  /// The background open.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.backgroundopen?view=word-pia"/>
  public bool BackgroundOpen { get; set; }

  /// <summary>
  /// The disable featuresby default.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.disablefeaturesbydefault?view=word-pia"/>
  public bool DisableFeaturesbyDefault { get; set; }

  /// <summary>
  /// The paste adjust word spacing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjustwordspacing?view=word-pia"/>
  public bool PasteAdjustWordSpacing { get; set; }

  /// <summary>
  /// The paste adjust paragraph spacing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjustparagraphspacing?view=word-pia"/>
  public bool PasteAdjustParagraphSpacing { get; set; }

  /// <summary>
  /// The paste adjust table formatting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjusttableformatting?view=word-pia"/>
  public bool PasteAdjustTableFormatting { get; set; }

  /// <summary>
  /// The paste smart style behavior.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastesmartstylebehavior?view=word-pia"/>
  public bool PasteSmartStyleBehavior { get; set; }

  /// <summary>
  /// The paste merge from ppt.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergefromppt?view=word-pia"/>
  public bool PasteMergeFromPPT { get; set; }

  /// <summary>
  /// The paste merge from xl.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergefromxl?view=word-pia"/>
  public bool PasteMergeFromXL { get; set; }

  /// <summary>
  /// The ctrl click hyperlink to open.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ctrlclickhyperlinktoopen?view=word-pia"/>
  public bool CtrlClickHyperlinkToOpen { get; set; }

  /// <summary>
  /// The picture wrap type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.picturewraptype?view=word-pia"/>
  public WdWrapTypeMerged PictureWrapType { get; set; }

  /// <summary>
  /// The disable features introduced afterby default.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.disablefeaturesintroducedafterbydefault?view=word-pia"/>
  public WdDisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfterbyDefault { get; set; }

  /// <summary>
  /// The paste smart cut paste.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastesmartcutpaste?view=word-pia"/>
  public bool PasteSmartCutPaste { get; set; }

  /// <summary>
  /// The display paste options.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaypasteoptions?view=word-pia"/>
  public bool DisplayPasteOptions { get; set; }

  /// <summary>
  /// The prompt update style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.promptupdatestyle?view=word-pia"/>
  public bool PromptUpdateStyle { get; set; }

  /// <summary>
  /// The default epostage app.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultepostageapp?view=word-pia"/>
  public string DefaultEPostageApp { get; set; }

  /// <summary>
  /// The default text encoding.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttextencoding?view=word-pia"/>
  public Core.MsoEncoding DefaultTextEncoding { get; set; }

  /// <summary>
  /// The label smart tags.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.labelsmarttags?view=word-pia"/>
  public bool LabelSmartTags { get; set; }

  /// <summary>
  /// The display smart tag buttons.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaysmarttagbuttons?view=word-pia"/>
  public bool DisplaySmartTagButtons { get; set; }

  /// <summary>
  /// The warn before saving printing sending markup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.warnbeforesavingprintingsendingmarkup?view=word-pia"/>
  public bool WarnBeforeSavingPrintingSendingMarkup { get; set; }

  /// <summary>
  /// The store rsidon save.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.storersidonsave?view=word-pia"/>
  public bool StoreRSIDOnSave { get; set; }

  /// <summary>
  /// The show format error.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showformaterror?view=word-pia"/>
  public bool ShowFormatError { get; set; }

  /// <summary>
  /// The format scanning.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.formatscanning?view=word-pia"/>
  public bool FormatScanning { get; set; }

  /// <summary>
  /// The paste merge lists.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergelists?view=word-pia"/>
  public bool PasteMergeLists { get; set; }

  /// <summary>
  /// The auto create new drawings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autocreatenewdrawings?view=word-pia"/>
  public bool AutoCreateNewDrawings { get; set; }

  /// <summary>
  /// The smart para selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartparaselection?view=word-pia"/>
  public bool SmartParaSelection { get; set; }

  /// <summary>
  /// The revisions balloon print orientation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisionsballoonprintorientation?view=word-pia"/>
  public WdRevisionsBalloonPrintOrientation RevisionsBalloonPrintOrientation { get; set; }

  /// <summary>
  /// The comments color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.commentscolor?view=word-pia"/>
  public WdColorIndex CommentsColor { get; set; }

  /// <summary>
  /// The print xmltag.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printxmltag?view=word-pia"/>
  public bool PrintXMLTag { get; set; }

  /// <summary>
  /// The print backgrounds.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printbackgrounds?view=word-pia"/>
  public bool PrintBackgrounds { get; set; }

  /// <summary>
  /// The allow reading mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowreadingmode?view=word-pia"/>
  public bool AllowReadingMode { get; set; }

  /// <summary>
  /// The show markup open save.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showmarkupopensave?view=word-pia"/>
  public bool ShowMarkupOpenSave { get; set; }

  /// <summary>
  /// The smart cursoring.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartcursoring?view=word-pia"/>
  public bool SmartCursoring { get; set; }

  /// <summary>
  /// The move to text mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movetotextmark?view=word-pia"/>
  public WdMoveToTextMark MoveToTextMark { get; set; }

  /// <summary>
  /// The move from text mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movefromtextmark?view=word-pia"/>
  public WdMoveFromTextMark MoveFromTextMark { get; set; }

  /// <summary>
  /// The bibliography style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bibliographystyle?view=word-pia"/>
  public string BibliographyStyle { get; set; }

  /// <summary>
  /// The bibliography sort.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bibliographysort?view=word-pia"/>
  public string BibliographySort { get; set; }

  /// <summary>
  /// The inserted cell color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedcellcolor?view=word-pia"/>
  public WdCellColor InsertedCellColor { get; set; }

  /// <summary>
  /// The deleted cell color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedcellcolor?view=word-pia"/>
  public WdCellColor DeletedCellColor { get; set; }

  /// <summary>
  /// The merged cell color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.mergedcellcolor?view=word-pia"/>
  public WdCellColor MergedCellColor { get; set; }

  /// <summary>
  /// The split cell color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.splitcellcolor?view=word-pia"/>
  public WdCellColor SplitCellColor { get; set; }

  /// <summary>
  /// The show selection floaties.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showselectionfloaties?view=word-pia"/>
  public bool ShowSelectionFloaties { get; set; }

  /// <summary>
  /// The show menu floaties.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showmenufloaties?view=word-pia"/>
  public bool ShowMenuFloaties { get; set; }

  /// <summary>
  /// The show dev tools.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showdevtools?view=word-pia"/>
  public bool ShowDevTools { get; set; }

  /// <summary>
  /// The enable live preview.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelivepreview?view=word-pia"/>
  public bool EnableLivePreview { get; set; }

  /// <summary>
  /// The omath auto build up.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.omathautobuildup?view=word-pia"/>
  public bool OMathAutoBuildUp { get; set; }

  /// <summary>
  /// The always use clear type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.alwaysusecleartype?view=word-pia"/>
  public bool AlwaysUseClearType { get; set; }

  /// <summary>
  /// The paste format within document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatwithindocument?view=word-pia"/>
  public WdPasteOptions PasteFormatWithinDocument { get; set; }

  /// <summary>
  /// The paste format between documents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatbetweendocuments?view=word-pia"/>
  public WdPasteOptions PasteFormatBetweenDocuments { get; set; }

  /// <summary>
  /// The paste format between styled documents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatbetweenstyleddocuments?view=word-pia"/>
  public WdPasteOptions PasteFormatBetweenStyledDocuments { get; set; }

  /// <summary>
  /// The paste format from external source.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatfromexternalsource?view=word-pia"/>
  public WdPasteOptions PasteFormatFromExternalSource { get; set; }

  /// <summary>
  /// The paste option keep bullets and numbers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteoptionkeepbulletsandnumbers?view=word-pia"/>
  public bool PasteOptionKeepBulletsAndNumbers { get; set; }

  /// <summary>
  /// The inskey for overtype.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inskeyforovertype?view=word-pia"/>
  public bool INSKeyForOvertype { get; set; }

  /// <summary>
  /// The repeat word.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.repeatword?view=word-pia"/>
  public bool RepeatWord { get; set; }

  /// <summary>
  /// The french reform.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.frenchreform?view=word-pia"/>
  public WdFrenchSpeller FrenchReform { get; set; }

  /// <summary>
  /// The contextual speller.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.contextualspeller?view=word-pia"/>
  public bool ContextualSpeller { get; set; }

  /// <summary>
  /// The move to text color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movetotextcolor?view=word-pia"/>
  public WdColorIndex MoveToTextColor { get; set; }

  /// <summary>
  /// The move from text color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movefromtextcolor?view=word-pia"/>
  public WdColorIndex MoveFromTextColor { get; set; }

  /// <summary>
  /// The omath copy lf.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.omathcopylf?view=word-pia"/>
  public bool OMathCopyLF { get; set; }

  /// <summary>
  /// The use normal style for list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usenormalstyleforlist?view=word-pia"/>
  public bool UseNormalStyleForList { get; set; }

  /// <summary>
  /// The allow open in draft view.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowopenindraftview?view=word-pia"/>
  public bool AllowOpenInDraftView { get; set; }

  /// <summary>
  /// The enable legacy imemode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelegacyimemode?view=word-pia"/>
  public bool EnableLegacyIMEMode { get; set; }

  /// <summary>
  /// The do not prompt for convert.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.donotpromptforconvert?view=word-pia"/>
  public bool DoNotPromptForConvert { get; set; }

  /// <summary>
  /// The precise positioning.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.precisepositioning?view=word-pia"/>
  public bool PrecisePositioning { get; set; }

  /// <summary>
  /// The update style list behavior.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatestylelistbehavior?view=word-pia"/>
  public WdUpdateStyleListBehavior UpdateStyleListBehavior { get; set; }

  /// <summary>
  /// The strict taa marboota.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.stricttaamarboota?view=word-pia"/>
  public bool StrictTaaMarboota { get; set; }

  /// <summary>
  /// The strict russian e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictrussiane?view=word-pia"/>
  public bool StrictRussianE { get; set; }

  /// <summary>
  /// The spanish mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.spanishmode?view=word-pia"/>
  public WdSpanishSpeller SpanishMode { get; set; }

  /// <summary>
  /// The portugal reform.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.portugalreform?view=word-pia"/>
  public WdPortugueseReform PortugalReform { get; set; }

  /// <summary>
  /// The brazil reform.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.brazilreform?view=word-pia"/>
  public WdPortugueseReform BrazilReform { get; set; }

  /// <summary>
  /// The update fields with tracked changes at print.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatefieldswithtrackedchangesatprint?view=word-pia"/>
  public bool UpdateFieldsWithTrackedChangesAtPrint { get; set; }

  /// <summary>
  /// The display alignment guides.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displayalignmentguides?view=word-pia"/>
  public bool DisplayAlignmentGuides { get; set; }

  /// <summary>
  /// The page alignment guides.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pagealignmentguides?view=word-pia"/>
  public bool PageAlignmentGuides { get; set; }

  /// <summary>
  /// The margin alignment guides.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.marginalignmentguides?view=word-pia"/>
  public bool MarginAlignmentGuides { get; set; }

  /// <summary>
  /// The paragraph alignment guides.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.paragraphalignmentguides?view=word-pia"/>
  public bool ParagraphAlignmentGuides { get; set; }

  /// <summary>
  /// The enable live drag.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelivedrag?view=word-pia"/>
  public bool EnableLiveDrag { get; set; }

  /// <summary>
  /// The use sub pixel positioning.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usesubpixelpositioning?view=word-pia"/>
  public bool UseSubPixelPositioning { get; set; }

  /// <summary>
  /// The alert if not default.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.alertifnotdefault?view=word-pia"/>
  public bool AlertIfNotDefault { get; set; }

  /// <summary>
  /// The enable proofing tools advertisement.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enableproofingtoolsadvertisement?view=word-pia"/>
  public bool EnableProofingToolsAdvertisement { get; set; }

  /// <summary>
  /// The prefer cloud save locations.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.prefercloudsavelocations?view=word-pia"/>
  public bool PreferCloudSaveLocations { get; set; }

  /// <summary>
  /// The sky drive sign in option.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.skydrivesigninoption?view=word-pia"/>
  public bool SkyDriveSignInOption { get; set; }

  /// <summary>
  /// The expand headings on open.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.expandheadingsonopen?view=word-pia"/>
  public bool ExpandHeadingsOnOpen { get; set; }

  /// <summary>
  /// The use local user info.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.uselocaluserinfo?view=word-pia"/>
  public bool UseLocalUserInfo { get; set; }

  /// <summary>
  /// The cloud sign in option.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.cloudsigninoption?view=word-pia"/>
  public bool CloudSignInOption { get; set; }
}
