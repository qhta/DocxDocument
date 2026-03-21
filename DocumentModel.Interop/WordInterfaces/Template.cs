namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a document template.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template?view=word-pia"/>
public partial interface Template : InteropObject
{
  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Returns the auto text entries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.autotextentries?view=word-pia"/>
  public AutoTextEntries AutoTextEntries { get; }

  /// <summary>
  /// Returns or sets the language i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// Returns or sets whether saved.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.saved?view=word-pia"/>
  public bool Saved { get; set; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.type?view=word-pia"/>
  public WdTemplateType Type { get; }

  /// <summary>
  /// Returns the full name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fullname?view=word-pia"/>
  public string FullName { get; }

  /// <summary>
  /// Returns the built in document properties.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.builtindocumentproperties?view=word-pia"/>
  public object BuiltInDocumentProperties { get; }

  /// <summary>
  /// Returns the custom document properties.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.customdocumentproperties?view=word-pia"/>
  public object CustomDocumentProperties { get; }

  /// <summary>
  /// Returns the list templates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.listtemplates?view=word-pia"/>
  public ListTemplates ListTemplates { get; }

  /// <summary>
  /// Returns or sets the language i d far east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Returns the v b project.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.vbproject?view=word-pia"/>
  public object VBProject { get; }

  /// <summary>
  /// Returns or sets whether kerning by algorithm.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.kerningbyalgorithm?view=word-pia"/>
  public bool KerningByAlgorithm { get; set; }

  /// <summary>
  /// Returns or sets the justification mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.justificationmode?view=word-pia"/>
  public WdJustificationMode JustificationMode { get; set; }

  /// <summary>
  /// Returns or sets the far east line break level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fareastlinebreaklevel?view=word-pia"/>
  public WdFarEastLineBreakLevel FarEastLineBreakLevel { get; set; }

  /// <summary>
  /// Returns or sets the no line break before.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.nolinebreakbefore?view=word-pia"/>
  public string NoLineBreakBefore { get; set; }

  /// <summary>
  /// Returns or sets the no line break after.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.nolinebreakafter?view=word-pia"/>
  public string NoLineBreakAfter { get; set; }

  /// <summary>
  /// Returns or sets the no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// Returns or sets the far east line break language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fareastlinebreaklanguage?view=word-pia"/>
  public WdFarEastLineBreakLanguageID FarEastLineBreakLanguage { get; set; }

  /// <summary>
  /// Returns the building block entries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.buildingblockentries?view=word-pia"/>
  public BuildingBlockEntries BuildingBlockEntries { get; }

  /// <summary>
  /// Returns the building block types.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.buildingblocktypes?view=word-pia"/>
  public BuildingBlockTypes BuildingBlockTypes { get; }
}
