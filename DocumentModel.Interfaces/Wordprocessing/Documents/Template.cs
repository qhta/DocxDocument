namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a document template.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template?view=word-pia"/>
public partial interface Template : IModelObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Returns a AutoTextEntries collection that represents all the AutoText entries in the specified template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.autotextentries?view=word-pia"/>
  public AutoTextEntries AutoTextEntries { get; }

  /// <summary>
  /// Returns or sets the language for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.languageid?view=word-pia"/>
  public LanguageID LanguageID { get; set; }

  /// <summary>
  /// True if the specified document or template hasn't changed since it was last saved. False if Microsoft Word
  /// displays a prompt to save changes when the document is closed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.saved?view=word-pia"/>
  public bool Saved { get; set; }

  /// <summary>
  /// Returns the template type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.type?view=word-pia"/>
  public TemplateType Type { get; }

  /// <summary>
  /// Specifies the name of a template, including the drive or Web path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fullname?view=word-pia"/>
  public string FullName { get; }

  /// <summary>
  /// Returns a DocumentProperties collection that represents all the built-in document properties for the specified
  /// document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.builtindocumentproperties?view=word-pia"/>
  public object BuiltInDocumentProperties { get; }

  /// <summary>
  /// Returns a DocumentProperties collection that represents all the custom document properties for the specified
  /// document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.customdocumentproperties?view=word-pia"/>
  public object CustomDocumentProperties { get; }

  /// <summary>
  /// Returns a ListTemplates collection that represents all the list formats for the specified template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.listtemplates?view=word-pia"/>
  public ListTemplates ListTemplates { get; }

  /// <summary>
  /// Returns or sets an East Asian language for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.languageidfareast?view=word-pia"/>
  public LanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Returns the VBProject object for the specified template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.vbproject?view=word-pia"/>
  public object VBProject { get; }

  /// <summary>
  /// True if Microsoft Word kerns half-width Latin characters and punctuation marks in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.kerningbyalgorithm?view=word-pia"/>
  public bool KerningByAlgorithm { get; set; }

  /// <summary>
  /// Returns or sets the character spacing adjustment for the specified template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.justificationmode?view=word-pia"/>
  public JustificationMode JustificationMode { get; set; }

  /// <summary>
  /// Returns or sets the line break control level for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fareastlinebreaklevel?view=word-pia"/>
  public FarEastLineBreakLevel FarEastLineBreakLevel { get; set; }

  /// <summary>
  /// Returns or sets the kinsoku characters before which Microsoft Word will not break a line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.nolinebreakbefore?view=word-pia"/>
  public string NoLineBreakBefore { get; set; }

  /// <summary>
  /// Returns or sets the kinsoku characters after which Microsoft Word will not break a line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.nolinebreakafter?view=word-pia"/>
  public string NoLineBreakAfter { get; set; }

  /// <summary>
  /// True if the spelling and grammar checker ignores documents based on this template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// Returns or sets the East Asian language to use when breaking lines of text in the specified document or
  /// template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fareastlinebreaklanguage?view=word-pia"/>
  public FarEastLineBreakLanguageID FarEastLineBreakLanguage { get; set; }

  /// <summary>
  /// Returns a BuildingBlockEntries collection that represents the collection of building block entries in a
  /// template. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.buildingblockentries?view=word-pia"/>
  public BuildingBlockEntries BuildingBlockEntries { get; }

  /// <summary>
  /// Returns a BuildingBlockTypes collection that represents the collection of building block types that are
  /// contained in a template. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.buildingblocktypes?view=word-pia"/>
  public BuildingBlockTypes BuildingBlockTypes { get; }
}
