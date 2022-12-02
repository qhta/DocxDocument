namespace DocumentModel.Drawing;

/// <summary>
/// Build Diagram.
/// </summary>
public interface IBuildDiagram // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Build
  /// </summary>
  public String? Build { get ; set; }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  public Boolean? ReverseAnimation { get ; set; }
  
}
