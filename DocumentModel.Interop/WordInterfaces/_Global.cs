namespace DocumentModel.Interop;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM object, see Global.
/// </summary>
public partial interface _Global: InteropObject
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
  /// Returns a Window object that represents the active window (the window with the focus).
  /// </summary>
  public Window ActiveWindow { get; }

  /// <summary>
  /// Returns the Selection object that represents a selected range or the insertion point.
  /// </summary>
  public Selection Selection { get; }

  /// <summary>
  /// Returns an Automation object (Word.Basic) that includes methods for all WordBasic statements and functions.
  /// </summary>
  public object WordBasic { get; }

  /// <summary>
  /// Determines whether print preview is the current view.
  /// </summary>
  public bool PrintPreview { get; set; }

  /// <summary>
  /// Returns a RecentFiles collection that represents the most recently accessed files.
  /// </summary>
  public RecentFiles RecentFiles { get; }

  /// <summary>
  /// Returns a Template object that represents the Normal template.
  /// </summary>
  public Template NormalTemplate { get; }

  /// <summary>
  /// Returns a System object that can be used to return system-related information and perform system-related tasks.
  /// </summary>
  public System System { get; }

  /// <summary>
  /// Returns an AutoCorrect object that contains the current AutoCorrect options, entries, and exceptions.
  /// </summary>
  public AutoCorrect AutoCorrect { get; }

  /// <summary>
  /// Returns a FontNames object that includes the names of all available fonts.
  /// </summary>
  public FontNames FontNames { get; }

  /// <summary>
  /// Returns a FontNames object that includes the names of all available landscape fonts.
  /// </summary>
  public FontNames LandscapeFontNames { get; }

  /// <summary>
  /// Returns a FontNames object that includes the names of all available portrait fonts.
  /// </summary>
  public FontNames PortraitFontNames { get; }

  /// <summary>
  /// Returns a Languages collection that represents the proofing languages listed in the Language dialog box.
  /// </summary>
  public Languages Languages { get; }

  /// <summary>
  /// Returns an Assistant object that represents the Microsoft Office Assistant.
  /// </summary>
  public Core.Assistant Assistant { get; }

  /// <summary>
  /// Returns a FileConverters collection that represents all file converters available to Microsoft Word.
  /// </summary>
  public FileConverters FileConverters { get; }

  /// <summary>
  /// Returns a Dialogs collection that represents all built-in dialog boxes in Microsoft Word.
  /// </summary>
  public Dialogs Dialogs { get; }

  /// <summary>
  /// Returns a CaptionLabels collection that represents all available caption labels.
  /// </summary>
  public CaptionLabels CaptionLabels { get; }

  /// <summary>
  /// Returns an AutoCaptions collection that represents captions automatically added for inserted items.
  /// </summary>
  public AutoCaptions AutoCaptions { get; }

  /// <summary>
  /// Returns an AddIns collection that represents all available add-ins.
  /// </summary>
  public AddIns AddIns { get; }

  /// <summary>
  /// Returns a Tasks collection that represents all applications that are running.
  /// </summary>
  public Tasks Tasks { get; }

  /// <summary>
  /// Returns a Template or Document object in which the module containing the running procedure is stored.
  /// </summary>
  public object MacroContainer { get; }

  /// <summary>
  /// Returns a CommandBars collection that represents the menu bar and all toolbars in Microsoft Word.
  /// </summary>
  public object CommandBars { get; }

  /// <summary>
  /// Returns a VBE object that represents the Visual Basic Editor.
  /// </summary>
  public object VBE { get; }

  /// <summary>
  /// Returns a ListGalleries collection that represents the Bulleted, Numbered, and Outline Numbered galleries.
  /// </summary>
  public ListGalleries ListGalleries { get; }

  /// <summary>
  /// Returns or sets the name of the active printer.
  /// </summary>
  public string ActivePrinter { get; set; }

  /// <summary>
  /// Returns a Templates collection that represents all available templates.
  /// </summary>
  public Templates Templates { get; }

  /// <summary>
  /// Returns or sets the Template or Document in which changes to menu bars, toolbars, and key bindings are stored.
  /// </summary>
  public object CustomizationContext { get; set; }

  /// <summary>
  /// Returns a KeyBindings collection that represents customized key assignments.
  /// </summary>
  public KeyBindings KeyBindings { get; }

  /// <summary>
  /// Returns an Options object that represents application settings in Microsoft Word.
  /// </summary>
  public Options Options { get; }

  /// <summary>
  /// Returns a Dictionaries object that represents the collection of active custom dictionaries.
  /// </summary>
  public Dictionaries CustomDictionaries { get; }

  /// <summary>
  /// Sets the StatusBar.
  /// </summary>
  public string StatusBar { set; }

  /// <summary>
  /// Determines whether the Visual Basic Editor window is visible.
  /// </summary>
  public bool ShowVisualBasicEditor { get; set; }

  /// <summary>
  /// Returns a HangulHanjaConversionDictionaries collection that represents active custom conversion dictionaries.
  /// </summary>
  public HangulHanjaConversionDictionaries HangulHanjaDictionaries { get; }

  /// <summary>
  /// Returns a LanguageSettings object that contains language setting information in Microsoft Word.
  /// </summary>
  public Core.LanguageSettings LanguageSettings { get; }

  /// <summary>
  /// Returns an AnswerWizard object that contains files used by the online Help search engine.
  /// </summary>
  public Core.AnswerWizard AnswerWizard { get; }

  /// <summary>
  /// Returns an AutoCorrect object that represents automatic corrections made to e-mail messages.
  /// </summary>
  public AutoCorrect AutoCorrectEmail { get; }

  /// <summary>
  /// Returns a ProtectedViewWindows object that represents open protected view windows.
  /// </summary>
  public ProtectedViewWindows ProtectedViewWindows { get; }

  /// <summary>
  /// Returns a ProtectedViewWindow object that represents the active protected view window.
  /// </summary>
  public ProtectedViewWindow ActiveProtectedViewWindow { get; }

  /// <summary>
  /// Gets whether the application window is a protected view window.
  /// </summary>
  public bool IsSandboxed { get; }

}