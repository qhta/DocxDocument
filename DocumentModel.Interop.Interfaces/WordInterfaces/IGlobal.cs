namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM object, see Global.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global?view=word-pia"/>
public interface IGlobal: IInteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a Documents collection that represents all the open documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.documents?view=word-pia"/>
  public IDocuments Documents { get; }

  /// <summary>
  /// Returns a Windows collection that represents all document windows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.windows?view=word-pia"/>
  public IWindows Windows { get; }

  /// <summary>
  /// Returns a Document object that represents the active document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activedocument?view=word-pia"/>
  public IDocument ActiveDocument { get; }

  /// <summary>
  /// Returns a Window object that represents the active window (the window with the focus).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activewindow?view=word-pia"/>
  public IWindow ActiveWindow { get; }

  /// <summary>
  /// Returns the Selection object that represents a selected range or the insertion point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.selection?view=word-pia"/>
  public ISelection Selection { get; }

  /// <summary>
  /// Returns an Automation object (Word.Basic) that includes methods for all WordBasic statements and functions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.wordbasic?view=word-pia"/>
  public object WordBasic { get; }

  /// <summary>
  /// Determines whether print preview is the current view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.printpreview?view=word-pia"/>
  public bool PrintPreview { get; set; }

  /// <summary>
  /// Returns a RecentFiles collection that represents the most recently accessed files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.recentfiles?view=word-pia"/>
  public IRecentFiles RecentFiles { get; }

  /// <summary>
  /// Returns a Template object that represents the Normal template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.normaltemplate?view=word-pia"/>
  public ITemplate NormalTemplate { get; }

  /// <summary>
  /// Returns a System object that can be used to return system-related information and perform system-related tasks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.system?view=word-pia"/>
  public ISystem System { get; }

  /// <summary>
  /// Returns an AutoCorrect object that contains the current AutoCorrect options, entries, and exceptions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocorrect?view=word-pia"/>
  public IAutoCorrect AutoCorrect { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.fontnames?view=word-pia"/>
  public IFontNames FontNames { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available landscape fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.landscapefontnames?view=word-pia"/>
  public IFontNames LandscapeFontNames { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available portrait fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.portraitfontnames?view=word-pia"/>
  public IFontNames PortraitFontNames { get; }

  /// <summary>
  /// Returns a Languages collection that represents the proofing languages listed in the Language dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.languages?view=word-pia"/>
  public ILanguages Languages { get; }

  /// <summary>
  /// Returns an Assistant object that represents the Microsoft Office Assistant.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.assistant?view=word-pia"/>
  public Core.IAssistant IAssistant { get; }

  /// <summary>
  /// Returns a FileConverters collection that represents all file converters available to Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.fileconverters?view=word-pia"/>
  public IFileConverters FileConverters { get; }

  /// <summary>
  /// Returns a Dialogs collection that represents all built-in dialog boxes in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.dialogs?view=word-pia"/>
  public IDialogs Dialogs { get; }

  /// <summary>
  /// Returns a CaptionLabels collection that represents all available caption labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.captionlabels?view=word-pia"/>
  public ICaptionLabels CaptionLabels { get; }

  /// <summary>
  /// Returns an AutoCaptions collection that represents captions automatically added for inserted items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocaptions?view=word-pia"/>
  public IAutoCaptions AutoCaptions { get; }

  /// <summary>
  /// Returns an AddIns collection that represents all available add-ins.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.addins?view=word-pia"/>
  public IAddIns AddIns { get; }

  /// <summary>
  /// Returns a Tasks collection that represents all applications that are running.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.tasks?view=word-pia"/>
  public ITasks Tasks { get; }

  /// <summary>
  /// Returns a Template or Document object in which the module containing the running procedure is stored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.macrocontainer?view=word-pia"/>
  public object MacroContainer { get; }

  /// <summary>
  /// Returns a CommandBars collection that represents the menu bar and all toolbars in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.commandbars?view=word-pia"/>
  public object CommandBars { get; }

  /// <summary>
  /// Returns a VBE object that represents the Visual Basic Editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.vbe?view=word-pia"/>
  public object VBE { get; }

  /// <summary>
  /// Returns a ListGalleries collection that represents the Bulleted, Numbered, and Outline Numbered galleries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.listgalleries?view=word-pia"/>
  public IListGalleries ListGalleries { get; }

  /// <summary>
  /// Returns or sets the name of the active printer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activeprinter?view=word-pia"/>
  public string ActivePrinter { get; set; }

  /// <summary>
  /// Returns a Templates collection that represents all available templates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.templates?view=word-pia"/>
  public ITemplates Templates { get; }

  /// <summary>
  /// Returns or sets the Template or Document in which changes to menu bars, toolbars, and key bindings are stored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.customizationcontext?view=word-pia"/>
  public object CustomizationContext { get; set; }

  /// <summary>
  /// Returns a KeyBindings collection that represents customized key assignments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.keybindings?view=word-pia"/>
  public IKeyBindings KeyBindings { get; }

  /// <summary>
  /// Returns an Options object that represents application settings in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.options?view=word-pia"/>
  public IOptions Options { get; }

  /// <summary>
  /// Returns a Dictionaries object that represents the collection of active custom dictionaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.customdictionaries?view=word-pia"/>
  public IDictionaries CustomDictionaries { get; }

  /// <summary>
  /// Sets the StatusBar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.statusbar?view=word-pia"/>
  public string StatusBar { set; }

  /// <summary>
  /// Determines whether the Visual Basic Editor window is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.showvisualbasiceditor?view=word-pia"/>
  public bool ShowVisualBasicEditor { get; set; }

  /// <summary>
  /// Returns a HangulHanjaConversionDictionaries collection that represents active custom conversion dictionaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.hangulhanjadictionaries?view=word-pia"/>
  public IHangulHanjaConversionDictionaries HangulHanjaDictionaries { get; }

  /// <summary>
  /// Returns a LanguageSettings object that contains language setting information in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.languagesettings?view=word-pia"/>
  public Core.ILanguageSettings ILanguageSettings { get; }

  /// <summary>
  /// Returns an AnswerWizard object that contains files used by the online Help search engine.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.answerwizard?view=word-pia"/>
  public Core.IAnswerWizard IAnswerWizard { get; }

  /// <summary>
  /// Returns an AutoCorrect object that represents automatic corrections made to e-mail messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocorrectemail?view=word-pia"/>
  public IAutoCorrect AutoCorrectEmail { get; }

  /// <summary>
  /// Returns a ProtectedViewWindows object that represents open protected view windows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.protectedviewwindows?view=word-pia"/>
  public IProtectedViewWindows ProtectedViewWindows { get; }

  /// <summary>
  /// Returns a ProtectedViewWindow object that represents the active protected view window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activeprotectedviewwindow?view=word-pia"/>
  public IProtectedViewWindow ActiveProtectedViewWindow { get; }

  /// <summary>
  /// Gets whether the application window is a protected view window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.issandboxed?view=word-pia"/>
  public bool IsSandboxed { get; }



  #region methods

/// <summary>
  /// Returns a SynonymInfo object with thesaurus information for the specified word or phrase.
  /// </summary>
  /// <param name="word">The word or phrase to look up.</param>
  /// <param name="languageID">The language identifier.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.get_synonyminfo?view=word-pia"/>
  public ISynonymInfo ISynonymInfo(string word, object languageID);
  /// <summary>
  /// Returns a KeysBoundTo object that represents all key combinations assigned to the specified item.
  /// </summary>
  /// <param name="keyCategory">The key category for the command.</param>
  /// <param name="command">The command name.</param>
  /// <param name="commandParameter">An optional command parameter.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.get_keysboundto?view=word-pia"/>
  public IKeysBoundTo IKeysBoundTo(KeyCategory keyCategory, string command, object commandParameter);
  /// <summary>
  /// Returns a KeyBinding object that represents the specified key combination.
  /// </summary>
  /// <param name="keyCode">The first key code.</param>
  /// <param name="keyCode2">The second key code.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.get_findkey?view=word-pia"/>
  public IKeyBinding FindKey(int keyCode, object keyCode2);
  /// <summary>
  /// Determines whether a variable that references an object is valid.
  /// </summary>
  /// <param name="obj">The object reference to validate.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.get_isobjectvalid?view=word-pia"/>
  public bool IsObjectValid(object obj);
  /// <summary>
  /// Repeats the most recent editing action one or more times.
  /// </summary>
  /// <param name="times">The number of times to repeat the action.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.repeat?view=word-pia"/>
  public bool Repeat(object times);
  /// <summary>
  /// Sends a command or series of commands through the specified dynamic data exchange (DDE) channel.
  /// </summary>
  /// <param name="channel">The DDE channel number.</param>
  /// <param name="command">The command text to send.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddeexecute?view=word-pia"/>
  public void DDEExecute(int channel, string command);
  /// <summary>
  /// Opens a dynamic data exchange (DDE) channel to another application and returns the channel number.
  /// </summary>
  /// <param name="app">The application name.</param>
  /// <param name="topic">The topic name.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddeinitiate?view=word-pia"/>
  public int DDEInitiate(string app, string topic);
  /// <summary>
  /// Uses an open dynamic data exchange (DDE) channel to send data to an application.
  /// </summary>
  /// <param name="channel">The DDE channel number.</param>
  /// <param name="item">The item name.</param>
  /// <param name="data">The data to send.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddepoke?view=word-pia"/>
  public void DDEPoke(int channel, string item, string data);
  /// <summary>
  /// Uses an open dynamic data exchange (DDE) channel to request information and returns it as a string.
  /// </summary>
  /// <param name="channel">The DDE channel number.</param>
  /// <param name="item">The item to request.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.dderequest?view=word-pia"/>
  public string DDERequest(int channel, string item);
  /// <summary>
  /// Closes the specified dynamic data exchange (DDE) channel to another application.
  /// </summary>
  /// <param name="channel">The DDE channel number.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddeterminate?view=word-pia"/>
  public void DDETerminate(int channel);
  /// <summary>
  /// Closes all dynamic data exchange (DDE) channels opened by Microsoft Word.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.ddeterminateall?view=word-pia"/>
  public void DDETerminateAll();
  /// <summary>
  /// Returns a unique number for the specified key combination.
  /// </summary>
  /// <param name="arg1">The first key.</param>
  /// <param name="arg2">The second key.</param>
  /// <param name="arg3">The third key.</param>
  /// <param name="arg4">The fourth key.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.buildkeycode?view=word-pia"/>
  public int BuildKeyCode(Key arg1, object arg2, object arg3, object arg4);
  /// <summary>
  /// Returns the key combination string for the specified keys.
  /// </summary>
  /// <param name="keyCode">The first key code.</param>
  /// <param name="keyCode2">The second key code.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.keystring?view=word-pia"/>
  public string KeyString(int keyCode, object keyCode2);
  /// <summary>
  /// Checks a string for spelling errors.
  /// </summary>
  /// <param name="word">The text to check.</param>
  /// <param name="customDictionary">A custom dictionary.</param>
  /// <param name="ignoreUppercase">Whether to ignore uppercase words.</param>
  /// <param name="mainDictionary">The main dictionary.</param>
  /// <param name="customDictionary2">An additional custom dictionary.</param>
  /// <param name="customDictionary3">An additional custom dictionary.</param>
  /// <param name="customDictionary4">An additional custom dictionary.</param>
  /// <param name="customDictionary5">An additional custom dictionary.</param>
  /// <param name="customDictionary6">An additional custom dictionary.</param>
  /// <param name="customDictionary7">An additional custom dictionary.</param>
  /// <param name="customDictionary8">An additional custom dictionary.</param>
  /// <param name="customDictionary9">An additional custom dictionary.</param>
  /// <param name="customDictionary10">An additional custom dictionary.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.checkspelling?view=word-pia"/>
  public bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7, object customDictionary8, object customDictionary9, object customDictionary10);
  /// <summary>
  /// Returns a SpellingSuggestions collection that represents suggested spelling replacements for a word.
  /// </summary>
  /// <param name="word">The word to check.</param>
  /// <param name="customDictionary">A custom dictionary.</param>
  /// <param name="ignoreUppercase">Whether to ignore uppercase words.</param>
  /// <param name="mainDictionary">The main dictionary.</param>
  /// <param name="suggestionMode">The suggestion mode.</param>
  /// <param name="customDictionary2">An additional custom dictionary.</param>
  /// <param name="customDictionary3">An additional custom dictionary.</param>
  /// <param name="customDictionary4">An additional custom dictionary.</param>
  /// <param name="customDictionary5">An additional custom dictionary.</param>
  /// <param name="customDictionary6">An additional custom dictionary.</param>
  /// <param name="customDictionary7">An additional custom dictionary.</param>
  /// <param name="customDictionary8">An additional custom dictionary.</param>
  /// <param name="customDictionary9">An additional custom dictionary.</param>
  /// <param name="customDictionary10">An additional custom dictionary.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.getspellingsuggestions?view=word-pia"/>
  public ISpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7, object customDictionary8, object customDictionary9, object customDictionary10);
  /// <summary>
  /// Displays online Help information.
  /// </summary>
  /// <param name="helpType">The type of Help to display.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.help?view=word-pia"/>
  public void Help(object helpType);
  /// <summary>
  /// Opens a new window with the same document as the specified window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.newwindow?view=word-pia"/>
  public IWindow NewWindow();
  /// <summary>
  /// Removes nonprinting and special Word characters from the specified string or changes them to spaces.
  /// </summary>
  /// <param name="text">The string to clean.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.cleanstring?view=word-pia"/>
  public string CleanString(string text);
  /// <summary>
  /// Sets the folder in which Microsoft Word searches for documents.
  /// </summary>
  /// <param name="path">The folder path.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.changefileopendirectory?view=word-pia"/>
  public void ChangeFileOpenDirectory(string path);
  /// <summary>
  /// Converts a measurement from inches to points (1 inch = 72 points).
  /// </summary>
  /// <param name="inches">The value in inches.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.inchestopoints?view=word-pia"/>
  public float InchesToPoints(float inches);
  /// <summary>
  /// Converts a measurement from centimeters to points (1 cm = 28.35 points).
  /// </summary>
  /// <param name="centimeters">The value in centimeters.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.centimeterstopoints?view=word-pia"/>
  public float CentimetersToPoints(float centimeters);
  /// <summary>
  /// Converts a measurement from millimeters to points (1 mm = 2.85 points).
  /// </summary>
  /// <param name="millimeters">The value in millimeters.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.millimeterstopoints?view=word-pia"/>
  public float MillimetersToPoints(float millimeters);
  /// <summary>
  /// Converts a measurement from picas to points (1 pica = 12 points).
  /// </summary>
  /// <param name="picas">The value in picas.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.picastopoints?view=word-pia"/>
  public float PicasToPoints(float picas);
  /// <summary>
  /// Converts a measurement from lines to points (1 line = 12 points).
  /// </summary>
  /// <param name="lines">The value in lines.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.linestopoints?view=word-pia"/>
  public float LinesToPoints(float lines);
  /// <summary>
  /// Converts a measurement from points to inches (1 inch = 72 points).
  /// </summary>
  /// <param name="points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstoinches?view=word-pia"/>
  public float PointsToInches(float points);
  /// <summary>
  /// Converts a measurement from points to centimeters (1 centimeter = 28.35 points).
  /// </summary>
  /// <param name="points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstocentimeters?view=word-pia"/>
  public float PointsToCentimeters(float points);
  /// <summary>
  /// Converts a measurement from points to millimeters (1 millimeter = 2.835 points).
  /// </summary>
  /// <param name="points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstomillimeters?view=word-pia"/>
  public float PointsToMillimeters(float points);
  /// <summary>
  /// Converts a measurement from points to picas (1 pica = 12 points).
  /// </summary>
  /// <param name="points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstopicas?view=word-pia"/>
  public float PointsToPicas(float points);
  /// <summary>
  /// Converts a measurement from points to lines (1 line = 12 points).
  /// </summary>
  /// <param name="points">The value in points.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstolines?view=word-pia"/>
  public float PointsToLines(float points);
  /// <summary>
  /// Converts a measurement from points to pixels.
  /// </summary>
  /// <param name="points">The value in points.</param>
  /// <param name="fVertical">Specifies whether conversion is for vertical measurements.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pointstopixels?view=word-pia"/>
  public float PointsToPixels(float points, object fVertical);
  /// <summary>
  /// Converts a measurement from pixels to points.
  /// </summary>
  /// <param name="pixels">The value in pixels.</param>
  /// <param name="fVertical">Specifies whether conversion is for vertical measurements.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.pixelstopoints?view=word-pia"/>
  public float PixelsToPoints(float pixels, object fVertical);

  #endregion methods
}
