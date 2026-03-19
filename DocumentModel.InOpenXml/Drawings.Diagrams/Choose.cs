namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Choose Element.
/// </summary>
[OpenXmlType(typeof(DXDD.Choose))]
/// <summary>
/// Represents the Choose.
/// </summary>
public class Choose: ModelElement<DXDD.Choose>
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  /// Diagram Choose If.
  /// </summary>
  public DiagramChooseIf? DiagramChooseIf { get; set; }
  /// <summary>
  /// Diagram Choose Else.
  /// </summary>
  public DiagramChooseElse? DiagramChooseElse { get; set; }
}

