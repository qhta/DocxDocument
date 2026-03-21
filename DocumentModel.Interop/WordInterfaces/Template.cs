namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a document template.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template?view=word-pia"/>
public partial interface Template : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The path.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// The auto text entries.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.autotextentries?view=word-pia"/>
  public AutoTextEntries AutoTextEntries { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The saved.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.saved?view=word-pia"/>
  public bool Saved { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.type?view=word-pia"/>
  public WdTemplateType Type { get; }

  /// <summary>
  /// The full name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fullname?view=word-pia"/>
  public string FullName { get; }

  /// <summary>
  /// The built in document properties.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.builtindocumentproperties?view=word-pia"/>
  public object BuiltInDocumentProperties { get; }

  /// <summary>
  /// The custom document properties.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.customdocumentproperties?view=word-pia"/>
  public object CustomDocumentProperties { get; }

  /// <summary>
  /// The list templates.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.listtemplates?view=word-pia"/>
  public ListTemplates ListTemplates { get; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The vbproject.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.vbproject?view=word-pia"/>
  public object VBProject { get; }

  /// <summary>
  /// The kerning by algorithm.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.kerningbyalgorithm?view=word-pia"/>
  public bool KerningByAlgorithm { get; set; }

  /// <summary>
  /// The justification mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.justificationmode?view=word-pia"/>
  public WdJustificationMode JustificationMode { get; set; }

  /// <summary>
  /// The far east line break level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fareastlinebreaklevel?view=word-pia"/>
  public WdFarEastLineBreakLevel FarEastLineBreakLevel { get; set; }

  /// <summary>
  /// The no line break before.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.nolinebreakbefore?view=word-pia"/>
  public string NoLineBreakBefore { get; set; }

  /// <summary>
  /// The no line break after.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.nolinebreakafter?view=word-pia"/>
  public string NoLineBreakAfter { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// The far east line break language.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.fareastlinebreaklanguage?view=word-pia"/>
  public WdFarEastLineBreakLanguageID FarEastLineBreakLanguage { get; set; }

  /// <summary>
  /// The building block entries.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.buildingblockentries?view=word-pia"/>
  public BuildingBlockEntries BuildingBlockEntries { get; }

  /// <summary>
  /// The building block types.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.buildingblocktypes?view=word-pia"/>
  public BuildingBlockTypes BuildingBlockTypes { get; }
}
