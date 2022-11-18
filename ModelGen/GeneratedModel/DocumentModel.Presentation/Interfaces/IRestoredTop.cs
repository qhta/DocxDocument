namespace DocumentModel.Presentation;

/// <summary>
/// Normal View Restored Top Properties.
/// </summary>
public interface IRestoredTop // : DocumentFormat.OpenXml.Presentation.NormalViewPortionType
{
  /// <summary>
  /// Normal View Dimension Size
  /// </summary>
  public int? Size { get ; set; }
  
  /// <summary>
  /// Auto Adjust Normal View
  /// </summary>
  public bool? AutoAdjust { get ; set; }
  
}
