namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single diagram node within a diagram.
/// </summary>
public partial interface DiagramNode : InteropObject
{
  /// <summary>
  /// The children.
  /// </summary>
  public DiagramNodeChildren Children { get; }

  /// <summary>
  /// The shape.
  /// </summary>
  public Shape Shape { get; }

  /// <summary>
  /// The root.
  /// </summary>
  public DiagramNode Root { get; }

  /// <summary>
  /// The diagram.
  /// </summary>
  public Diagram Diagram { get; }

  /// <summary>
  /// The layout.
  /// </summary>
  public Core.MsoOrgChartLayoutType Layout { get; set; }

  /// <summary>
  /// The text shape.
  /// </summary>
  public Shape TextShape { get; }
}
