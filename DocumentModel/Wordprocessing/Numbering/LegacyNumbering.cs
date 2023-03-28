namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies that a given numbering level is from an earlier word processing application 
///   which did not support the full richness of the numbering properties supported by WordprocessingML.
/// </summary>
public class LegacyNumbering : ModelElement
{
  /// <summary>
  ///   Use Legacy Numbering Properties
  /// </summary>
  public Boolean? Legacy { get; set; }

  /// <summary>
  ///   Legacy Spacing
  /// </summary>
  public DXA? LegacySpace { get; set; }

  /// <summary>
  ///   Legacy Indent
  /// </summary>
  public DXA? LegacyIndent { get; set; }
}