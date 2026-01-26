namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the appearance and behavior of a numbering level within a given abstract numbering definition in a WordprocessingML document.
/// A numbering level contains a set of properties for the display of numbering for a given level, including formatting, starting value, restart behavior, text, picture bullets, and associated paragraph/run properties.
/// </summary>
/// <remarks>
/// A numbering level definition is identical to a numbering level override definition, except it is defined as part of a numbering definition instance using the abstractNum element rather than as part of an abstract numbering definition using the num element.
/// </remarks>
[OpenXmlType(typeof(DXW.Level))]
public partial class NumLevel : ModelElement<DXW.Level>
{
 /// <summary>
 /// Zero-based index of the numbering level defined by this set of properties (e.g., 2 is the 3rd list level).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.LevelIndex))]
 [OpenXmlElement(typeof(DXW.Level))]
 public Int32? LevelIndex { get => _LevelIndex; set => UpdateField(ref _LevelIndex, value, nameof(LevelIndex)); }

 private Int32? _LevelIndex;
 /// <summary>
 /// Indicates that this numbering level was saved by a producer but not used in the parent document, allowing redefinition by future consumers.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.Tentative))]
 [OpenXmlElement(typeof(DXW.Level))]
 public bool? Tentative { get => _Tentative; set => UpdateField(ref _Tentative, value, nameof(Tentative)); }

 private bool? _Tentative;
 /// <summary>
 /// Starting value for numbering at this level, used when the level starts or is restarted. Defaults to zero if omitted.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.StartNumberingValue))]
 [OpenXmlElement(typeof(DXW.Level))]
 public Int32? StartNumberingValue { get => _StartNumberingValue; set => UpdateField(ref _StartNumberingValue, value, nameof(StartNumberingValue)); }

 private Int32? _StartNumberingValue;
 /// <summary>
 /// One-based index determining when this numbering level should restart to its start value, based on higher or earlier levels.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.LevelRestart))]
 [OpenXmlElement(typeof(DXW.Level))]
 public Int32? LevelRestart { get => _LevelRestart; set => UpdateField(ref _LevelRestart, value, nameof(LevelRestart)); }

 private Int32? _LevelRestart;
 /// <summary>
 /// Number format used to display numbering at this level, replacing %x in the level text string with the appropriate value.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.NumberingFormat))]
 [OpenXmlElement(typeof(DXW.Level))]
 public NumberingFormat? NumberingFormat { get => _NumberingFormat; set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat)); }

 private NumberingFormat? _NumberingFormat;
 /// <summary>
 /// Paragraph style ID associated with this numbering level.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.ParagraphStyleIdInLevel))]
 [OpenXmlElement(typeof(DXW.Level))]
 public string? ParagraphStyleIdInLevel { get => _ParagraphStyleIdInLevel; set => UpdateField(ref _ParagraphStyleIdInLevel, value, nameof(ParagraphStyleIdInLevel)); }

 private string? _ParagraphStyleIdInLevel;
 /// <summary>
 /// Indicates that all levels are displayed using Arabic numerals.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.IsLegalNumberingStyle))]
 [OpenXmlElement(typeof(DXW.Level))]
 public bool? IsLegalNumberingStyle { get => _IsLegalNumberingStyle; set => UpdateField(ref _IsLegalNumberingStyle, value, nameof(IsLegalNumberingStyle)); }

 private bool? _IsLegalNumberingStyle;
 /// <summary>
 /// Content added between the numbering level's text and the text of every numbered paragraph referencing this level. Defaults to tab if omitted.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.LevelSuffix))]
 [OpenXmlElement(typeof(DXW.Level))]
 public LevelSuffixKind? LevelSuffix { get => _LevelSuffix; set => UpdateField(ref _LevelSuffix, value, nameof(LevelSuffix)); }

 private LevelSuffixKind? _LevelSuffix;
 /// <summary>
 /// Textual content displayed for paragraphs at this numbering level, with %x replaced by the appropriate number.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.LevelText))]
 [OpenXmlElement(typeof(DXW.Level))]
 public NumLevelText? LevelText { get => _LevelText; set => UpdateField(ref _LevelText, value, nameof(LevelText)); }

 private NumLevelText? _LevelText;
 /// <summary>
 /// Identifier for the picture bullet to use as the numbering symbol at this level.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.LevelPictureBulletId))]
 [OpenXmlElement(typeof(DXW.Level))]
 public Int32? LevelPictureBulletId { get => _LevelPictureBulletId; set => UpdateField(ref _LevelPictureBulletId, value, nameof(LevelPictureBulletId)); }

 private Int32? _LevelPictureBulletId;
 /// <summary>
 /// Unique hexadecimal value for UI location of this numbering level, interpretation is application-defined.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.TemplateCode))]
 [OpenXmlElement(typeof(DXW.Level))]
 public HexInt? TemplateCode { get => _TemplateCode; set => UpdateField(ref _TemplateCode, value, nameof(TemplateCode)); }

 private HexInt? _TemplateCode;
 /// <summary>
 /// Indicates that this numbering level is from an earlier word processor that did not support full WordprocessingML numbering properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.LegacyNumbering))]
 [OpenXmlElement(typeof(DXW.Level))]
 public LegacyNumbering? LegacyNumbering { get => _LegacyNumbering; set => UpdateField(ref _LegacyNumbering, value, nameof(LegacyNumbering)); }

 private LegacyNumbering? _LegacyNumbering;
 /// <summary>
 /// Justification for the numbering level (e.g., left, center, right).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.LevelJustification))]
 [OpenXmlElement(typeof(DXW.Level))]
 public LevelJustificationKind? LevelJustification { get => _LevelJustification; set => UpdateField(ref _LevelJustification, value, nameof(LevelJustification)); }

 private LevelJustificationKind? _LevelJustification;
 /// <summary>
 /// Run properties for the numbering symbol at this level, specifying formatting for the symbol.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Level.NumberingSymbolRunProperties))]
 [OpenXmlElement(typeof(DXW.Level))]
 public NumberingSymbolRunProperties? NumberingSymbolRunProperties { get => _NumberingSymbolRunProperties; set => UpdateField(ref _NumberingSymbolRunProperties, value, nameof(NumberingSymbolRunProperties)); }

 private NumberingSymbolRunProperties? _NumberingSymbolRunProperties;
}