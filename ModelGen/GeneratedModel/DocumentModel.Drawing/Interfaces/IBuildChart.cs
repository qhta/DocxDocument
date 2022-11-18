namespace DocumentModel.Drawing;

/// <summary>
/// Build Chart.
/// </summary>
public interface IBuildChart // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Build
  /// </summary>
  public string? Build { get ; set; }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public bool? AnimateBackground { get ; set; }
  
}
