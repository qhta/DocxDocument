namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies that a given numbering level is from an earlier word processing application 
///   which did not support the full richness of the numbering properties supported by WordprocessingML.
/// </summary>
public record LegacyNumbering
{
  /// <summary>
  ///   Use Legacy Numbering Properties
  /// </summary>
  public Boolean Use { get; set; }

  /// <summary>
  ///   Legacy Spacing
  /// </summary>
  public DXA Space { get; set; }

  /// <summary>
  ///   Legacy Indent
  /// </summary>
  public DXA Indent { get; set; }
}