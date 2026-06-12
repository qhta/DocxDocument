namespace DocumentModel.Wordprocessing;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM object, see Global.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global?view=word-pia"/>
public partial interface I_Global: IModelObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a Documents collection that represents all the open documents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.documents?view=word-pia"/>
  public IDocuments Documents { get; }

  /// <summary>
  /// Returns a Windows collection that represents all document windows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.windows?view=word-pia"/>
  public IWindows Windows { get; }

  /// <summary>
  /// Returns a Document object that represents the active document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activedocument?view=word-pia"/>
  public IDocument ActiveDocument { get; }

  /// <summary>
  /// Returns a Window object that represents the active window (the window with the focus).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activewindow?view=word-pia"/>
  public IWindow ActiveWindow { get; }

  /// <summary>
  /// Returns the Selection object that represents a selected range or the insertion point.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.selection?view=word-pia"/>
  public ISelection Selection { get; }

  /// <summary>
  /// Returns a Template object that represents the Normal template.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.normaltemplate?view=word-pia"/>
  public ITemplate NormalTemplate { get; }

  /// <summary>
  /// Returns a System object that can be used to return system-related information and perform system-related tasks.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.system?view=word-pia"/>
  public ISystem System { get; }

  /// <summary>
  /// Returns an AutoCorrect object that contains the current AutoCorrect options, entries, and exceptions.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocorrect?view=word-pia"/>
  public IAutoCorrect AutoCorrect { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available fonts.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.fontnames?view=word-pia"/>
  public IFontNames IFontNames { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available landscape fonts.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.landscapefontnames?view=word-pia"/>
  public IFontNames LandscapeIFontNames { get; }

  /// <summary>
  /// Returns a Names object that includes the names of all available portrait fonts.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.portraitfontnames?view=word-pia"/>
  public IFontNames PortraitIFontNames { get; }

  /// <summary>
  /// Returns a Languages collection that represents the proofing languages listed in the Language dialog box.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.languages?view=word-pia"/>
  public ILanguages Languages { get; }

  /// <summary>
  /// Returns a FileConverters collection that represents all file converters available to Microsoft Word.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.fileconverters?view=word-pia"/>
  public IFileConverters FileConverters { get; }

  /// <summary>
  /// Returns a CaptionLabels collection that represents all available caption labels.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.captionlabels?view=word-pia"/>
  public ICaptionLabels CaptionLabels { get; }

  /// <summary>
  /// Returns an AutoCaptions collection that represents captions automatically added for inserted items.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocaptions?view=word-pia"/>
  public IAutoCaptions AutoCaptions { get; }

  /// <summary>
  /// Returns a Templates collection that represents all available templates.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.templates?view=word-pia"/>
  public ITemplates Templates { get; }

  /// <summary>
  /// Returns or sets the Template or Document in which changes to menu bars, toolbars, and key bindings are stored.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.customizationcontext?view=word-pia"/>
  public object CustomizationContext { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a KeyBindings collection that represents customized key assignments.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.keybindings?view=word-pia"/>
  public IKeyBindings KeyBindings { get; }

  /// <summary>
  /// Returns an Options object that represents application settings in Microsoft Word.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.options?view=word-pia"/>
  public IOptions Options { get; }

  /// <summary>
  /// Returns a Dictionaries object that represents the collection of active custom dictionaries.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.customdictionaries?view=word-pia"/>
  public IDictionaries CustomDictionaries { get; }

  /// <summary>
  /// Sets the StatusBar.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.statusbar?view=word-pia"/>
  public string StatusBar { set; }

  /// <summary>
  /// Determines whether the Visual Basic Editor window is visible.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.showvisualbasiceditor?view=word-pia"/>
  public bool ShowVisualBasicEditor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a HangulHanjaConversionDictionaries collection that represents active custom conversion dictionaries.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.hangulhanjadictionaries?view=word-pia"/>
  public IHangulHanjaConversionDictionaries HangulHanjaDictionaries { get; }

  /// <summary>
  /// Returns a LanguageSettings object that contains language setting information in Microsoft Word.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.languagesettings?view=word-pia"/>
  public App.ILanguageSettings LanguageSettings { get; }

  /// <summary>
  /// Returns an AutoCorrect object that represents automatic corrections made to e-mail messages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.autocorrectemail?view=word-pia"/>
  public IAutoCorrect AutoCorrectEmail { get; }

  /// <summary>
  /// Returns a ProtectedViewWindows object that represents open protected view windows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.protectedviewwindows?view=word-pia"/>
  public IProtectedViewWindows ProtectedViewWindows { get; }

  /// <summary>
  /// Returns a ProtectedViewWindow object that represents the active protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._global.activeprotectedviewwindow?view=word-pia"/>
  public IProtectedViewWindow ActiveProtectedViewWindow { get; }


}
