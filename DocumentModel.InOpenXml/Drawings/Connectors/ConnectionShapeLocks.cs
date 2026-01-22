namespace DocumentModel.Drawings;
/// <summary>
/// Represents locking options for a connection shape, allowing restriction of various editing and formatting actions.
/// </summary>
public partial class ConnectionShapeLocks : ModelElement<DXD.ConnectionShapeLocks>
{
    /// <summary>
    /// Gets or sets a value indicating whether grouping of the shape is disallowed.
    /// </summary>
    public bool? NoGrouping { get => _NoGrouping; set => UpdateField(ref _NoGrouping, value, nameof(NoGrouping)); }

    private bool? _NoGrouping;
    /// <summary>
    /// Gets or sets a value indicating whether selection of the shape is disallowed.
    /// </summary>
    public bool? NoSelection { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether rotation of the shape is disallowed.
    /// </summary>
    public bool? NoRotation { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether changing the aspect ratio of the shape is disallowed.
    /// </summary>
    public bool? NoChangeAspect { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether moving the shape is disallowed.
    /// </summary>
    public bool? NoMove { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether resizing the shape is disallowed.
    /// </summary>
    public bool? NoResize { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether editing the shape's points is disallowed.
    /// </summary>
    public bool? NoEditPoints { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether showing adjust handles on the shape is disallowed.
    /// </summary>
    public bool? NoAdjustHandles { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether changing the arrowheads of the connector is disallowed.
    /// </summary>
    public bool? NoChangeArrowheads { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether changing the shape type is disallowed.
    /// </summary>
    public bool? NoChangeShapeType { get; set; }
    /// <summary>
    /// Extension list for additional connector locking options.
    /// </summary>
    public ConnectorLockingExtensionList? ConnectorLockingExtensionList { get; set; }
}