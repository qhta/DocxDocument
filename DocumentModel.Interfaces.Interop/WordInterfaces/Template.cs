namespace DocumentModel.Interop;

/// <summary>
/// Represents a document template.
/// </summary>
public partial interface Template : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The path.
  /// </summary>
  public string Path { get; }

  /// <summary>
  /// The auto text entries.
  /// </summary>
  public AutoTextEntries AutoTextEntries { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The saved.
  /// </summary>
  public bool Saved { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdTemplateType Type { get; }

  /// <summary>
  /// The full name.
  /// </summary>
  public string FullName { get; }

  /// <summary>
  /// The built in document properties.
  /// </summary>
  public object BuiltInDocumentProperties { get; }

  /// <summary>
  /// The custom document properties.
  /// </summary>
  public object CustomDocumentProperties { get; }

  /// <summary>
  /// The list templates.
  /// </summary>
  public ListTemplates ListTemplates { get; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The vbproject.
  /// </summary>
  public VBE.VBProject VBProject { get; }

  /// <summary>
  /// The kerning by algorithm.
  /// </summary>
  public bool KerningByAlgorithm { get; set; }

  /// <summary>
  /// The justification mode.
  /// </summary>
  public WdJustificationMode JustificationMode { get; set; }

  /// <summary>
  /// The far east line break level.
  /// </summary>
  public WdFarEastLineBreakLevel FarEastLineBreakLevel { get; set; }

  /// <summary>
  /// The no line break before.
  /// </summary>
  public string NoLineBreakBefore { get; set; }

  /// <summary>
  /// The no line break after.
  /// </summary>
  public string NoLineBreakAfter { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  public int NoProofing { get; set; }

  /// <summary>
  /// The far east line break language.
  /// </summary>
  public WdFarEastLineBreakLanguageID FarEastLineBreakLanguage { get; set; }

  /// <summary>
  /// The building block entries.
  /// </summary>
  public BuildingBlockEntries BuildingBlockEntries { get; }

  /// <summary>
  /// The building block types.
  /// </summary>
  public BuildingBlockTypes BuildingBlockTypes { get; }
}
