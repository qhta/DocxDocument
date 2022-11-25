namespace DocumentModel.Drawing;

/// <summary>
/// Build Diagram.
/// </summary>
public interface IBuildDiagram // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Build
  /// </summary>
  public System.String? Build { get ; set; }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  public System.Boolean? ReverseAnimation { get ; set; }
  
}
