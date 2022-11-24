namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LinePropertiesType Class.
/// </summary>
public interface ILinePropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// line width
  /// </summary>
  public Int32? Width { get ; set; }
  
  /// <summary>
  /// line cap
  /// </summary>
  public LineCapValues? CapType { get ; set; }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public CompoundLineValues? CompoundLineType { get ; set; }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public PenAlignmentValues? Alignment { get ; set; }
  
}
