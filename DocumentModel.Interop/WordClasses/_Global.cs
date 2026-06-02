namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary class in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary class only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this class to call the method, and cast to the latest events class to connect to the event. Otherwise, use the .NET class that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM object, see Global.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global?view=word-pia"/>
public partial class _Global: InteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Returns a Documents collection that represents all the open documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.documents?view=word-pia"/>
  public Documents Documents { get; set; }

  /// <summary>
  /// Returns a Windows collection that represents all document windows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.windows?view=word-pia"/>
  public Windows Windows { get; set; }

  /// <summary>
  /// Returns a Document object that represents the active document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activedocument?view=word-pia"/>
  public Document ActiveDocument { get; set; }

  /// <summary>
  /// Returns a Window object that represents the active window (the window with the focus).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activewindow?view=word-pia"/>
  public Window ActiveWindow { get; set; }

  /// <summary>
  /// Returns the Selection object that represents a selected range or the insertion point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.selection?view=word-pia"/>
  public Selection Selection { get; set; }

  /// <summary>
  /// Returns an Automation object (Word.Basic) that includes methods for all WordBasic statements and functions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.wordbasic?view=word-pia"/>
  public object WordBasic { get; set; }

  /// <summary>
  /// Determines whether print preview is the current view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.printpreview?view=word-pia"/>
  public bool PrintPreview { get; set; }

  /// <summary>
  /// Returns a RecentFiles collection that represents the most recently accessed files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.recentfiles?view=word-pia"/>
  public RecentFiles RecentFiles { get; set; }

  /// <summary>
  /// Returns a Template object that represents the Normal template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.normaltemplate?view=word-pia"/>
  public Template NormalTemplate { get; set; }

  /// <summary>
  /// Returns a System object that can be used to return system-related information and perform system-related tasks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.system?view=word-pia"/>
  public System System { get; set; }

  /// <summary>
  /// Returns an AutoCorrect object that contains the current AutoCorrect options, entries, and exceptions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocorrect?view=word-pia"/>
  public AutoCorrect AutoCorrect { get; set; }

  /// <summary>
  /// Returns a Names object that includes the names of all available fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.fontnames?view=word-pia"/>
  public FontNames FontNames { get; set; }

  /// <summary>
  /// Returns a Names object that includes the names of all available landscape fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.landscapefontnames?view=word-pia"/>
  public FontNames LandscapeFontNames { get; set; }

  /// <summary>
  /// Returns a Names object that includes the names of all available portrait fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.portraitfontnames?view=word-pia"/>
  public FontNames PortraitFontNames { get; set; }

  /// <summary>
  /// Returns a Languages collection that represents the proofing languages listed in the Language dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.languages?view=word-pia"/>
  public Languages Languages { get; set; }

  /// <summary>
  /// Returns an Assistant object that represents the Microsoft Office Assistant.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.assistant?view=word-pia"/>
  public Core.Assistant Assistant { get; set; }

  /// <summary>
  /// Returns a FileConverters collection that represents all file converters available to Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.fileconverters?view=word-pia"/>
  public FileConverters FileConverters { get; set; }

  /// <summary>
  /// Returns a Dialogs collection that represents all built-in dialog boxes in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.dialogs?view=word-pia"/>
  public Dialogs Dialogs { get; set; }

  /// <summary>
  /// Returns a CaptionLabels collection that represents all available caption labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.captionlabels?view=word-pia"/>
  public CaptionLabels CaptionLabels { get; set; }

  /// <summary>
  /// Returns an AutoCaptions collection that represents captions automatically added for inserted items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocaptions?view=word-pia"/>
  public AutoCaptions AutoCaptions { get; set; }

  /// <summary>
  /// Returns an AddIns collection that represents all available add-ins.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.addins?view=word-pia"/>
  public AddIns AddIns { get; set; }

  /// <summary>
  /// Returns a Tasks collection that represents all applications that are running.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.tasks?view=word-pia"/>
  public Tasks Tasks { get; set; }

  /// <summary>
  /// Returns a Template or Document object in which the module containing the running procedure is stored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.macrocontainer?view=word-pia"/>
  public object MacroContainer { get; set; }

  /// <summary>
  /// Returns a CommandBars collection that represents the menu bar and all toolbars in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.commandbars?view=word-pia"/>
  public object CommandBars { get; set; }

  /// <summary>
  /// Returns a VBE object that represents the Visual Basic Editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.vbe?view=word-pia"/>
  public object VBE { get; set; }

  /// <summary>
  /// Returns a ListGalleries collection that represents the Bulleted, Numbered, and Outline Numbered galleries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.listgalleries?view=word-pia"/>
  public ListGalleries ListGalleries { get; set; }

  /// <summary>
  /// Returns or sets the name of the active printer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activeprinter?view=word-pia"/>
  public string? ActivePrinter { get; set; }

  /// <summary>
  /// Returns a Templates collection that represents all available templates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.templates?view=word-pia"/>
  public Templates Templates { get; set; }

  /// <summary>
  /// Returns or sets the Template or Document in which changes to menu bars, toolbars, and key bindings are stored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.customizationcontext?view=word-pia"/>
  public object CustomizationContext { get; set; }

  /// <summary>
  /// Returns a KeyBindings collection that represents customized key assignments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.keybindings?view=word-pia"/>
  public KeyBindings KeyBindings { get; set; }

  /// <summary>
  /// Returns an Options object that represents application settings in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.options?view=word-pia"/>
  public Options Options { get; set; }

  /// <summary>
  /// Returns a Dictionaries object that represents the collection of active custom dictionaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.customdictionaries?view=word-pia"/>
  public Dictionaries CustomDictionaries { get; set; }

  /// <summary>
  /// Sets the StatusBar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.statusbar?view=word-pia"/>
  public string? StatusBar { get; set; }

  /// <summary>
  /// Determines whether the Visual Basic Editor window is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.showvisualbasiceditor?view=word-pia"/>
  public bool ShowVisualBasicEditor { get; set; }

  /// <summary>
  /// Returns a HangulHanjaConversionDictionaries collection that represents active custom conversion dictionaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.hangulhanjadictionaries?view=word-pia"/>
  public HangulHanjaConversionDictionaries HangulHanjaDictionaries { get; set; }

  /// <summary>
  /// Returns a LanguageSettings object that contains language setting information in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.languagesettings?view=word-pia"/>
  public Core.LanguageSettings LanguageSettings { get; set; }

  /// <summary>
  /// Returns an AnswerWizard object that contains files used by the online Help search engine.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.answerwizard?view=word-pia"/>
  public Core.AnswerWizard AnswerWizard { get; set; }

  /// <summary>
  /// Returns an AutoCorrect object that represents automatic corrections made to e-mail messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocorrectemail?view=word-pia"/>
  public AutoCorrect AutoCorrectEmail { get; set; }

  /// <summary>
  /// Returns a ProtectedViewWindows object that represents open protected view windows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.protectedviewwindows?view=word-pia"/>
  public ProtectedViewWindows ProtectedViewWindows { get; set; }

  /// <summary>
  /// Returns a ProtectedViewWindow object that represents the active protected view window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activeprotectedviewwindow?view=word-pia"/>
  public ProtectedViewWindow ActiveProtectedViewWindow { get; set; }

  /// <summary>
  /// Gets whether the application window is a protected view window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.issandboxed?view=word-pia"/>
  public bool IsSandboxed { get; set; }



  #region methods

/// <summary>
  /// Returns a SynonymInfo object with thesaurus information for the specified word or phrase.
  /// </summary>
  /// <param name="Word">The word or phrase to look up.</param>
  /// <param name="LanguageID">The language identifier.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.get_synonyminfo?view=word-pia"/>
  public SynonymInfo SynonymInfo(string Word, object LanguageID) { throw new NotImplementedException(); }
  /// <summary>
  /// Returns a KeysBoundTo object that represents all key combinations assigned to the specified item.
  /// </summary>
  /// <param name="KeyCategory">The key category for the command.</param>
  /// <param name="Command">The command name.</param>
  /// <param name="CommandParameter">An optional command parameter.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.get_keysboundto?view=word-pia"/>
  public KeysBoundTo KeysBoundTo(KeyCategory KeyCategory, string Command, object CommandParameter) { throw new NotImplementedException(); }
  /// <summary>
  /// Returns a KeyBinding object that represents the specified key combination.
  /// </summary>
  /// <param name="KeyCode">The first key code.</param>
  /// <param name="KeyCode2">The second key code.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.get_findkey?view=word-pia"/>
  public KeyBinding FindKey(int KeyCode, object KeyCode2) { throw new NotImplementedException(); }
  /// <summary>
  /// Determines whether a variable that references an object is valid.
  /// </summary>
  /// <param name="Object">The object reference to validate.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.get_isobjectvalid?view=word-pia"/>
  public bool IsObjectValid(object Object) { throw new NotImplementedException(); }
  /// <summary>
  /// Repeats the most recent editing action one or more times.
  /// </summary>
  /// <param name="Times">The number of times to repeat the action.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.repeat?view=word-pia"/>
  public bool Repeat(object Times) { throw new NotImplementedException(); }
  /// <summary>
  /// Sends a command or series of commands through the specified dynamic data exchange (DDE) channel.
  /// </summary>
  /// <param name="Channel">The DDE channel number.</param>
  /// <param name="Command">The command text to send.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddeexecute?view=word-pia"/>
  public void DDEExecute(int Channel, string Command) { throw new NotImplementedException(); }
  /// <summary>
  /// Opens a dynamic data exchange (DDE) channel to another application and returns the channel number.
  /// </summary>
  /// <param name="App">The application name.</param>
  /// <param name="Topic">The topic name.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddeinitiate?view=word-pia"/>
  public int DDEInitiate(string App, string Topic) { throw new NotImplementedException(); }
  /// <summary>
  /// Uses an open dynamic data exchange (DDE) channel to send data to an application.
  /// </summary>
  /// <param name="Channel">The DDE channel number.</param>
  /// <param name="Item">The item name.</param>
  /// <param name="Data">The data to send.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddepoke?view=word-pia"/>
  public void DDEPoke(int Channel, string Item, string Data) { throw new NotImplementedException(); }
  /// <summary>
  /// Uses an open dynamic data exchange (DDE) channel to request information and returns it as a string.
  /// </summary>
  /// <param name="Channel">The DDE channel number.</param>
  /// <param name="Item">The item to request.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.dderequest?view=word-pia"/>
  public string? DDERequest(int Channel, string Item) { throw new NotImplementedException(); }
  /// <summary>
  /// Closes the specified dynamic data exchange (DDE) channel to another application.
  /// </summary>
  /// <param name="Channel">The DDE channel number.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddeterminate?view=word-pia"/>
  public void DDETerminate(int Channel) { throw new NotImplementedException(); }
  /// <summary>
  /// Closes all dynamic data exchange (DDE) channels opened by Microsoft Word.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddeterminateall?view=word-pia"/>
  public void DDETerminateAll() { throw new NotImplementedException(); }
  /// <summary>
  /// Returns a unique number for the specified key combination.
  /// </summary>
  /// <param name="Arg1">The first key.</param>
  /// <param name="Arg2">The second key.</param>
  /// <param name="Arg3">The third key.</param>
  /// <param name="Arg4">The fourth key.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.buildkeycode?view=word-pia"/>
  public int BuildKeyCode(Key Arg1, object Arg2, object Arg3, object Arg4) { throw new NotImplementedException(); }
  /// <summary>
  /// Returns the key combination string for the specified keys.
  /// </summary>
  /// <param name="KeyCode">The first key code.</param>
  /// <param name="KeyCode2">The second key code.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.keystring?view=word-pia"/>
  public string? KeyString(int KeyCode, object KeyCode2) { throw new NotImplementedException(); }
  /// <summary>
  /// Checks a string for spelling errors.
  /// </summary>
  /// <param name="Word">The text to check.</param>
  /// <param name="CustomDictionary">A custom dictionary.</param>
  /// <param name="IgnoreUppercase">Whether to ignore uppercase words.</param>
  /// <param name="MainDictionary">The main dictionary.</param>
  /// <param name="CustomDictionary2">An additional custom dictionary.</param>
  /// <param name="CustomDictionary3">An additional custom dictionary.</param>
  /// <param name="CustomDictionary4">An additional custom dictionary.</param>
  /// <param name="CustomDictionary5">An additional custom dictionary.</param>
  /// <param name="CustomDictionary6">An additional custom dictionary.</param>
  /// <param name="CustomDictionary7">An additional custom dictionary.</param>
  /// <param name="CustomDictionary8">An additional custom dictionary.</param>
  /// <param name="CustomDictionary9">An additional custom dictionary.</param>
  /// <param name="CustomDictionary10">An additional custom dictionary.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.checkspelling?view=word-pia"/>
  public bool CheckSpelling(string Word, object CustomDictionary, object IgnoreUppercase, object MainDictionary, object CustomDictionary2, object CustomDictionary3, object CustomDictionary4, object CustomDictionary5, object CustomDictionary6, object CustomDictionary7, object CustomDictionary8, object CustomDictionary9, object CustomDictionary10) { throw new NotImplementedException(); }
  /// <summary>
  /// Returns a SpellingSuggestions collection that represents suggested spelling replacements for a word.
  /// </summary>
  /// <param name="Word">The word to check.</param>
  /// <param name="CustomDictionary">A custom dictionary.</param>
  /// <param name="IgnoreUppercase">Whether to ignore uppercase words.</param>
  /// <param name="MainDictionary">The main dictionary.</param>
  /// <param name="SuggestionMode">The suggestion mode.</param>
  /// <param name="CustomDictionary2">An additional custom dictionary.</param>
  /// <param name="CustomDictionary3">An additional custom dictionary.</param>
  /// <param name="CustomDictionary4">An additional custom dictionary.</param>
  /// <param name="CustomDictionary5">An additional custom dictionary.</param>
  /// <param name="CustomDictionary6">An additional custom dictionary.</param>
  /// <param name="CustomDictionary7">An additional custom dictionary.</param>
  /// <param name="CustomDictionary8">An additional custom dictionary.</param>
  /// <param name="CustomDictionary9">An additional custom dictionary.</param>
  /// <param name="CustomDictionary10">An additional custom dictionary.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.getspellingsuggestions?view=word-pia"/>
  public SpellingSuggestions GetSpellingSuggestions(string Word, object CustomDictionary, object IgnoreUppercase, object MainDictionary, object SuggestionMode, object CustomDictionary2, object CustomDictionary3, object CustomDictionary4, object CustomDictionary5, object CustomDictionary6, object CustomDictionary7, object CustomDictionary8, object CustomDictionary9, object CustomDictionary10) { throw new NotImplementedException(); }
  /// <summary>
  /// Displays online Help information.
  /// </summary>
  /// <param name="HelpType">The type of Help to display.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.help?view=word-pia"/>
  public void Help(object HelpType) { throw new NotImplementedException(); }
  /// <summary>
  /// Opens a new window with the same document as the specified window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.newwindow?view=word-pia"/>
  public Window NewWindow() { throw new NotImplementedException(); }
  /// <summary>
  /// Removes nonprinting and special Word characters from the specified string or changes them to spaces.
  /// </summary>
  /// <param name="String">The string to clean.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.cleanstring?view=word-pia"/>
  public string? CleanString(string String) { throw new NotImplementedException(); }
  /// <summary>
  /// Sets the folder in which Microsoft Word searches for documents.
  /// </summary>
  /// <param name="Path">The folder path.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.changefileopendirectory?view=word-pia"/>
  public void ChangeFileOpenDirectory(string Path) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from inches to points (1 inch = 72 points).
  /// </summary>
  /// <param name="Inches">The value in inches.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.inchestopoints?view=word-pia"/>
  public float InchesToPoints(float Inches) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from centimeters to points (1 cm = 28.35 points).
  /// </summary>
  /// <param name="Centimeters">The value in centimeters.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.centimeterstopoints?view=word-pia"/>
  public float CentimetersToPoints(float Centimeters) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from millimeters to points (1 mm = 2.85 points).
  /// </summary>
  /// <param name="Millimeters">The value in millimeters.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.millimeterstopoints?view=word-pia"/>
  public float MillimetersToPoints(float Millimeters) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from picas to points (1 pica = 12 points).
  /// </summary>
  /// <param name="Picas">The value in picas.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.picastopoints?view=word-pia"/>
  public float PicasToPoints(float Picas) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from lines to points (1 line = 12 points).
  /// </summary>
  /// <param name="Lines">The value in lines.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.linestopoints?view=word-pia"/>
  public float LinesToPoints(float Lines) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from points to inches (1 inch = 72 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstoinches?view=word-pia"/>
  public float PointsToInches(float Points) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from points to centimeters (1 centimeter = 28.35 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstocentimeters?view=word-pia"/>
  public float PointsToCentimeters(float Points) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from points to millimeters (1 millimeter = 2.835 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstomillimeters?view=word-pia"/>
  public float PointsToMillimeters(float Points) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from points to picas (1 pica = 12 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstopicas?view=word-pia"/>
  public float PointsToPicas(float Points) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from points to lines (1 line = 12 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstolines?view=word-pia"/>
  public float PointsToLines(float Points) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from points to pixels.
  /// </summary>
  /// <param name="Points">The value in points.</param>
  /// <param name="fVertical">Specifies whether conversion is for vertical measurements.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstopixels?view=word-pia"/>
  public float PointsToPixels(float Points, object fVertical) { throw new NotImplementedException(); }
  /// <summary>
  /// Converts a measurement from pixels to points.
  /// </summary>
  /// <param name="Pixels">The value in pixels.</param>
  /// <param name="fVertical">Specifies whether conversion is for vertical measurements.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pixelstopoints?view=word-pia"/>
  public float PixelsToPoints(float Pixels, object fVertical) { throw new NotImplementedException(); }

  #endregion methods
}
