namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LinePropertiesType Class.
/// </summary>
public interface LinePropertiesType
{
  /// <summary>
  /// line width
  /// </summary>
  public Int32? Width { get ; set; }
  
  /// <summary>
  /// line cap
  /// </summary>
  public DocumentModel.Drawings.LineCapKind? CapType { get ; set; }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public DocumentModel.Drawings.CompoundLineKind? CompoundLineType { get ; set; }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public DocumentModel.Drawings.PenAlignmentKind? Alignment { get ; set; }
  
}
