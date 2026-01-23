namespace DocumentModel.Drawings;
/// <summary>
///   Represents locking options for a picture, restricting user actions such as grouping, selection, rotation, resizing, cropping, and editing.
/// </summary>
public partial class PictureLocks : ModelElement<DXD.PictureLocks>, IExtendableElement
{
    /// <summary>
    ///   Disallows grouping of the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoGrouping))]
    public bool? NoGrouping { get => _NoGrouping; set => UpdateField(ref _NoGrouping, value, nameof(NoGrouping)); }

    private bool? _NoGrouping;
    /// <summary>
    ///   Disallows selection of the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoSelection))]
    public bool? NoSelection { get => _NoSelection; set => UpdateField(ref _NoSelection, value, nameof(NoSelection)); }

    private bool? _NoSelection;
    /// <summary>
    ///   Disallows rotation of the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoRotation))]
    public bool? NoRotation { get => _NoRotation; set => UpdateField(ref _NoRotation, value, nameof(NoRotation)); }

    private bool? _NoRotation;
    /// <summary>
    ///   Disallows changing the aspect ratio of the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoChangeAspect))]
    public bool? NoChangeAspect { get => _NoChangeAspect; set => UpdateField(ref _NoChangeAspect, value, nameof(NoChangeAspect)); }

    private bool? _NoChangeAspect;
    /// <summary>
    ///   Disallows moving the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoMove))]
    public bool? NoMove { get => _NoMove; set => UpdateField(ref _NoMove, value, nameof(NoMove)); }

    private bool? _NoMove;
    /// <summary>
    ///   Disallows resizing the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoResize))]
    public bool? NoResize { get => _NoResize; set => UpdateField(ref _NoResize, value, nameof(NoResize)); }

    private bool? _NoResize;
    /// <summary>
    ///   Disallows editing the points of the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoEditPoints))]
    public bool? NoEditPoints { get => _NoEditPoints; set => UpdateField(ref _NoEditPoints, value, nameof(NoEditPoints)); }

    private bool? _NoEditPoints;
    /// <summary>
    ///   Disallows showing adjustment handles on the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoAdjustHandles))]
    public bool? NoAdjustHandles { get => _NoAdjustHandles; set => UpdateField(ref _NoAdjustHandles, value, nameof(NoAdjustHandles)); }

    private bool? _NoAdjustHandles;
    /// <summary>
    ///   Disallows changing arrowheads on the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoChangeArrowheads))]
    public bool? NoChangeArrowheads { get => _NoChangeArrowheads; set => UpdateField(ref _NoChangeArrowheads, value, nameof(NoChangeArrowheads)); }

    private bool? _NoChangeArrowheads;
    /// <summary>
    ///   Disallows changing the picture type.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoChangeShapeType))]
    public bool? NoChangeShapeType { get => _NoChangeShapeType; set => UpdateField(ref _NoChangeShapeType, value, nameof(NoChangeShapeType)); }

    private bool? _NoChangeShapeType;
    /// <summary>
    ///   Disallows cropping the picture.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.NoCrop))]
    public bool? NoCrop { get => _NoCrop; set => UpdateField(ref _NoCrop, value, nameof(NoCrop)); }

    private bool? _NoCrop;
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.PictureLocks.ExtensionList))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}