namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Layout Node.
/// </summary>
[OpenXmlType(typeof(DXDD.LayoutNode))]
[DataContract]
[XmlRoot("LayoutNode", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class LayoutNode : ModelElement<DXDD.LayoutNode>
{
  /// <summary>
  ///   Name
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutNode.Name))]
  public string? Name { get => _Name ??= GetProperty<string?>(GetUpdatableElement()?.Name); set => UpdateField(ref _Name, value, nameof(Name)); }
  private string? _Name;

  /// <summary>
  ///   Style Label
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutNode.StyleLabel))]
  public string? StyleLabel { get => _StyleLabel ??= GetProperty<string?>(GetUpdatableElement()?.StyleLabel); set => UpdateField(ref _StyleLabel, value, nameof(StyleLabel)); }
  private string? _StyleLabel;

  /// <summary>
  ///   Child Order
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutNode.ChildOrder))]
  public ChildOrder? ChildOrder { get => _ChildOrder ??= GetProperty<ChildOrder?>(GetUpdatableElement()?.ChildOrder); set => UpdateField(ref _ChildOrder, value, nameof(ChildOrder)); }
  private ChildOrder? _ChildOrder;

  /// <summary>
  ///   Move With
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutNode.MoveWith))]
  public string? MoveWith { get => _MoveWith ??= GetProperty<string?>(GetUpdatableElement()?.MoveWith); set => UpdateField(ref _MoveWith, value, nameof(MoveWith)); }
  private string? _MoveWith;

  /// <summary>
  /// Algorithm.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Algorithm))]
  public Algorithm? Algorithm { get => _Algorithm ??= GetElement<Algorithm, DXDD.Algorithm>(GetUpdatableElement()); set => UpdateField(ref _Algorithm, value, nameof(Algorithm)); }
  private Algorithm? _Algorithm;

  /// <summary>
  /// Shape.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Shape))]
  public Shape? Shape { get => _Shape ??= GetElement<Shape, DXDD.Shape>(GetUpdatableElement()); set => UpdateField(ref _Shape, value, nameof(Shape)); }
  private Shape? _Shape;

  /// <summary>
  /// Presentation Of.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.PresentationOf))]
  public PresentationOf? PresentationOf { get => _PresentationOf ??= GetElement<PresentationOf, DXDD.PresentationOf>(GetUpdatableElement()); set => UpdateField(ref _PresentationOf, value, nameof(PresentationOf)); }
  private PresentationOf? _PresentationOf;

  /// <summary>
  /// Constraints.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Constraints))]
  public Constraints? Constraints { get => _Constraints ??= GetElement<Constraints, DXDD.Constraints>(GetUpdatableElement()); set => UpdateField(ref _Constraints, value, nameof(Constraints)); }
  private Constraints? _Constraints;

  /// <summary>
  /// Rule List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.RuleList))]
  public RuleList? RuleList { get => _RuleList ??= GetElement<RuleList, DXDD.RuleList>(GetUpdatableElement()); set => UpdateField(ref _RuleList, value, nameof(RuleList)); }
  private RuleList? _RuleList;

  /// <summary>
  /// Variable List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.VariableList))]
  public VariableList? VariableList { get => _VariableList ??= GetElement<VariableList, DXDD.VariableList>(GetUpdatableElement()); set => UpdateField(ref _VariableList, value, nameof(VariableList)); }
  private VariableList? _VariableList;

  /// <summary>
  /// For Each.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ForEach))]
  public ForEach? ForEach { get => _ForEach ??= GetElement<ForEach, DXDD.ForEach>(GetUpdatableElement()); set => UpdateField(ref _ForEach, value, nameof(ForEach)); }
  private ForEach? _ForEach;

  /// <summary>
  /// Child Layout Node.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.LayoutNode))]
  public LayoutNode? ChildLayoutNode { get => _ChildLayoutNode ??= GetElement<LayoutNode, DXDD.LayoutNode>(GetUpdatableElement()); set => UpdateField(ref _ChildLayoutNode, value, nameof(ChildLayoutNode)); }
  private LayoutNode? _ChildLayoutNode;

  /// <summary>
  /// Choose.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Choose))]
  public Choose? Choose { get => _Choose ??= GetElement<Choose, DXDD.Choose>(GetUpdatableElement()); set => UpdateField(ref _Choose, value, nameof(Choose)); }
  private Choose? _Choose;

  /// <summary>
  /// Extension List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ExtensionList))]
  public IExtensionList? ExtensionList { get => _ExtensionList ??= GetElement<IExtensionList, DXDD.ExtensionList>(GetUpdatableElement()); set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
  private IExtensionList? _ExtensionList;
}