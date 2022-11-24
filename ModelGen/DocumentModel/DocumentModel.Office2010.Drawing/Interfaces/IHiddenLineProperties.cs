namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public interface IHiddenLineProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
