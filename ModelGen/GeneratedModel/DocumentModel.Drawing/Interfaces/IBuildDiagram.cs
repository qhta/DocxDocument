namespace DocumentModel.Drawing;

/// <summary>
/// Build Diagram.
/// </summary>
public interface IBuildDiagram // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Build
  /// </summary>
  public string? Build { get ; set; }
  
  /// <summary>
  /// Reverse Animation
  /// </summary>
  public bool? ReverseAnimation { get ; set; }
  
}
