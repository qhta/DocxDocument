namespace DocumentModel.Drawings;

/// <summary>
///   Represents locking options for a shape, restricting user actions such as grouping, selection, rotation, resizing, and editing.
/// </summary>
[OpenXmlType(typeof(DXD.ShapeLocks))]
[DataContract]
[XmlRoot("ShapeLocks", Namespace = "DocumentModel.Drawings")]
public partial class ShapeLocks: ModelElement<DXD.ShapeLocks>, IExtendableElement
{
  /// <summary>
  ///   Disallows grouping of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoGrouping))]
  public bool? NoGrouping
  {
    get => _NoGrouping ??= GetProperty<bool?>(GetUpdatableElement()?.NoGrouping);
    set => UpdateField(ref _NoGrouping, value, nameof(NoGrouping));
  }

  private bool? _NoGrouping;

  /// <summary>
  ///   Disallows selection of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoSelection))]
  public bool? NoSelection
  {
    get => _NoSelection ??= GetProperty<bool?>(GetUpdatableElement()?.NoSelection);
    set => UpdateField(ref _NoSelection, value, nameof(NoSelection));
  }

  private bool? _NoSelection;

  /// <summary>
  ///   Disallows rotation of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoRotation))]
  public bool? NoRotation
  {
    get => _NoRotation ??= GetProperty<bool?>(GetUpdatableElement()?.NoRotation);
    set => UpdateField(ref _NoRotation, value, nameof(NoRotation));
  }

  private bool? _NoRotation;

  /// <summary>
  ///   Disallows changing the aspect ratio of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoChangeAspect))]
  public bool? NoChangeAspect
  {
    get => _NoChangeAspect ??= GetProperty<bool?>(GetUpdatableElement()?.NoChangeAspect);
    set => UpdateField(ref _NoChangeAspect, value, nameof(NoChangeAspect));
  }

  private bool? _NoChangeAspect;

  /// <summary>
  ///   Disallows moving the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoMove))]
  public bool? NoMove
  {
    get => _NoMove ??= GetProperty<bool?>(GetUpdatableElement()?.NoMove);
    set => UpdateField(ref _NoMove, value, nameof(NoMove));
  }

  private bool? _NoMove;

  /// <summary>
  ///   Disallows resizing the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoResize))]
  public bool? NoResize
  {
    get => _NoResize ??= GetProperty<bool?>(GetUpdatableElement()?.NoResize);
    set => UpdateField(ref _NoResize, value, nameof(NoResize));
  }

  private bool? _NoResize;

  /// <summary>
  ///   Disallows editing the points of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoEditPoints))]
  public bool? NoEditPoints
  {
    get => _NoEditPoints ??= GetProperty<bool?>(GetUpdatableElement()?.NoEditPoints);
    set => UpdateField(ref _NoEditPoints, value, nameof(NoEditPoints));
  }

  private bool? _NoEditPoints;

  /// <summary>
  ///   Disallows showing adjustment handles on the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoAdjustHandles))]
  public bool? NoAdjustHandles
  {
    get => _NoAdjustHandles ??= GetProperty<bool?>(GetUpdatableElement()?.NoAdjustHandles);
    set => UpdateField(ref _NoAdjustHandles, value, nameof(NoAdjustHandles));
  }

  private bool? _NoAdjustHandles;

  /// <summary>
  ///   Disallows changing arrowheads on the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoChangeArrowheads))]
  public bool? NoChangeArrowheads
  {
    get => _NoChangeArrowheads ??= GetProperty<bool?>(GetUpdatableElement()?.NoChangeArrowheads);
    set => UpdateField(ref _NoChangeArrowheads, value, nameof(NoChangeArrowheads));
  }

  private bool? _NoChangeArrowheads;

  /// <summary>
  ///   Disallows changing the shape type.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoChangeShapeType))]
  public bool? NoChangeShapeType
  {
    get => _NoChangeShapeType ??= GetProperty<bool?>(GetUpdatableElement()?.NoChangeShapeType);
    set => UpdateField(ref _NoChangeShapeType, value, nameof(NoChangeShapeType));
  }

  private bool? _NoChangeShapeType;

  /// <summary>
  ///   Disallows editing the shape's text.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.NoTextEdit))]
  public bool? NoTextEdit
  {
    get => _NoTextEdit ??= GetProperty<bool?>(GetUpdatableElement()?.NoTextEdit);
    set => UpdateField(ref _NoTextEdit, value, nameof(NoTextEdit));
  }

  private bool? _NoTextEdit;

  /// <summary>
  /// List of extension elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ShapeLocks.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<ExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}