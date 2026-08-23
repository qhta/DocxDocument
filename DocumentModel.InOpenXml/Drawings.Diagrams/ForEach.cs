namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   For Each.
/// </summary>
[OpenXmlType(typeof(DXDD.ForEach))]
[DataContract]
[XmlRoot("ForEach", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class ForEach : ModelElement<DXDD.ForEach>
{
  /// <summary>
  ///   Name
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ForEach.Name))]
  public string? Name
  {
    get => _Name ??= GetProperty<string?>(GetUpdatableElement()?.Name);
    set => UpdateField(ref _Name, value, nameof(Name));
  }
  private string? _Name;

  /// <summary>
  ///   Reference
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ForEach.Reference))]
  public string? Reference
  {
    get => _Reference ??= GetProperty<string?>(GetUpdatableElement()?.Reference);
    set => UpdateField(ref _Reference, value, nameof(Reference));
  }
  private string? _Reference;

  /// <summary>
  ///   Axis
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ForEach.Axis))]
  public List<AxisType>? Axis
  {
    get => _Axis ??= GetProperty<List<AxisType>?>(GetUpdatableElement()?.Axis);
    set => UpdateField(ref _Axis, value, nameof(Axis));
  }
  private List<AxisType>? _Axis;

  /// <summary>
  ///   Data Point Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ForEach.PointType))]
  public List<ElementType>? PointType
  {
    get => _PointType ??= GetProperty<List<ElementType>?>(GetUpdatableElement()?.PointType);
    set => UpdateField(ref _PointType, value, nameof(PointType));
  }
  private List<ElementType>? _PointType;

  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ForEach.HideLastTrans))]
  public List<Boolean>? HideLastTrans
  {
    get => _HideLastTrans ??= GetProperty<List<Boolean>?>(GetUpdatableElement()?.HideLastTrans);
    set => UpdateField(ref _HideLastTrans, value, nameof(HideLastTrans));
  }
  private List<Boolean>? _HideLastTrans;

  /// <summary>
  ///   Start
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ForEach.Start))]
  public List<Int32>? Start
  {
    get => _Start ??= GetProperty<List<Int32>?>(GetUpdatableElement()?.Start);
    set => UpdateField(ref _Start, value, nameof(Start));
  }
  private List<Int32>? _Start;

  /// <summary>
  ///   Count
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ForEach.Count))]
  public List<UInt32>? Count
  {
    get => _Count ??= GetProperty<List<UInt32>?>(GetUpdatableElement()?.Count);
    set => UpdateField(ref _Count, value, nameof(Count));
  }
  private List<UInt32>? _Count;

  /// <summary>
  ///   Step
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ForEach.Step))]
  public List<Int32>? Step
  {
    get => _Step ??= GetProperty<List<Int32>?>(GetUpdatableElement()?.Step);
    set => UpdateField(ref _Step, value, nameof(Step));
  }
  private List<Int32>? _Step;

  /// <summary>
  /// Algorithm.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Algorithm))]
  public Algorithm? Algorithm
  {
    get => _Algorithm ??= GetElement<Algorithm, DXDD.Algorithm>(GetUpdatableElement());
    set => UpdateField(ref _Algorithm, value, nameof(Algorithm));
  }
  private Algorithm? _Algorithm;

  /// <summary>
  /// Shape.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Shape))]
  public Shape? Shape
  {
    get => _Shape ??= GetElement<Shape, DXDD.Shape>(GetUpdatableElement());
    set => UpdateField(ref _Shape, value, nameof(Shape));
  }
  private Shape? _Shape;

  /// <summary>
  /// Presentation Of.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.PresentationOf))]
  public PresentationOf? PresentationOf
  {
    get => _PresentationOf ??= GetElement<PresentationOf, DXDD.PresentationOf>(GetUpdatableElement());
    set => UpdateField(ref _PresentationOf, value, nameof(PresentationOf));
  }
  private PresentationOf? _PresentationOf;

  /// <summary>
  /// Constraints.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Constraints))]
  public Constraints? Constraints
  {
    get => _Constraints ??= GetElement<Constraints, DXDD.Constraints>(GetUpdatableElement());
    set => UpdateField(ref _Constraints, value, nameof(Constraints));
  }
  private Constraints? _Constraints;

  /// <summary>
  /// Rule List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.RuleList))]
  public RuleList? RuleList
  {
    get => _RuleList ??= GetElement<RuleList, DXDD.RuleList>(GetUpdatableElement());
    set => UpdateField(ref _RuleList, value, nameof(RuleList));
  }
  private RuleList? _RuleList;

  /// <summary>
  /// Child For Each.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ForEach))]
  public ForEach? ChildForEach
  {
    get => _ChildForEach ??= GetElement<ForEach, DXDD.ForEach>(GetUpdatableElement());
    set => UpdateField(ref _ChildForEach, value, nameof(ChildForEach));
  }
  private ForEach? _ChildForEach;

  /// <summary>
  /// Layout Node.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.LayoutNode))]
  public LayoutNode? LayoutNode
  {
    get => _LayoutNode ??= GetElement<LayoutNode, DXDD.LayoutNode>(GetUpdatableElement());
    set => UpdateField(ref _LayoutNode, value, nameof(LayoutNode));
  }
  private LayoutNode? _LayoutNode;

  /// <summary>
  /// Choose.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Choose))]
  public Choose? Choose
  {
    get => _Choose ??= GetElement<Choose, DXDD.Choose>(GetUpdatableElement());
    set => UpdateField(ref _Choose, value, nameof(Choose));
  }
  private Choose? _Choose;

  /// <summary>
  /// Extension List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetElement<IExtensionList, DXDD.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private IExtensionList? _ExtensionList;
}