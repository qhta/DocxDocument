namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Else.
/// </summary>
[OpenXmlType(typeof(DXDD.DiagramChooseElse))]
public partial class DiagramChooseElse : ModelElement<DXDD.DiagramChooseElse>
{
  /// <summary>
  ///   Name
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DiagramChooseElse.Name))]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

  private string? _Name;
  /// <summary>
  /// Algorithm.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Algorithm))]
  public Algorithm? Algorithm { get => _Algorithm; set => UpdateField(ref _Algorithm, value, nameof(Algorithm)); }

  private Algorithm? _Algorithm;
  /// <summary>
  /// Shape.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Shape))]
  public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

  private Shape? _Shape;
  /// <summary>
  /// Presentation Of.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.PresentationOf))]
  public PresentationOf? PresentationOf { get => _PresentationOf; set => UpdateField(ref _PresentationOf, value, nameof(PresentationOf)); }

  private PresentationOf? _PresentationOf;
  /// <summary>
  /// Constraints.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Constraints))]
  public Constraints? Constraints { get => _Constraints; set => UpdateField(ref _Constraints, value, nameof(Constraints)); }

  private Constraints? _Constraints;
  /// <summary>
  /// Rule List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.RuleList))]
  public RuleList? RuleList { get => _RuleList; set => UpdateField(ref _RuleList, value, nameof(RuleList)); }

  private RuleList? _RuleList;
  /// <summary>
  /// For Each.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ForEach))]
  public ForEach? ForEach { get => _ForEach; set => UpdateField(ref _ForEach, value, nameof(ForEach)); }

  private ForEach? _ForEach;
  /// <summary>
  /// Layout Node.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.LayoutNode))]
  public LayoutNode? LayoutNode { get => _LayoutNode; set => UpdateField(ref _LayoutNode, value, nameof(LayoutNode)); }

  private LayoutNode? _LayoutNode;
  /// <summary>
  /// Choose.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Choose))]
  public Choose? Choose { get => _Choose; set => UpdateField(ref _Choose, value, nameof(Choose)); }

  private Choose? _Choose;
  /// <summary>
  /// Extension List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}