namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see Application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application?view=word-pia"/>
public partial interface _IApplication : IInteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a Documents collection that represents all the open documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.documents?view=word-pia"/>
  public Documents Documents { get; }

  /// <summary>
  /// Returns a Windows collection that represents all document windows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.windows?view=word-pia"/>
  public Windows Windows { get; }

  /// <summary>
  /// Returns a Document object that represents the active document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.activedocument?view=word-pia"/>
  public Document ActiveDocument { get; }

  /// <summary>
  /// Returns a Window object that represents the active window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.activewindow?view=word-pia"/>
  public Window ActiveWindow { get; }

  /// <summary>
  /// Returns the Selection object that represents a selected range or the insertion point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.selection?view=word-pia"/>
  public Selection Selection { get; }

  /// <summary>
  /// Returns an automation object (Word.Basic) that includes methods for all the WordBasic statements and functions available in Microsoft Word version 6.0 and Word for Windows 95.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.wordbasic?view=word-pia"/>
  public object WordBasic { get; }

  /// <summary>
  /// Returns a RecentFiles collection that represents the most recently accessed files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.recentfiles?view=word-pia"/>
  public RecentFiles RecentFiles { get; }

  /// <summary>
  /// Returns a Template object that represents the Normal template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.normaltemplate?view=word-pia"/>
  public Template NormalTemplate { get; }

  /// <summary>
  /// Returns a System object, which can be used to return system-related information and perform system-related tasks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.system?view=word-pia"/>
  public System System { get; }

  /// <summary>
  /// Returns a AutoCorrect object that contains the current AutoCorrect options, entries, and exceptions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.autocorrect?view=word-pia"/>
  public AutoCorrect AutoCorrect { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all the available fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.fontnames?view=word-pia"/>
  public FontNames FontNames { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all the available landscape fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.landscapefontnames?view=word-pia"/>
  public FontNames LandscapeFontNames { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all the available portrait fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.portraitfontnames?view=word-pia"/>
  public FontNames PortraitFontNames { get; }

  /// <summary>
  /// Returns a Languages collection that represents the proofing languages listed in the Language dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.languages?view=word-pia"/>
  public Languages Languages { get; }

  /// <summary>
  /// Returns a Assistant object that represents the Microsoft Office Assistant.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.assistant?view=word-pia"/>
  public Core.Assistant Assistant { get; }

  /// <summary>
  /// Returns a Browser object that represents the Select Browse Object tool on the vertical scroll bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.browser?view=word-pia"/>
  public Browser Browser { get; }

  /// <summary>
  /// Returns a FileConverters collection that represents all the file converters available to Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.fileconverters?view=word-pia"/>
  public FileConverters FileConverters { get; }

  /// <summary>
  /// Returns a MailingLabel object that represents a mailing label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.mailinglabel?view=word-pia"/>
  public MailingLabel MailingLabel { get; }

  /// <summary>
  /// Returns a Dialogs collection that represents all the built-in dialog boxes in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.dialogs?view=word-pia"/>
  public Dialogs Dialogs { get; }

  /// <summary>
  /// Returns a CaptionLabels collection that represents all the available caption labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.captionlabels?view=word-pia"/>
  public CaptionLabels CaptionLabels { get; }

  /// <summary>
  /// Returns a AutoCaptions collection that represents the captions that are automatically added when items such as tables and pictures are inserted into a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.autocaptions?view=word-pia"/>
  public AutoCaptions AutoCaptions { get; }

  /// <summary>
  /// Returns a AddIns collection that represents all available add-ins, regardless of whether they're currently loaded.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.addins?view=word-pia"/>
  public AddIns AddIns { get; }

  /// <summary>
  /// Determines if the specified object is visible. This property returns True if the specified object is visible, and False if not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.visible?view=word-pia"/>
  public bool Visible { get; set; }

  /// <summary>
  /// Returns the Microsoft Word version number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.version?view=word-pia"/>
  public string Version { get; }

  /// <summary>
  /// Determines if screen updating is turned on. Returns True if screen updating is turned on, and False if not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.screenupdating?view=word-pia"/>
  public bool ScreenUpdating { get; set; }

  /// <summary>
  /// Determines if print preview is the current view. This property returns True if print preview is the current view, and False if not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.printpreview?view=word-pia"/>
  public bool PrintPreview { get; set; }

  /// <summary>
  /// Returns a Tasks collection that represents all the applications that are running.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.tasks?view=word-pia"/>
  public Tasks Tasks { get; }

  /// <summary>
  /// Determines if the status bar is displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.displaystatusbar?view=word-pia"/>
  public bool DisplayStatusBar { get; set; }

  /// <summary>
  /// Determines if Microsoft Word is in a special mode (for example, CopyText mode or MoveText mode).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.specialmode?view=word-pia"/>
  public bool SpecialMode { get; }

  /// <summary>
  /// Returns the maximum width (in points) to which you can set the width of a Microsoft Word document window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.usablewidth?view=word-pia"/>
  public int UsableWidth { get; }

  /// <summary>
  /// Returns the maximum height (in points) to which you can set the height of a Microsoft Word document window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.usableheight?view=word-pia"/>
  public int UsableHeight { get; }

  /// <summary>
  /// Determines if a math coprocessor is installed and available to Microsoft Word. This property returns True if a math coprocessor is installed and available to Microsoft Word, and False if not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.mathcoprocessoravailable?view=word-pia"/>
  public bool MathCoprocessorAvailable { get; }

  /// <summary>
  /// Determines if there's a mouse available for the system. This property returns True if there's a mouse available for the system, and False if not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.mouseavailable?view=word-pia"/>
  public bool MouseAvailable { get; }

  /// <summary>
  /// Returns the version and build number of the Word application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.build?view=word-pia"/>
  public string Build { get; }

  /// <summary>
  /// Determines if the CAPS LOCK key is turned on. Returns True if the CAPS LOCK key is turned on, and False if it is not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.capslock?view=word-pia"/>
  public bool CapsLock { get; }

  /// <summary>
  /// Returns the state of the NUM LOCK key. Returns True if the keys on the numeric keypad insert numbers, and False if the keys move the insertion point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.numlock?view=word-pia"/>
  public bool NumLock { get; }

  /// <summary>
  /// Returns or sets the user's name, which is used on envelopes and for the Author document property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.username?view=word-pia"/>
  public string UserName { get; set; }

  /// <summary>
  /// Returns or sets the user's initials, which Microsoft Word uses to construct comment marks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.userinitials?view=word-pia"/>
  public string UserInitials { get; set; }

  /// <summary>
  /// Returns or sets the user's mailing address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.useraddress?view=word-pia"/>
  public string UserAddress { get; set; }

  /// <summary>
  /// Returns a Template or Document object that represents the template or document in which the module that contains the running procedure is stored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.macrocontainer?view=word-pia"/>
  public object MacroContainer { get; }

  /// <summary>
  /// Determines if the names of recently used files are displayed on the File menu.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.displayrecentfiles?view=word-pia"/>
  public bool DisplayRecentFiles { get; set; }

  /// <summary>
  /// Returns a CommandBars collection that represents the menu bar and all the toolbars in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.commandbars?view=word-pia"/>
  public Core.CommandBars CommandBars { get; }

  /// <summary>
  /// Returns a VBE object that represents the Visual Basic Editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.vbe?view=word-pia"/>
  public object VBE { get; }

  /// <summary>
  /// Returns or sets the default format that will appear in the Save as type box in the Save As dialog box (File menu).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.defaultsaveformat?view=word-pia"/>
  public string DefaultSaveFormat { get; set; }

  /// <summary>
  /// Returns a ListGalleries collection that represents the three list template galleries (Bulleted, Numbered, and Outline Numbered).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.listgalleries?view=word-pia"/>
  public ListGalleries ListGalleries { get; }

  /// <summary>
  /// Returns or sets the name of the active printer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.activeprinter?view=word-pia"/>
  public string ActivePrinter { get; set; }

  /// <summary>
  /// Returns a Templates collection that represents all the available templates Ä‚â€žĂ˘â‚¬ĹˇÄ‚â€ąĂ‚ÂĂ„â€šĂ˘â‚¬ĹˇÄ‚ËĂ˘â‚¬ĹˇĂ‚Â¬Ă„â€šĂ˘â‚¬ĹˇÄ‚ËĂ˘â€šÂ¬ÄąÄ„ global templates as well as those attached to open documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.templates?view=word-pia"/>
  public Templates Templates { get; }

  /// <summary>
  /// Returns or sets a Template or Document object that represents the template or document in which changes to menu bars, toolbars, and key bindings are stored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.customizationcontext?view=word-pia"/>
  public object CustomizationContext { get; set; }

  /// <summary>
  /// Returns a KeyBindings collection that represents customized key assignments, which include a key code, a key category, and a command.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.keybindings?view=word-pia"/>
  public KeyBindings KeyBindings { get; }

  /// <summary>
  /// Returns or sets the caption text for the specified document or application window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Determines if Word displays a scroll bar in at least one document window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.displayscrollbars?view=word-pia"/>
  public bool DisplayScrollBars { get; set; }

  /// <summary>
  /// Returns or sets the complete path of the startup folder, excluding the final separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.startuppath?view=word-pia"/>
  public string StartupPath { get; set; }

  /// <summary>
  /// Returns the number of files queued up to be saved in the background.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.backgroundsavingstatus?view=word-pia"/>
  public int BackgroundSavingStatus { get; }

  /// <summary>
  /// Returns the number of print jobs in the background printing queue.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.backgroundprintingstatus?view=word-pia"/>
  public int BackgroundPrintingStatus { get; }

  /// <summary>
  /// Returns or sets an Integer that represents the horizontal position of the active document (for the Application object) or the specified task or window, measured in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// Returns or sets the vertical position of the active document, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// Returns or sets the height of the active document window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// Returns or sets the state of the specified document window or task window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.windowstate?view=word-pia"/>
  public WindowState WindowState { get; set; }

  /// <summary>
  /// Determines if Microsoft Word displays tips that suggest text for completing words, dates, or phrases as you type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.displayautocompletetips?view=word-pia"/>
  public bool DisplayAutoCompleteTips { get; set; }

  /// <summary>
  /// Returns an Options object that represents application settings in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.options?view=word-pia"/>
  public Options Options { get; }

  /// <summary>
  /// Returns or sets the way certain alerts and messages are handled while a macro is running.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.displayalerts?view=word-pia"/>
  public AlertLevel DisplayAlerts { get; set; }

  /// <summary>
  /// Returns a Dictionaries object that represents the collection of active custom dictionaries. Active custom dictionaries are marked with a check in the Custom Dictionaries dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.customdictionaries?view=word-pia"/>
  public Dictionaries CustomDictionaries { get; }

  /// <summary>
  /// Returns the character used to separate folder names.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.pathseparator?view=word-pia"/>
  public string PathSeparator { get; }

  /// <summary>
  /// Displays the specified text in the status bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.statusbar?view=word-pia"/>
  public string StatusBar { set; }

  /// <summary>
  /// Determines if MAPI is installed. This property returns True if MAPI is installed, and False if not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.mapiavailable?view=word-pia"/>
  public bool MAPIAvailable { get; }

  /// <summary>
  /// Determines if comments, footnotes, endnotes, and hyperlinks are displayed as tips. Text marked as having comments is highlighted.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.displayscreentips?view=word-pia"/>
  public bool DisplayScreenTips { get; set; }

  /// <summary>
  /// Returns or sets the way that Word handles CTRL+BREAK user interruptions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.enablecancelkey?view=word-pia"/>
  public EnableCancelKey EnableCancelKey { get; set; }

  /// <summary>
  /// Determines if the document or application was created or opened by the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.usercontrol?view=word-pia"/>
  public bool UserControl { get; }

  /// <summary>
  /// Returns a FileSearch object that can be used to search for files using either an absolute or relative path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.filesearch?view=word-pia"/>
  public Core.FileSearch FileSearch { get; }

  /// <summary>
  /// Returns the mail system (or systems) installed on the host machine.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.mailsystem?view=word-pia"/>
  public MailSystem MailSystem { get; }

  /// <summary>
  /// Returns or sets the single character used to separate text into cells when text is converted to a table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.defaulttableseparator?view=word-pia"/>
  public string DefaultTableSeparator { get; set; }

  /// <summary>
  /// Determines if the Visual Basic Editor window is visible. This property returns True if the Visual Basic Editor window is visible, and False if not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.showvisualbasiceditor?view=word-pia"/>
  public bool ShowVisualBasicEditor { get; set; }

  /// <summary>
  /// Set this property to "text/html" to allow hyperlinked HTML files to be opened in Microsoft Word (instead of the default Internet browser).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.browseextrafiletypes?view=word-pia"/>
  public string BrowseExtraFileTypes { get; set; }

  /// <summary>
  /// Returns a HangulHanjaConversionDictionaries collection that represents all the active custom conversion dictionaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.hangulhanjadictionaries?view=word-pia"/>
  public HangulHanjaConversionDictionaries HangulHanjaDictionaries { get; }

  /// <summary>
  /// Returns a MailMessage object that represents the active e-mail message.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.mailmessage?view=word-pia"/>
  public MailMessage MailMessage { get; }

  /// <summary>
  /// Determines if the insertion point is in an e-mail header field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.focusinmailheader?view=word-pia"/>
  public bool FocusInMailHeader { get; }

  /// <summary>
  /// Returns an EmailOptions object that represents the global preferences for e-mail authoring.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.emailoptions?view=word-pia"/>
  public EmailOptions EmailOptions { get; }

  /// <summary>
  /// Returns an LanguageID constant that represents the language selected for the Microsoft Word user interface.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.language?view=word-pia"/>
  public Core.LanguageID Language { get; }

  /// <summary>
  /// Returns a reference to the COMAddIns collection that represents all the Component Object Model (COM) add-ins currently loaded in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.comaddins?view=word-pia"/>
  public Core.COMAddIns COMAddIns { get; }

  /// <summary>
  /// Determines if Microsoft Word automatically detects the language you are using as you type. Returns True if Microsoft Word automatically detects the language you are using as you type, and False if it does not automatically detect the language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.checklanguage?view=word-pia"/>
  public bool CheckLanguage { get; set; }

  /// <summary>
  /// Returns a LanguageSettings object, which contains information about the language settings in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.languagesettings?view=word-pia"/>
  public Core.LanguageSettings LanguageSettings { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.dummy1?view=word-pia"/>
  public bool Dummy1 { get; }

  /// <summary>
  /// Returns a AnswerWizard object that contains the files used by the online Help search engine.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.answerwizard?view=word-pia"/>
  public Core.AnswerWizard AnswerWizard { get; }

  /// <summary>
  /// Returns or sets how Microsoft Word handles calls to methods and properties that require features not yet installed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.featureinstall?view=word-pia"/>
  public Core.FeatureInstall FeatureInstall { get; set; }

  /// <summary>
  /// Returns or sets a AutomationSecurity constant that represents the security setting Microsoft Word uses when programmatically opening files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.automationsecurity?view=word-pia"/>
  public Core.AutomationSecurity AutomationSecurity { get; set; }

  /// <summary>
  /// Returns or sets a String that represents the document template to use when sending e-mail messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.emailtemplate?view=word-pia"/>
  public string EmailTemplate { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.showwindowsintaskbar?view=word-pia"/>
  public bool ShowWindowsInTaskbar { get; set; }

  /// <summary>
  /// Returns a NewFile object that represents a document listed on the New Document task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.newdocument?view=word-pia"/>
  public Core.NewFile NewDocument { get; }

  /// <summary>
  /// Determines if the Task Pane will be displayed when starting Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.showstartupdialog?view=word-pia"/>
  public bool ShowStartupDialog { get; set; }

  /// <summary>
  /// Returns a AutoCorrect object that represents automatic corrections made to e-mail messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.autocorrectemail?view=word-pia"/>
  public AutoCorrect AutoCorrectEmail { get; }

  /// <summary>
  /// Returns a TaskPanes object that represents the most commonly performed tasks in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.taskpanes?view=word-pia"/>
  public TaskPanes TaskPanes { get; }

  /// <summary>
  /// Determines if Microsoft Word will compare and merge documents using the Legal blackline option in the Compare and Merge Documents dialog box. Returns True if Word will use the option, and False if not.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.defaultlegalblackline?view=word-pia"/>
  public bool DefaultLegalBlackline { get; set; }

  /// <summary>
  /// Returns a SmartTagRecognizers collection for an application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.smarttagrecognizers?view=word-pia"/>
  public SmartTagRecognizers SmartTagRecognizers { get; }

  /// <summary>
  /// Returns a SmartTagTypes collection that represents the smart tag types for the smart tag components installed in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.smarttagtypes?view=word-pia"/>
  public SmartTagTypes SmartTagTypes { get; }

  /// <summary>
  /// Returns an XMLNamespaces collection that represents the XML schemas in the Schema Library.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.xmlnamespaces?view=word-pia"/>
  public XMLNamespaces XMLNamespaces { get; }

  /// <summary>
  /// Returns a Boolean that represents whether Microsoft Word accepts custom XML schemas. Returns True if Word accepts custom XML schemas, or False if schemas are not accepted.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.arbitraryxmlsupportavailable?view=word-pia"/>
  public bool ArbitraryXMLSupportAvailable { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.buildfull?view=word-pia"/>
  public string BuildFull { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.buildfeaturecrew?view=word-pia"/>
  public string BuildFeatureCrew { get; }

  /// <summary>
  /// Returns a Bibliography object that represents the bibliography references sources stored in Microsoft Office Word. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.bibliography?view=word-pia"/>
  public Bibliography Bibliography { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word shows a preview of the formatting for styles in the Styles dialog box. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.showstylepreviews?view=word-pia"/>
  public bool ShowStylePreviews { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word allows linked styles. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.restrictlinkedstyles?view=word-pia"/>
  public bool RestrictLinkedStyles { get; set; }

  /// <summary>
  /// Returns the auto correct entries for equations. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.omathautocorrect?view=word-pia"/>
  public OMathAutoCorrect OMathAutoCorrect { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether the document properties panel is displayed. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.displaydocumentinformationpanel?view=word-pia"/>
  public bool DisplayDocumentInformationPanel { get; set; }

  /// <summary>
  /// Returns an Microsoft.Office.Core.IAssistance object that represents the Microsoft Office Help Viewer. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.assistance?view=word-pia"/>
  public Core.IAssistance Assistance { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word opens e-mail attachments in Reading mode. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.openattachmentsinfullscreen?view=word-pia"/>
  public bool OpenAttachmentsInFullScreen { get; set; }

  /// <summary>
  /// Returns a Integer that represents the encryption session associated with the active document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.activeencryptionsession?view=word-pia"/>
  public int ActiveEncryptionSession { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word maintains the formatting properties of the text at that position of the Insertion Point after running other code. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.dontresetinsertionpointproperties?view=word-pia"/>
  public bool DontResetInsertionPointProperties { get; set; }

  /// <summary>
  /// Gets a SmartArtLayouts object that represents the set of SmartArt layouts that are currently loaded in the application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.smartartlayouts?view=word-pia"/>
  public Core.SmartArtLayouts SmartArtLayouts { get; }

  /// <summary>
  /// Gets a SmartArtQuickStyles object that represents the set of SmartArt styles that are currently loaded in the application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.smartartquickstyles?view=word-pia"/>
  public Core.SmartArtQuickStyles SmartArtQuickStyles { get; }

  /// <summary>
  /// Gets a SmartArtColors object that represents the set of color styles that are currently loaded in the application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.smartartcolors?view=word-pia"/>
  public Core.SmartArtColors SmartArtColors { get; }

  /// <summary>
  /// Gets an UndoRecord object that provides a custom entry point into the undo stack.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.undorecord?view=word-pia"/>
  public UndoRecord UndoRecord { get; }

  /// <summary>
  /// Gets a PickerDialog object that provides the functionality to select people or data in a dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.pickerdialog?view=word-pia"/>
  public Core.PickerDialog PickerDialog { get; }

  /// <summary>
  /// Gets a ProtectedViewWindows collection that represents all protected view windows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.protectedviewwindows?view=word-pia"/>
  public ProtectedViewWindows ProtectedViewWindows { get; }

  /// <summary>
  /// Gets a ProtectedViewWindow object that represents the active protected view window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.activeprotectedviewwindow?view=word-pia"/>
  public ProtectedViewWindow ActiveProtectedViewWindow { get; }

  /// <summary>
  /// Gets whether the application window is a protected view window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.issandboxed?view=word-pia"/>
  public bool IsSandboxed { get; }

  /// <summary>
  /// Gets or sets how Word will validate files before opening them.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.filevalidation?view=word-pia"/>
  public Core.FileValidationMode FileValidation { get; set; }

  /// <summary>
  /// Returns or sets a Boolean ( bool in C#) that specifies whether charts use cell-reference data-point tracking. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.chartdatapointtrack?view=word-pia"/>
  public bool ChartDataPointTrack { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.showanimation?view=word-pia"/>
  public bool ShowAnimation { get; set; }
}
