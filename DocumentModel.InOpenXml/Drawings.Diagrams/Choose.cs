namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Choose Element.
/// </summary>
[OpenXmlType(typeof(DXDD.Choose))]
public partial class Choose : ModelElement<DXDD.Choose>
{
  /// <summary>
  ///   Name
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Choose.Name))]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
  private string? _Name;
  /// <summary>
  /// Diagram Choose If.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.DiagramChooseIf))]
  public DiagramChooseIf? DiagramChooseIf { get => _DiagramChooseIf; set => UpdateField(ref _DiagramChooseIf, value, nameof(DiagramChooseIf)); }
  private DiagramChooseIf? _DiagramChooseIf;
  /// <summary>
  /// Diagram Choose Else.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.DiagramChooseElse))]
  public DiagramChooseElse? DiagramChooseElse { get => _DiagramChooseElse; set => UpdateField(ref _DiagramChooseElse, value, nameof(DiagramChooseElse)); }
  private DiagramChooseElse? _DiagramChooseElse;
}