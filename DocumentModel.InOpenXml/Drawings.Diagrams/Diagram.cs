namespace DocumentModel.Drawings;

/// <summary>
///   Diagram to Animate.
/// </summary>
[OpenXmlType(typeof(DXD.Diagram))]
/// <summary>
/// Represents the Diagram.
/// </summary>
public class Diagram: ModelElement<DXD.Diagram>
{
  /// <summary>
  ///   Identifier
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Animation Build Step
  /// </summary>
  public DiagramBuildStep? BuildStep { get; set; }
}
