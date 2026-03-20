namespace DocumentModel.Interop;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see Application.
/// </summary>
public partial interface _Application : InteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// Returns a Documents collection that represents all the open documents.
  /// </summary>
  public Documents Documents { get; }

  /// <summary>
  /// Returns a Windows collection that represents all document windows.
  /// </summary>
  public Windows Windows { get; }

  /// <summary>
  /// Returns a Document object that represents the active document.
  /// </summary>
  public Document ActiveDocument { get; }

  /// <summary>
  /// Returns a Window object that represents the active window.
  /// </summary>
  public Window ActiveWindow { get; }

  /// <summary>
  /// Returns the Selection object that represents a selected range or the insertion point.
  /// </summary>
  public Selection Selection { get; }

  /// <summary>
  /// Returns an automation object (Word.Basic) that includes methods for all the WordBasic statements and functions available in Microsoft Word version 6.0 and Word for Windows 95.
  /// </summary>
  public object WordBasic { get; }

  /// <summary>
  /// Returns a RecentFiles collection that represents the most recently accessed files.
  /// </summary>
  public RecentFiles RecentFiles { get; }

  /// <summary>
  /// Returns a Template object that represents the Normal template.
  /// </summary>
  public Template NormalTemplate { get; }

  /// <summary>
  /// Returns a System object, which can be used to return system-related information and perform system-related tasks.
  /// </summary>
  public System System { get; }

  /// <summary>
  /// Returns a AutoCorrect object that contains the current AutoCorrect options, entries, and exceptions.
  /// </summary>
  public AutoCorrect AutoCorrect { get; }

  /// <summary>
  /// Returns a FontNames object that includes the names of all the available fonts.
  /// </summary>
  public FontNames FontNames { get; }

  /// <summary>
  /// Returns a FontNames object that includes the names of all the available landscape fonts.
  /// </summary>
  public FontNames LandscapeFontNames { get; }

  /// <summary>
  /// Returns a FontNames object that includes the names of all the available portrait fonts.
  /// </summary>
  public FontNames PortraitFontNames { get; }

  /// <summary>
  /// Returns a Languages collection that represents the proofing languages listed in the Language dialog box.
  /// </summary>
  public Languages Languages { get; }

  /// <summary>
  /// Returns a Assistant object that represents the Microsoft Office Assistant.
  /// </summary>
  //public Core.Assistant Assistant { get; }

  /// <summary>
  /// Returns a Browser object that represents the Select Browse Object tool on the vertical scroll bar.
  /// </summary>
  public Browser Browser { get; }

  /// <summary>
  /// Returns a FileConverters collection that represents all the file converters available to Microsoft Word.
  /// </summary>
  public FileConverters FileConverters { get; }

  /// <summary>
  /// Returns a MailingLabel object that represents a mailing label.
  /// </summary>
  public MailingLabel MailingLabel { get; }

  /// <summary>
  /// Returns a Dialogs collection that represents all the built-in dialog boxes in Microsoft Word.
  /// </summary>
  public Dialogs Dialogs { get; }

  /// <summary>
  /// Returns a CaptionLabels collection that represents all the available caption labels.
  /// </summary>
  public CaptionLabels CaptionLabels { get; }

  /// <summary>
  /// Returns a AutoCaptions collection that represents the captions that are automatically added when items such as tables and pictures are inserted into a document.
  /// </summary>
  public AutoCaptions AutoCaptions { get; }

  /// <summary>
  /// Returns a AddIns collection that represents all available add-ins, regardless of whether they're currently loaded.
  /// </summary>
  public AddIns AddIns { get; }

  /// <summary>
  /// Determines if the specified object is visible. This property returns True if the specified object is visible, and False if not.
  /// </summary>
  public bool Visible { get; set; }

  /// <summary>
  /// Returns the Microsoft Word version number.
  /// </summary>
  public string Version { get; }

  /// <summary>
  /// Determines if screen updating is turned on. Returns True if screen updating is turned on, and False if not.
  /// </summary>
  public bool ScreenUpdating { get; set; }

  /// <summary>
  /// Determines if print preview is the current view. This property returns True if print preview is the current view, and False if not.
  /// </summary>
  public bool PrintPreview { get; set; }

  /// <summary>
  /// Returns a Tasks collection that represents all the applications that are running.
  /// </summary>
  public Tasks Tasks { get; }

  /// <summary>
  /// Determines if the status bar is displayed.
  /// </summary>
  public bool DisplayStatusBar { get; set; }

  /// <summary>
  /// Determines if Microsoft Word is in a special mode (for example, CopyText mode or MoveText mode).
  /// </summary>
  public bool SpecialMode { get; }

  /// <summary>
  /// Returns the maximum width (in points) to which you can set the width of a Microsoft Word document window.
  /// </summary>
  public int UsableWidth { get; }

  /// <summary>
  /// Returns the maximum height (in points) to which you can set the height of a Microsoft Word document window.
  /// </summary>
  public int UsableHeight { get; }

  /// <summary>
  /// Determines if a math coprocessor is installed and available to Microsoft Word. This property returns True if a math coprocessor is installed and available to Microsoft Word, and False if not.
  /// </summary>
  public bool MathCoprocessorAvailable { get; }

  /// <summary>
  /// Determines if there's a mouse available for the system. This property returns True if there's a mouse available for the system, and False if not.
  /// </summary>
  public bool MouseAvailable { get; }

  /// <summary>
  /// Returns the version and build number of the Word application.
  /// </summary>
  public string Build { get; }

  /// <summary>
  /// Determines if the CAPS LOCK key is turned on. Returns True if the CAPS LOCK key is turned on, and False if it is not.
  /// </summary>
  public bool CapsLock { get; }

  /// <summary>
  /// Returns the state of the NUM LOCK key. Returns True if the keys on the numeric keypad insert numbers, and False if the keys move the insertion point.
  /// </summary>
  public bool NumLock { get; }

  /// <summary>
  /// Returns or sets the user's name, which is used on envelopes and for the Author document property.
  /// </summary>
  public string UserName { get; set; }

  /// <summary>
  /// Returns or sets the user's initials, which Microsoft Word uses to construct comment marks.
  /// </summary>
  public string UserInitials { get; set; }

  /// <summary>
  /// Returns or sets the user's mailing address.
  /// </summary>
  public string UserAddress { get; set; }

  /// <summary>
  /// Returns a Template or Document object that represents the template or document in which the module that contains the running procedure is stored.
  /// </summary>
  public object MacroContainer { get; }

  /// <summary>
  /// Determines if the names of recently used files are displayed on the File menu.
  /// </summary>
  public bool DisplayRecentFiles { get; set; }

  /// <summary>
  /// Returns a CommandBars collection that represents the menu bar and all the toolbars in Microsoft Word.
  /// </summary>
  //public Core.CommandBars CommandBars { get; }

  /// <summary>
  /// Returns a VBE object that represents the Visual Basic Editor.
  /// </summary>
  public VBE.VBE VBE { get; }

  /// <summary>
  /// Returns or sets the default format that will appear in the Save as type box in the Save As dialog box (File menu).
  /// </summary>
  public string DefaultSaveFormat { get; set; }

  /// <summary>
  /// Returns a ListGalleries collection that represents the three list template galleries (Bulleted, Numbered, and Outline Numbered).
  /// </summary>
  public ListGalleries ListGalleries { get; }

  /// <summary>
  /// Returns or sets the name of the active printer.
  /// </summary>
  public string ActivePrinter { get; set; }

  /// <summary>
  /// Returns a Templates collection that represents all the available templates Ă„â€šĂ‹ÂÄ‚â€šĂ˘â€šÂ¬Ä‚â€šĂ˘â‚¬ĹĄ global templates as well as those attached to open documents.
  /// </summary>
  public Templates Templates { get; }

  /// <summary>
  /// Returns or sets a Template or Document object that represents the template or document in which changes to menu bars, toolbars, and key bindings are stored.
  /// </summary>
  public object CustomizationContext { get; set; }

  /// <summary>
  /// Returns a KeyBindings collection that represents customized key assignments, which include a key code, a key category, and a command.
  /// </summary>
  public KeyBindings KeyBindings { get; }

  /// <summary>
  /// Returns or sets the caption text for the specified document or application window.
  /// </summary>
  public string Caption { get; set; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  public string Path { get; }

  /// <summary>
  /// Determines if Word displays a scroll bar in at least one document window.
  /// </summary>
  public bool DisplayScrollBars { get; set; }

  /// <summary>
  /// Returns or sets the complete path of the startup folder, excluding the final separator.
  /// </summary>
  public string StartupPath { get; set; }

  /// <summary>
  /// Returns the number of files queued up to be saved in the background.
  /// </summary>
  public int BackgroundSavingStatus { get; }

  /// <summary>
  /// Returns the number of print jobs in the background printing queue.
  /// </summary>
  public int BackgroundPrintingStatus { get; }

  /// <summary>
  /// Returns or sets an Integer that represents the horizontal position of the active document (for the Application object) or the specified task or window, measured in points.
  /// </summary>
  public int Left { get; set; }

  /// <summary>
  /// Returns or sets the vertical position of the active document, in points.
  /// </summary>
  public int Top { get; set; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  public int Width { get; set; }

  /// <summary>
  /// Returns or sets the height of the active document window.
  /// </summary>
  public int Height { get; set; }

  /// <summary>
  /// Returns or sets the state of the specified document window or task window.
  /// </summary>
  public WdWindowState WindowState { get; set; }

  /// <summary>
  /// Determines if Microsoft Word displays tips that suggest text for completing words, dates, or phrases as you type.
  /// </summary>
  public bool DisplayAutoCompleteTips { get; set; }

  /// <summary>
  /// Returns an Options object that represents application settings in Microsoft Word.
  /// </summary>
  public Options Options { get; }

  /// <summary>
  /// Returns or sets the way certain alerts and messages are handled while a macro is running.
  /// </summary>
  public WdAlertLevel DisplayAlerts { get; set; }

  /// <summary>
  /// Returns a Dictionaries object that represents the collection of active custom dictionaries. Active custom dictionaries are marked with a check in the Custom Dictionaries dialog box.
  /// </summary>
  public Dictionaries CustomDictionaries { get; }

  /// <summary>
  /// Returns the character used to separate folder names.
  /// </summary>
  public string PathSeparator { get; }

  /// <summary>
  /// Displays the specified text in the status bar.
  /// </summary>
  public string StatusBar { set; }

  /// <summary>
  /// Determines if MAPI is installed. This property returns True if MAPI is installed, and False if not.
  /// </summary>
  public bool MAPIAvailable { get; }

  /// <summary>
  /// Determines if comments, footnotes, endnotes, and hyperlinks are displayed as tips. Text marked as having comments is highlighted.
  /// </summary>
  public bool DisplayScreenTips { get; set; }

  /// <summary>
  /// Returns or sets the way that Word handles CTRL+BREAK user interruptions.
  /// </summary>
  public WdEnableCancelKey EnableCancelKey { get; set; }

  /// <summary>
  /// Determines if the document or application was created or opened by the user.
  /// </summary>
  public bool UserControl { get; }

  /// <summary>
  /// Returns a FileSearch object that can be used to search for files using either an absolute or relative path.
  /// </summary>
  //public Core.FileSearch FileSearch { get; }

  /// <summary>
  /// Returns the mail system (or systems) installed on the host machine.
  /// </summary>
  public WdMailSystem MailSystem { get; }

  /// <summary>
  /// Returns or sets the single character used to separate text into cells when text is converted to a table.
  /// </summary>
  public string DefaultTableSeparator { get; set; }

  /// <summary>
  /// Determines if the Visual Basic Editor window is visible. This property returns True if the Visual Basic Editor window is visible, and False if not.
  /// </summary>
  public bool ShowVisualBasicEditor { get; set; }

  /// <summary>
  /// Set this property to "text/html" to allow hyperlinked HTML files to be opened in Microsoft Word (instead of the default Internet browser).
  /// </summary>
  public string BrowseExtraFileTypes { get; set; }

  /// <summary>
  /// Returns a HangulHanjaConversionDictionaries collection that represents all the active custom conversion dictionaries.
  /// </summary>
  public HangulHanjaConversionDictionaries HangulHanjaDictionaries { get; }

  /// <summary>
  /// Returns a MailMessage object that represents the active e-mail message.
  /// </summary>
  public MailMessage MailMessage { get; }

  /// <summary>
  /// Determines if the insertion point is in an e-mail header field.
  /// </summary>
  public bool FocusInMailHeader { get; }

  /// <summary>
  /// Returns an EmailOptions object that represents the global preferences for e-mail authoring.
  /// </summary>
  public EmailOptions EmailOptions { get; }

  /// <summary>
  /// Returns an MsoLanguageID constant that represents the language selected for the Microsoft Word user interface.
  /// </summary>
  //public Core.MsoLanguageID Language { get; }

  /// <summary>
  /// Returns a reference to the COMAddIns collection that represents all the Component Object Model (COM) add-ins currently loaded in Microsoft Word.
  /// </summary>
  //public Core.COMAddIns COMAddIns { get; }

  /// <summary>
  /// Determines if Microsoft Word automatically detects the language you are using as you type. Returns True if Microsoft Word automatically detects the language you are using as you type, and False if it does not automatically detect the language.
  /// </summary>
  public bool CheckLanguage { get; set; }

  /// <summary>
  /// Returns a LanguageSettings object, which contains information about the language settings in Microsoft Word.
  /// </summary>
  //public Core.LanguageSettings LanguageSettings { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  public bool Dummy1 { get; }

  /// <summary>
  /// Returns a AnswerWizard object that contains the files used by the online Help search engine.
  /// </summary>
  //public Core.AnswerWizard AnswerWizard { get; }

  /// <summary>
  /// Returns or sets how Microsoft Word handles calls to methods and properties that require features not yet installed.
  /// </summary>
  //public Core.MsoFeatureInstall FeatureInstall { get; set; }

  /// <summary>
  /// Returns or sets a MsoAutomationSecurity constant that represents the security setting Microsoft Word uses when programmatically opening files.
  /// </summary>
  //public Core.MsoAutomationSecurity AutomationSecurity { get; set; }

  /// <summary>
  /// Returns or sets a String that represents the document template to use when sending e-mail messages.
  /// </summary>
  public string EmailTemplate { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  public bool ShowWindowsInTaskbar { get; set; }

  /// <summary>
  /// Returns a NewFile object that represents a document listed on the New Document task pane.
  /// </summary>
  //public Core.NewFile NewDocument { get; }

  /// <summary>
  /// Determines if the Task Pane will be displayed when starting Microsoft Word.
  /// </summary>
  public bool ShowStartupDialog { get; set; }

  /// <summary>
  /// Returns a AutoCorrect object that represents automatic corrections made to e-mail messages.
  /// </summary>
  public AutoCorrect AutoCorrectEmail { get; }

  /// <summary>
  /// Returns a TaskPanes object that represents the most commonly performed tasks in Microsoft Word.
  /// </summary>
  public TaskPanes TaskPanes { get; }

  /// <summary>
  /// Determines if Microsoft Word will compare and merge documents using the Legal blackline option in the Compare and Merge Documents dialog box. Returns True if Word will use the option, and False if not.
  /// </summary>
  public bool DefaultLegalBlackline { get; set; }

  /// <summary>
  /// Returns a SmartTagRecognizers collection for an application.
  /// </summary>
  public SmartTagRecognizers SmartTagRecognizers { get; }

  /// <summary>
  /// Returns a SmartTagTypes collection that represents the smart tag types for the smart tag components installed in Microsoft Word.
  /// </summary>
  public SmartTagTypes SmartTagTypes { get; }

  /// <summary>
  /// Returns an XMLNamespaces collection that represents the XML schemas in the Schema Library.
  /// </summary>
  public XMLNamespaces XMLNamespaces { get; }

  /// <summary>
  /// Returns a Boolean that represents whether Microsoft Word accepts custom XML schemas. Returns True if Word accepts custom XML schemas, or False if schemas are not accepted.
  /// </summary>
  public bool ArbitraryXMLSupportAvailable { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  public string BuildFull { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  public string BuildFeatureCrew { get; }

  /// <summary>
  /// Returns a Bibliography object that represents the bibliography references sources stored in Microsoft Office Word. Read-only.
  /// </summary>
  public Bibliography Bibliography { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word shows a preview of the formatting for styles in the Styles dialog box. Read/write.
  /// </summary>
  public bool ShowStylePreviews { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word allows linked styles. Read/write.
  /// </summary>
  public bool RestrictLinkedStyles { get; set; }

  /// <summary>
  /// Returns the auto correct entries for equations. Read-only.
  /// </summary>
  public OMathAutoCorrect OMathAutoCorrect { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether the document properties panel is displayed. Read/write.
  /// </summary>
  public bool DisplayDocumentInformationPanel { get; set; }

  /// <summary>
  /// Returns an Microsoft.Office.Core.IAssistance object that represents the Microsoft Office Help Viewer. Read-only.
  /// </summary>
  //public Core.IAssistance Assistance { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word opens e-mail attachments in Reading mode. Read/write.
  /// </summary>
  public bool OpenAttachmentsInFullScreen { get; set; }

  /// <summary>
  /// Returns a Integer that represents the encryption session associated with the active document. Read-only.
  /// </summary>
  public int ActiveEncryptionSession { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word maintains the formatting properties of the text at that position of the Insertion Point after running other code. Read/write.
  /// </summary>
  public bool DontResetInsertionPointProperties { get; set; }

  /// <summary>
  /// Gets a SmartArtLayouts object that represents the set of SmartArt layouts that are currently loaded in the application.
  /// </summary>
  //public Core.SmartArtLayouts SmartArtLayouts { get; }

  /// <summary>
  /// Gets a SmartArtQuickStyles object that represents the set of SmartArt styles that are currently loaded in the application.
  /// </summary>
  //public Core.SmartArtQuickStyles SmartArtQuickStyles { get; }

  /// <summary>
  /// Gets a SmartArtColors object that represents the set of color styles that are currently loaded in the application.
  /// </summary>
  //public Core.SmartArtColors SmartArtColors { get; }

  /// <summary>
  /// Gets an UndoRecord object that provides a custom entry point into the undo stack.
  /// </summary>
  public UndoRecord UndoRecord { get; }

  /// <summary>
  /// Gets a PickerDialog object that provides the functionality to select people or data in a dialog box.
  /// </summary>
  //public Core.PickerDialog PickerDialog { get; }

  /// <summary>
  /// Gets a ProtectedViewWindows collection that represents all protected view windows.
  /// </summary>
  public ProtectedViewWindows ProtectedViewWindows { get; }

  /// <summary>
  /// Gets a ProtectedViewWindow object that represents the active protected view window.
  /// </summary>
  public ProtectedViewWindow ActiveProtectedViewWindow { get; }

  /// <summary>
  /// Gets whether the application window is a protected view window.
  /// </summary>
  public bool IsSandboxed { get; }

  /// <summary>
  /// Gets or sets how Word will validate files before opening them.
  /// </summary>
  //public Core.MsoFileValidationMode FileValidation { get; set; }

  /// <summary>
  /// Returns or sets a Boolean ( bool in C#) that specifies whether charts use cell-reference data-point tracking. Read-write.
  /// </summary>
  public bool ChartDataPointTrack { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  public bool ShowAnimation { get; set; }
}
