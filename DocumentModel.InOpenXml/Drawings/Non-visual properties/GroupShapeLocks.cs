namespace DocumentModel.Drawings;

/// <summary>
///   Represents locking options for a group shape, restricting user actions such as grouping, ungrouping, selection, rotation, movement, and resizing.
/// </summary>
[OpenXmlType(typeof(DXD.GroupShapeLocks))]
[DataContract]
[XmlRoot("GroupShapeLocks", Namespace = "DocumentModel.Drawings")]
public partial class GroupShapeLocks: ModelElement<DXD.GroupShapeLocks>, IExtendableElement
{
  /// <summary>
  ///   Disallows grouping of shapes within the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.GroupShapeLocks.NoGrouping))]
  public bool? NoGrouping
  {
    get => _NoGrouping ??= GetProperty<bool?>(GetUpdatableElement()?.NoGrouping);
    set => UpdateField(ref _NoGrouping, value, nameof(NoGrouping));
  }

  private bool? _NoGrouping;

  /// <summary>
  ///   Disallows ungrouping of the group shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.GroupShapeLocks.NoUngrouping))]
  public bool? NoUngrouping
  {
    get => _NoUngrouping ??= GetProperty<bool?>(GetUpdatableElement()?.NoUngrouping);
    set => UpdateField(ref _NoUngrouping, value, nameof(NoUngrouping));
  }

  private bool? _NoUngrouping;

  /// <summary>
  ///   Disallows selection of the group shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.GroupShapeLocks.NoSelection))]
  public bool? NoSelection
  {
    get => _NoSelection ??= GetProperty<bool?>(GetUpdatableElement()?.NoSelection);
    set => UpdateField(ref _NoSelection, value, nameof(NoSelection));
  }

  private bool? _NoSelection;

  /// <summary>
  ///   Disallows rotation of the group shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.GroupShapeLocks.NoRotation))]
  public bool? NoRotation
  {
    get => _NoRotation ??= GetProperty<bool?>(GetUpdatableElement()?.NoRotation);
    set => UpdateField(ref _NoRotation, value, nameof(NoRotation));
  }

  private bool? _NoRotation;

  /// <summary>
  ///   Disallows changing the aspect ratio of the group shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.GroupShapeLocks.NoChangeAspect))]
  public bool? NoChangeAspect
  {
    get => _NoChangeAspect ??= GetProperty<bool?>(GetUpdatableElement()?.NoChangeAspect);
    set => UpdateField(ref _NoChangeAspect, value, nameof(NoChangeAspect));
  }

  private bool? _NoChangeAspect;

  /// <summary>
  ///   Disallows moving the group shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.GroupShapeLocks.NoMove))]
  public bool? NoMove
  {
    get => _NoMove ??= GetProperty<bool?>(GetUpdatableElement()?.NoMove);
    set => UpdateField(ref _NoMove, value, nameof(NoMove));
  }

  private bool? _NoMove;

  /// <summary>
  ///   Disallows resizing the group shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.GroupShapeLocks.NoResize))]
  public bool? NoResize
  {
    get => _NoResize ??= GetProperty<bool?>(GetUpdatableElement()?.NoResize);
    set => UpdateField(ref _NoResize, value, nameof(NoResize));
  }

  private bool? _NoResize;

  /// <summary>
  /// List of extension elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.GroupShapeLocks.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<ExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}