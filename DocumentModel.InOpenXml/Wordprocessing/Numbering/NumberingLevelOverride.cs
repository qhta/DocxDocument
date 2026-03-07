namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents an optional override applied to one or more levels from the abstract numbering definition for a given numbering definition instance in a WordprocessingML document.
/// Each instance of this element overrides the appearance and behavior of a specific numbering level definition within the abstract numbering definition, enabling advanced customization of list and outline numbering.
/// </summary>
[OpenXmlType(typeof(DXW.LevelOverride))]
public partial class NumberingLevelOverride : ModelElement<DXW.LevelOverride>
{
 /// <summary>
 /// Numbering level ID, specifying the zero-based index of the level being overridden.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.LevelOverride.LevelIndex))]
 public NumLevel? LevelIndex { get => _LevelIndex; set => UpdateField(ref _LevelIndex, value, nameof(LevelIndex)); }

 private NumLevel? _LevelIndex;
 /// <summary>
 /// Starting value override for the numbering level, specifying a new starting value for the overridden level.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.LevelOverride.StartOverrideNumberingValue))]
 public Int32? StartOverrideNumberingValue { get => _StartOverrideNumberingValue; set => UpdateField(ref _StartOverrideNumberingValue, value, nameof(StartOverrideNumberingValue)); }

 private Int32? _StartOverrideNumberingValue;
 /// <summary>
 /// Numbering level override definition, providing the set of properties that override the abstract numbering definition for this level.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.LevelOverride.Level))]
 public NumberingLevel? Level { get => _Level; set => UpdateField(ref _Level, value, nameof(Level)); }

 private NumberingLevel? _Level;
}