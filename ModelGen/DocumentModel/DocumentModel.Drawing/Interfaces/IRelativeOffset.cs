namespace DocumentModel.Drawing;

/// <summary>
/// Relative Offset Effect.
/// </summary>
public interface IRelativeOffset // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Offset X
  /// </summary>
  public Int32? OffsetX { get ; set; }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  public Int32? OffsetY { get ; set; }
  
}
