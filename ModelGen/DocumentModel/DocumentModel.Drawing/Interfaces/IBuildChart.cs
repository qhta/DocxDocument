namespace DocumentModel.Drawing;

/// <summary>
/// Build Chart.
/// </summary>
public interface IBuildChart // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Build
  /// </summary>
  public System.String? Build { get ; set; }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public System.Boolean? AnimateBackground { get ; set; }
  
}
