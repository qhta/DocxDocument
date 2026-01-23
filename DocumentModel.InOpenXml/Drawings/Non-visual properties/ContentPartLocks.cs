namespace DocumentModel.Drawings;
/// <summary>
///   Represents the set of locks that can be applied to a content part in a drawing.
///   These locks restrict certain user actions such as grouping, selection, rotation, and resizing.
/// </summary>
public partial class ContentPartLocks : ModelElement<DXO10D.ContentPartLocks>, IOfficeArtExtendableElement
{
    /// <summary>
    ///   Disallows grouping of the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoGrouping))]
    public bool? NoGrouping { get => _NoGrouping; set => UpdateField(ref _NoGrouping, value, nameof(NoGrouping)); }

    private bool? _NoGrouping;
    /// <summary>
    ///   Disallows selection of the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoSelection))]
    public bool? NoSelection { get => _NoSelection; set => UpdateField(ref _NoSelection, value, nameof(NoSelection)); }

    private bool? _NoSelection;
    /// <summary>
    ///   Disallows rotation of the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoRotation))]
    public bool? NoRotation { get => _NoRotation; set => UpdateField(ref _NoRotation, value, nameof(NoRotation)); }

    private bool? _NoRotation;
    /// <summary>
    ///   Disallows changing the aspect ratio of the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoChangeAspect))]
    public bool? NoChangeAspect { get => _NoChangeAspect; set => UpdateField(ref _NoChangeAspect, value, nameof(NoChangeAspect)); }

    private bool? _NoChangeAspect;
    /// <summary>
    ///   Disallows moving the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoMove))]
    public bool? NoMove { get => _NoMove; set => UpdateField(ref _NoMove, value, nameof(NoMove)); }

    private bool? _NoMove;
    /// <summary>
    ///   Disallows resizing the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoResize))]
    public bool? NoResize { get => _NoResize; set => UpdateField(ref _NoResize, value, nameof(NoResize)); }

    private bool? _NoResize;
    /// <summary>
    ///   Disallows editing the points of the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoEditPoints))]
    public bool? NoEditPoints { get => _NoEditPoints; set => UpdateField(ref _NoEditPoints, value, nameof(NoEditPoints)); }

    private bool? _NoEditPoints;
    /// <summary>
    ///   Disallows showing adjustment handles on the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoAdjustHandles))]
    public bool? NoAdjustHandles { get => _NoAdjustHandles; set => UpdateField(ref _NoAdjustHandles, value, nameof(NoAdjustHandles)); }

    private bool? _NoAdjustHandles;
    /// <summary>
    ///   Disallows changing arrowheads on the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoChangeArrowheads))]
    public bool? NoChangeArrowheads { get => _NoChangeArrowheads; set => UpdateField(ref _NoChangeArrowheads, value, nameof(NoChangeArrowheads)); }

    private bool? _NoChangeArrowheads;
    /// <summary>
    ///   Disallows changing the shape type of the content part.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.NoChangeShapeType))]
    public bool? NoChangeShapeType { get => _NoChangeShapeType; set => UpdateField(ref _NoChangeShapeType, value, nameof(NoChangeShapeType)); }

    private bool? _NoChangeShapeType;
    [OpenXmlProperty(nameof(DXO10D.ContentPartLocks.OfficeArtExtensionList))]
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}