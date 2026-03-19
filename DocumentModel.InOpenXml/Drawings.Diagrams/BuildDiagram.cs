namespace DocumentModel.Drawings;

/// <summary>
/// Represents build diagram options, including build type, reverse animation, and additional extension settings for diagram elements.
/// </summary>
[OpenXmlType(typeof(DXD.BuildDiagram))]
/// <summary>
/// Represents the Build Diagram.
/// </summary>
public class BuildDiagram: ModelElement<DXD.BuildDiagram>// , ExtendableElement
{
  /// <summary>
  /// Build type or sequence for the diagram.
  /// </summary>
  public string? Build { get; set; }

  /// <summary>
  /// Indicates whether the animation should be reversed.
  /// </summary>
  public bool? ReverseAnimation { get; set; }
}
