namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Choose Element.
/// </summary>
[OpenXmlType(typeof(DXDD.Choose))]
public class Choose: ModelElement<DXDD.Choose>
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
  public DiagramChooseIf? DiagramChooseIf { get; set; }
  public DiagramChooseElse? DiagramChooseElse { get; set; }
}