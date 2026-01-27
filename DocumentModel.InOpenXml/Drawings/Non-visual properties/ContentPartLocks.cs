namespace DocumentModel.Drawings;
/// <summary>
///   Represents the set of locks that can be applied to a content part in DrawingML, restricting user actions such as grouping, selection, rotation, resizing, and editing.
///   Enables fine-grained control over user interaction with content parts in Office drawings.
/// </summary>
[OpenXmlType(typeof(DXO10D.ContentPartLocks))]
public partial class ContentPartLocks : ModelElement<DXO10D.ContentPartLocks>, IOfficeArtExtendableElement
{
  /// <summary>
  ///   Prevents grouping of the content part with other shapes or objects.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoGrouping))]
  public bool? NoGrouping { get => _NoGrouping; set => UpdateField(ref _NoGrouping, value, nameof(NoGrouping)); }

  private bool? _NoGrouping;

  /// <summary>
  ///   Prevents selection of the content part in the user interface.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoSelection))]
  public bool? NoSelection { get => _NoSelection; set => UpdateField(ref _NoSelection, value, nameof(NoSelection)); }

  private bool? _NoSelection;

  /// <summary>
  ///   Prevents rotation of the content part.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoRotation))]
  public bool? NoRotation { get => _NoRotation; set => UpdateField(ref _NoRotation, value, nameof(NoRotation)); }

  private bool? _NoRotation;

  /// <summary>
  ///   Prevents changing the aspect ratio of the content part.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoChangeAspect))]
  public bool? NoChangeAspect { get => _NoChangeAspect; set => UpdateField(ref _NoChangeAspect, value, nameof(NoChangeAspect)); }

  private bool? _NoChangeAspect;

  /// <summary>
  ///   Prevents moving the content part to a different location.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoMove))]
  public bool? NoMove { get => _NoMove; set => UpdateField(ref _NoMove, value, nameof(NoMove)); }

  private bool? _NoMove;

  /// <summary>
  ///   Prevents resizing the content part.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoResize))]
  public bool? NoResize { get => _NoResize; set => UpdateField(ref _NoResize, value, nameof(NoResize)); }

  private bool? _NoResize;

  /// <summary>
  ///   Prevents editing the points of the content part (e.g., for freeform shapes).
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoEditPoints))]
  public bool? NoEditPoints { get => _NoEditPoints; set => UpdateField(ref _NoEditPoints, value, nameof(NoEditPoints)); }

  private bool? _NoEditPoints;

  /// <summary>
  ///   Prevents showing adjustment handles on the content part.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoAdjustHandles))]
  public bool? NoAdjustHandles { get => _NoAdjustHandles; set => UpdateField(ref _NoAdjustHandles, value, nameof(NoAdjustHandles)); }

  private bool? _NoAdjustHandles;

  /// <summary>
  ///   Prevents changing arrowheads on the content part (for lines or connectors).
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoChangeArrowheads))]
  public bool? NoChangeArrowheads { get => _NoChangeArrowheads; set => UpdateField(ref _NoChangeArrowheads, value, nameof(NoChangeArrowheads)); }

  private bool? _NoChangeArrowheads;

  /// <summary>
  ///   Prevents changing the shape type of the content part.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoChangeShapeType))]
  public bool? NoChangeShapeType { get => _NoChangeShapeType; set => UpdateField(ref _NoChangeShapeType, value, nameof(NoChangeShapeType)); }

  private bool? _NoChangeShapeType;

  /// <summary>
  ///   List of OfficeArt extension elements for the content part locks, supporting extensibility and application-specific data.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.OfficeArtExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

  private OfficeArtExtensionList? _OfficeArtExtensionList;
}
