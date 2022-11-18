namespace DocumentModel.Drawing;

/// <summary>
/// Relative Offset Effect.
/// </summary>
public interface IRelativeOffset // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Offset X
  /// </summary>
  public int? OffsetX { get ; set; }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  public int? OffsetY { get ; set; }
  
}
