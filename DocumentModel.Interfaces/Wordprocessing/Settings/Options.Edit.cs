using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface IOptions : IModelObject
{

  /// <summary> 
  /// Returns or sets a Boolean (bool in C#) that is True if users are notified if Word is not the default program 
  /// for viewing and editing documents. Read-write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.alertifnotdefault?view=word-pia"/>
  public bool? AlertIfNotDefault { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Click and Type functionality is enabled. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowclickandtypemouse?view=word-pia"/>
  public bool? AllowClickAndTypeMouse { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if dragging and dropping can be used to move or copy a selection. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowdraganddrop?view=word-pia"/>
  public bool? AllowDragAndDrop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word saves only changes to a document. When reopening the document, Word uses the saved 
  /// changes to reconstruct the document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowfastsave?view=word-pia"/>
  public bool? AllowFastSave { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether to allow users to open documents in draft view. 
  /// Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowopenindraftview?view=word-pia"/>
  public bool? AllowOpenInDraftView { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True indicates that Microsoft Word opens documents in Reading Layout view. Corresponds to the Allow starting 
  /// in Reading Layout check box on the General tab of the Options dialog box. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowreadingmode?view=word-pia"/>
  public bool? AllowReadingMode { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True for Microsoft Word to draw newly created shapes in a drawing canvas. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autocreatenewdrawings?view=word-pia"/>
  public bool? AutoCreateNewDrawings { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if dragging selects one word at a time instead of one character at a time. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.autowordselection?view=word-pia"/>
  public bool? AutoWordSelection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True for Microsoft Word to open Web documents in the background. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.backgroundopen?view=word-pia"/>
  public bool? BackgroundOpen { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word saves documents in the background. When Word is saving in the background, users can 
  /// continue to type and to choose commands. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.backgroundsave?view=word-pia"/>
  public bool? BackgroundSave { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the number of clicks (either one or two) required to run a GOTOBUTTON or MACROBUTTON field. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.buttonfieldclicks?view=word-pia"/>
  public int? ButtonFieldClicks { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets whether cloud sign in option. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.cloudsigninoption?view=word-pia"/>
  public bool? CloudSignInOption { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word displays the Convert File dialog box before it opens or inserts a file that isn't a 
  /// Word document or template. In the Convert File dialog box, the user chooses the format to convert the file 
  /// from. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.confirmconversions?view=word-pia"/>
  public bool? ConfirmConversions { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word creates a backup copy each time a document is saved. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.createbackup?view=word-pia"/>
  public bool? CreateBackup { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word requires holding down the CTRL key while clicking to open a hyperlink. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.ctrlclickhyperlinktoopen?view=word-pia"/>
  public bool? CtrlClickHyperlinkToOpen { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets how the insertion point progresses within bidirectional text. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.cursormovement?view=word-pia"/>
  public CursorMovement? CursorMovement { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Sets or returns a String that represents the path and file name of the default electronic postage 
  /// application. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultepostageapp?view=word-pia"/>
  public string? DefaultEPostageApp { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the default file converter used to open documents. Can be a number returned by the 
  /// OpenFormat property, or one of the OpenFormat constants. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultopenformat?view=word-pia"/>
  public OpenFormat? DefaultOpenFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the default tray your printer uses to print documents. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttray?view=word-pia"/>
  public string? DefaultTray { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the default tray your printer uses to print documents. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulttrayid?view=word-pia"/>
  public int? DefaultTrayID { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True for Microsoft Word to disable in all documents all features introduced after the version of Word 
  /// specified in the DisableFeaturesIntroducedAfterByDefault property. The default value is False. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.disablefeaturesbydefault?view=word-pia"/>
  public bool? DisableFeaturesByDefault { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Disables all features introduced after a specified version for all documents. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.disablefeaturesintroducedafterbydefault?view=word-pia"/>
  public DisableFeaturesIntroducedAfter? DisableFeaturesIntroducedAfterByDefault { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Sets or returns a Boolean that represents whether to prompt a warning dialog when the Convert command is 
  /// invoked for documents that are in compatibility mode. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.donotpromptforconvert?view=word-pia"/>
  public bool? DoNotPromptForConvert { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a Boolean (bool in C#) that is True if live drag is enabled. Read-write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelivedrag?view=word-pia"/>
  public bool? EnableLiveDrag { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Sets or returns a Boolean that represents whether to show or hide gallery previews that appear when using 
  /// galleries that support previewing. True shows a preview in your document before applying the command. 
  /// Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelivepreview?view=word-pia"/>
  public bool? EnableLivePreview { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word makes the computer respond with a sound whenever an error occurs. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablesound?view=word-pia"/>
  public bool? EnableSound { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if the current printer has a special feeder for envelopes. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.envelopefeederinstalled?view=word-pia"/>
  public bool? EnvelopeFeederInstalled { get; }

  /// <summary> 
  /// True to expand all headings in the document when the document opens. Read/write Boolean (bool in C#). 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.expandheadingsonopen?view=word-pia"/>
  public bool? ExpandHeadingsOnOpen { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True for Microsoft Word to keep track of all formatting in a document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.formatscanning?view=word-pia"/>
  public bool? FormatScanning { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if the INS key can be used for switching Overtype on and off. Read/write Boolean. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inskeyforovertype?view=word-pia"/>
  public bool? INSKeyForOvertype { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if the INS key can be used for pasting the Clipboard contents. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inskeyforpaste?view=word-pia"/>
  public bool? INSKeyForPaste { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word creates a local copy of a file on the user's machine when editing a file stored on a 
  /// network server. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.localnetworkfile?view=word-pia"/>
  public bool? LocalNetworkFile { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if documents formatted for another country's/region's standard paper size (for example, A4) are 
  /// automatically adjusted so that they're printed correctly on your country's/region's standard paper size (for 
  /// example, Letter). 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.mappapersize?view=word-pia"/>
  public bool? MapPaperSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Overtype mode is active. 
  /// </summary> 
  /// <remarks> 
  /// In Overtype mode, the characters you type replace existing characters one by one. 
  /// When Overtype isn't active, the characters you type move existing text to the right. 
  /// </remarks> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.overtype?view=word-pia"/>
  public bool? Overtype { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word repaginates documents in the background. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pagination?view=word-pia"/>
  public bool? Pagination { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word optimizes all new documents for viewing in Word 97 by disabling any incompatible 
  /// formatting. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.optimizeforword97bydefault?view=word-pia"/>
  public bool? OptimizeForWord97ByDefault { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word automatically adjusts the spacing of paragraphs when cutting and pasting selections. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjustparagraphspacing?view=word-pia"/>
  public bool? PasteAdjustParagraphSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word automatically adjusts the formatting of tables when cutting and pasting selections. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjusttableformatting?view=word-pia"/>
  public bool? PasteAdjustTableFormatting { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word automatically adjusts the spacing of words when cutting and pasting selections. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteadjustwordspacing?view=word-pia"/>
  public bool? PasteAdjustWordSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a PasteOptions constant that represents how text is pasted when text is copied from 
  /// another Microsoft Office Word document. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatbetweendocuments?view=word-pia"/>
  public PasteOptions? PasteFormatBetweenDocuments { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a PasteOptions constant that represents how text is pasted when text is copied from a 
  /// document that uses styles. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatbetweenstyleddocuments?view=word-pia"/>
  public PasteOptions? PasteFormatBetweenStyledDocuments { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a PasteOptions constant that represents how text is pasted when text is copied from an 
  /// external source, such as a Web page. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatfromexternalsource?view=word-pia"/>
  public PasteOptions? PasteFormatFromExternalSource { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a PasteOptions constant that represents how text is pasted when text is copied or cut and 
  /// then pasted in the same document. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteformatwithindocument?view=word-pia"/>
  public PasteOptions? PasteFormatWithinDocument { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True to merge text formatting when pasting from Microsoft PowerPoint. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergefromppt?view=word-pia"/>
  public bool? PasteMergeFromPPT { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True to merge table formatting when pasting from Microsoft Excel. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergefromxl?view=word-pia"/>
  public bool? PasteMergeFromXL { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True to merge the formatting of pasted lists with surrounding lists. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastemergelists?view=word-pia"/>
  public bool? PasteMergeLists { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether to keep bullets and numbering when selecting Keep text 
  /// only from the Paste Options context menu. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pasteoptionkeepbulletsandnumbers?view=word-pia"/>
  public bool? PasteOptionKeepBulletsAndNumbers { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word intelligently pastes selections into a document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastesmartcutpaste?view=word-pia"/>
  public bool? PasteSmartCutPaste { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word intelligently merges styles when pasting a selection from a different document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pastesmartstylebehavior?view=word-pia"/>
  public bool? PasteSmartStyleBehavior { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the name of the application to use to edit pictures. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pictureeditor?view=word-pia"/>
  public string? PictureEditor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True to save new documents in web locations by default. Read/write Boolean (bool in C#). 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.prefercloudsavelocations?view=word-pia"/>
  public bool? PreferCloudSaveLocations { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints in the background. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printbackground?view=word-pia"/>
  public bool? PrintBackground { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns a Boolean that represents whether background colors and images are printed when a document is 
  /// printed. True indicates that background colors and images are printed. False indicates that background 
  /// colors and images are not printed. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printbackgrounds?view=word-pia"/>
  public bool? PrintBackgrounds { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints comments, starting on a new page at the end of the document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printcomments?view=word-pia"/>
  public bool? PrintComments { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints using minimal formatting. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printdraft?view=word-pia"/>
  public bool? PrintDraft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints drawing objects. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printdrawingobjects?view=word-pia"/>
  public bool? PrintDrawingObjects { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints even pages in ascending order during manual duplex printing. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printevenpagesinascendingorder?view=word-pia"/>
  public bool? PrintEvenPagesInAscendingOrder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints field codes instead of field results. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printfieldcodes?view=word-pia"/>
  public bool? PrintFieldCodes { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if hidden text is printed. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printhiddentext?view=word-pia"/>
  public bool? PrintHiddenText { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints odd pages in ascending order during manual duplex printing. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printoddpagesinascendingorder?view=word-pia"/>
  public bool? PrintOddPagesInAscendingOrder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints document summary information on a separate page at the end of the document. 
  /// False if document summary information is not printed. Summary information is found in the Properties dialog 
  /// box (File menu). 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printproperties?view=word-pia"/>
  public bool? PrintProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prints pages in reverse order. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printreverse?view=word-pia"/>
  public bool? PrintReverse { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns a Boolean that represents whether to print the XML tags when printing a document. Corresponds to the 
  /// XML tags check box on the Print tab in the Options dialog box. True indicates that tags are printed. False 
  /// indicates tags are not printed. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.printxmltag?view=word-pia"/>
  public bool? PrintXMLTag { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True displays a message asking the user to verify whether they want to reformat a style or reapply the 
  /// original style formatting when changing the formatting of styles. False reapplies the style formatting to 
  /// the selection without verifying whether the user wants to change the style. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.promptupdatestyle?view=word-pia"/>
  public bool? PromptUpdateStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if the result of typing or pasting replaces the selection. False if the result of typing or pasting is 
  /// added before the selection, leaving the selection intact. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.replaceselection?view=word-pia"/>
  public bool? ReplaceSelection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// You have requested Help for a keyword used only on the Macintosh. For information about this keyword, 
  /// consult the language reference Help included with Microsoft Office Macintosh Edition. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.rtfinclipboard?view=word-pia"/>
  public bool? RTFInClipboard { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the time interval in minutes for saving AutoRecover information. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.saveinterval?view=word-pia"/>
  public int? SaveInterval { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prompts the user for confirmation to save changes to the Normal template before it 
  /// quits. False if Word automatically saves changes to the Normal template before it quits. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.savenormalprompt?view=word-pia"/>
  public bool? SaveNormalPrompt { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word prompts for document property information when saving a new document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.savepropertiesprompt?view=word-pia"/>
  public bool? SavePropertiesPrompt { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if the Send To command on the File menu inserts the active document as an attachment to a mail message. 
  /// False if the Send To command inserts the contents of the active document as text in a mail message. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.sendmailattach?view=word-pia"/>
  public bool? SendMailAttach { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets whether sky drive sign in option. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.skydrivesigninoption?view=word-pia"/>
  public bool? SkyDriveSignInOption { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether smart cursoring is enabled. True enables smart cursoring. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartcursoring?view=word-pia"/>
  public bool? SmartCursoring { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word automatically adjusts the spacing between words and punctuation when cutting and 
  /// pasting occurs. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartcutpaste?view=word-pia"/>
  public bool? SmartCutPaste { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True for Microsoft Word to include the paragraph mark in a selection when selecting most or all of a 
  /// paragraph. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.smartparaselection?view=word-pia"/>
  public bool? SmartParaSelection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True for Microsoft Word to assign a random number to changes in a document, each time a document is saved, 
  /// to facilitate comparing and merging documents. Word stores the random numbers in a table and updates the 
  /// table after each save. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.storersidonsave?view=word-pia"/>
  public bool? StoreRSIDOnSave { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if the TAB and BACKSPACE keys can be used to increase and decrease, respectively, the left indent of 
  /// paragraphs and if the BACKSPACE key can be used to change right-aligned paragraphs to centered paragraphs 
  /// and centered paragraphs to left-aligned paragraphs. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.tabindentkey?view=word-pia"/>
  public bool? TabIndentKey { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True for Microsoft Word to replace illegal South Asian characters. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.typenreplace?view=word-pia"/>
  public bool? TypeNReplace { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word updates fields automatically before printing a document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatefieldsatprint?view=word-pia"/>
  public bool? UpdateFieldsAtPrint { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Gets or sets whether Word 2010 allows fields containing tracked changes to update before printing. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatefieldswithtrackedchangesatprint?view=word-pia"/>
  public bool? UpdateFieldsWithTrackedChangesAtPrint { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word automatically updates all embedded OLE links in a document when it's opened. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatelinksatopen?view=word-pia"/>
  public bool? UpdateLinksAtOpen { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word updates embedded links to other files before printing a document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatelinksatprint?view=word-pia"/>
  public bool? UpdateLinksAtPrint { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Gets or sets a UpdateStyleListBehavior constant that specifies the behavior Word 2010 should take when 
  /// updating a style to match a selection that contains numbering or bullets. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.updatestylelistbehavior?view=word-pia"/>
  public UpdateStyleListBehavior? UpdateStyleListBehavior { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word uses pixels as the default unit of measurement for HTML features that support 
  /// measurements. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowpixelunits?view=word-pia"/>
  public bool? AllowPixelUnits { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a String that represents the order in which to display sources in the Source Manager dialog 
  /// box. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bibliographysort?view=word-pia"/>
  public string? BibliographySort { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a String that represents the name of the style to use for formatting bibliographies. 
  /// Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bibliographystyle?view=word-pia"/>
  public string? BibliographyStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the alignment and reading order for the entire document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.documentviewdirection?view=word-pia"/>
  public DocumentViewDirection? DocumentViewDirection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the standard measurement unit for Microsoft Word. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.measurementunit?view=word-pia"/>
  public MeasurementUnits? MeasurementUnit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if Microsoft Word uses characters as the default measurement unit for the current document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usecharacterunit?view=word-pia"/>
  public bool? UseCharacterUnit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a Boolean; True if Microsoft Word identifies the document author based upon the User name 
  /// and Initials settings on the General tab of the Options dialog box, and False if Word identifies the author 
  /// based on the account information with which the user signed in to Office. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.uselocaluserinfo?view=word-pia"/>
  public bool? UseLocalUserInfo { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether Microsoft Office Word uses the Normal style for bullets 
  /// and numbering. Read/write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usenormalstyleforlist?view=word-pia"/>
  public bool? UseNormalStyleForList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets a Boolean (bool in C#) that specifies whether sub-pixel positioning is enabled. Read-write. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usesubpixelpositioning?view=word-pia"/>
  public bool? UseSubPixelPositioning { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Reserved for internal use. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.virusprotection?view=word-pia"/>
  public bool? VirusProtection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// Returns or sets the selection behavior based on visual cursor movement in a right-to-left language document. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.visualselection?view=word-pia"/>
  public VisualSelection? VisualSelection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True for Microsoft Word to display a warning when saving, printing, or sending as e-mail a document 
  /// containing comments or tracked changes. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.warnbeforesavingprintingsendingmarkup?view=word-pia"/>
  public bool? WarnBeforeSavingPrintingSendingMarkup { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True to enable in Microsoft Word navigation keys for WordPerfect users. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.wpdocnavkeys?view=word-pia"/>
  public bool? WPDocNavKeys { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary> 
  /// True if pressing Microsoft Word key combinations that produce actions in WordPerfect displays dialog boxes 
  /// that describe how to perform the equivalent actions in Word. 
  /// </summary> 
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.wphelp?view=word-pia"/>
  public bool? WPHelp { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}