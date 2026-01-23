namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an optional override applied to one or more levels from the abstract numbering definition for a given numbering definition instance in a WordprocessingML document.
/// Each instance of this element overrides the appearance and behavior of a specific numbering level definition within the abstract numbering definition, enabling advanced customization of list and outline numbering.
/// </summary>
[OpenXmlType(typeof(DXW.LevelOverride))]
  public class NumLevelOverride: ModelElement<DXW.LevelOverride>
  {
    
    /// <summary>
    /// Numbering level ID, specifying the zero-based index of the level being overridden.
    /// </summary>
    public Int32? LevelIndex { get; set; }
    
    /// <summary>
    /// Starting value override for the numbering level, specifying a new starting value for the overridden level.
    /// </summary>
    public Int32? StartOverrideNumberingValue { get; set; }
    
    /// <summary>
    /// Numbering level override definition, providing the set of properties that override the abstract numbering definition for this level.
    /// </summary>
    public NumLevel? Level { get; set; }
  }