namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM object, see Global.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global?view=word-pia"/>
public partial interface _IGlobal: IInteropObject
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
  public Documents Documents { get; }

  /// <summary>
  /// Returns a Windows collection that represents all document windows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.windows?view=word-pia"/>
  public Windows Windows { get; }

  /// <summary>
  /// Returns a Document object that represents the active document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activedocument?view=word-pia"/>
  public Document ActiveDocument { get; }

  /// <summary>
  /// Returns a Window object that represents the active window (the window with the focus).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activewindow?view=word-pia"/>
  public Window ActiveWindow { get; }

  /// <summary>
  /// Returns the Selection object that represents a selected range or the insertion point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.selection?view=word-pia"/>
  public Selection Selection { get; }

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
  public RecentFiles RecentFiles { get; }

  /// <summary>
  /// Returns a Template object that represents the Normal template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.normaltemplate?view=word-pia"/>
  public Template NormalTemplate { get; }

  /// <summary>
  /// Returns a System object that can be used to return system-related information and perform system-related tasks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.system?view=word-pia"/>
  public System System { get; }

  /// <summary>
  /// Returns an AutoCorrect object that contains the current AutoCorrect options, entries, and exceptions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocorrect?view=word-pia"/>
  public AutoCorrect AutoCorrect { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.fontnames?view=word-pia"/>
  public FontNames FontNames { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available landscape fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.landscapefontnames?view=word-pia"/>
  public FontNames LandscapeFontNames { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available portrait fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.portraitfontnames?view=word-pia"/>
  public FontNames PortraitFontNames { get; }

  /// <summary>
  /// Returns a Languages collection that represents the proofing languages listed in the Language dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.languages?view=word-pia"/>
  public Languages Languages { get; }

  /// <summary>
  /// Returns an Assistant object that represents the Microsoft Office Assistant.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.assistant?view=word-pia"/>
  public Core.Assistant Assistant { get; }

  /// <summary>
  /// Returns a FileConverters collection that represents all file converters available to Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.fileconverters?view=word-pia"/>
  public FileConverters FileConverters { get; }

  /// <summary>
  /// Returns a Dialogs collection that represents all built-in dialog boxes in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.dialogs?view=word-pia"/>
  public Dialogs Dialogs { get; }

  /// <summary>
  /// Returns a CaptionLabels collection that represents all available caption labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.captionlabels?view=word-pia"/>
  public CaptionLabels CaptionLabels { get; }

  /// <summary>
  /// Returns an AutoCaptions collection that represents captions automatically added for inserted items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocaptions?view=word-pia"/>
  public AutoCaptions AutoCaptions { get; }

  /// <summary>
  /// Returns an AddIns collection that represents all available add-ins.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.addins?view=word-pia"/>
  public AddIns AddIns { get; }

  /// <summary>
  /// Returns a Tasks collection that represents all applications that are running.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.tasks?view=word-pia"/>
  public Tasks Tasks { get; }

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
  public ListGalleries ListGalleries { get; }

  /// <summary>
  /// Returns or sets the name of the active printer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activeprinter?view=word-pia"/>
  public string ActivePrinter { get; set; }

  /// <summary>
  /// Returns a Templates collection that represents all available templates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.templates?view=word-pia"/>
  public Templates Templates { get; }

  /// <summary>
  /// Returns or sets the Template or Document in which changes to menu bars, toolbars, and key bindings are stored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.customizationcontext?view=word-pia"/>
  public object CustomizationContext { get; set; }

  /// <summary>
  /// Returns a KeyBindings collection that represents customized key assignments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.keybindings?view=word-pia"/>
  public KeyBindings KeyBindings { get; }

  /// <summary>
  /// Returns an Options object that represents application settings in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.options?view=word-pia"/>
  public Options Options { get; }

  /// <summary>
  /// Returns a Dictionaries object that represents the collection of active custom dictionaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.customdictionaries?view=word-pia"/>
  public Dictionaries CustomDictionaries { get; }

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
  public HangulHanjaConversionDictionaries HangulHanjaDictionaries { get; }

  /// <summary>
  /// Returns a LanguageSettings object that contains language setting information in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.languagesettings?view=word-pia"/>
  public Core.LanguageSettings LanguageSettings { get; }

  /// <summary>
  /// Returns an AnswerWizard object that contains files used by the online Help search engine.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.answerwizard?view=word-pia"/>
  public Core.AnswerWizard AnswerWizard { get; }

  /// <summary>
  /// Returns an AutoCorrect object that represents automatic corrections made to e-mail messages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocorrectemail?view=word-pia"/>
  public AutoCorrect AutoCorrectEmail { get; }

  /// <summary>
  /// Returns a ProtectedViewWindows object that represents open protected view windows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.protectedviewwindows?view=word-pia"/>
  public ProtectedViewWindows ProtectedViewWindows { get; }

  /// <summary>
  /// Returns a ProtectedViewWindow object that represents the active protected view window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activeprotectedviewwindow?view=word-pia"/>
  public ProtectedViewWindow ActiveProtectedViewWindow { get; }

  /// <summary>
  /// Gets whether the application window is a protected view window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.issandboxed?view=word-pia"/>
  public bool IsSandboxed { get; }

}
