namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LinePropertiesType Class.
/// </summary>
public interface ILinePropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// line width
  /// </summary>
  public System.Int32? Width { get ; set; }
  
  /// <summary>
  /// line cap
  /// </summary>
  public DocumentModel.Drawing.LineCapKind? CapType { get ; set; }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public DocumentModel.Drawing.CompoundLineKind? CompoundLineType { get ; set; }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public DocumentModel.Drawing.PenAlignmentKind? Alignment { get ; set; }
  
}
