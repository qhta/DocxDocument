namespace DocumentModel.Drawing;

/// <summary>
/// Build Chart.
/// </summary>
public interface IBuildChart // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Build
  /// </summary>
  public String? Build { get ; set; }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public Boolean? AnimateBackground { get ; set; }
  
}
