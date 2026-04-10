namespace DocumentModel.Drawings;
/// <summary>
/// Represents locking options for a connection shape, allowing restriction of various editing and formatting actions.
/// </summary>
[OpenXmlType(typeof(DXD.ConnectionShapeLocks))]
[XmlRoot("ConnectionShapeLocks", Namespace = "DocumentModel.Drawings")]
public partial class ConnectionShapeLocks : ModelElement<DXD.ConnectionShapeLocks>
{
 /// <summary>
 /// Gets or sets a value indicating whether grouping of the shape is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoGrouping))]
 public bool? NoGrouping { get => _NoGrouping; set => UpdateField(ref _NoGrouping, value, nameof(NoGrouping)); }

 private bool? _NoGrouping;
 /// <summary>
 /// Gets or sets a value indicating whether selection of the shape is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoSelection))]
 public bool? NoSelection { get => _NoSelection; set => UpdateField(ref _NoSelection, value, nameof(NoSelection)); }

 private bool? _NoSelection;
 /// <summary>
 /// Gets or sets a value indicating whether rotation of the shape is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoRotation))]
 public bool? NoRotation { get => _NoRotation; set => UpdateField(ref _NoRotation, value, nameof(NoRotation)); }

 private bool? _NoRotation;
 /// <summary>
 /// Gets or sets a value indicating whether changing the aspect ratio of the shape is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoChangeAspect))]
 public bool? NoChangeAspect { get => _NoChangeAspect; set => UpdateField(ref _NoChangeAspect, value, nameof(NoChangeAspect)); }

 private bool? _NoChangeAspect;
 /// <summary>
 /// Gets or sets a value indicating whether moving the shape is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoMove))]
 public bool? NoMove { get => _NoMove; set => UpdateField(ref _NoMove, value, nameof(NoMove)); }

 private bool? _NoMove;
 /// <summary>
 /// Gets or sets a value indicating whether resizing the shape is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoResize))]
 public bool? NoResize { get => _NoResize; set => UpdateField(ref _NoResize, value, nameof(NoResize)); }

 private bool? _NoResize;
 /// <summary>
 /// Gets or sets a value indicating whether editing the shape's points is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoEditPoints))]
 public bool? NoEditPoints { get => _NoEditPoints; set => UpdateField(ref _NoEditPoints, value, nameof(NoEditPoints)); }

 private bool? _NoEditPoints;
 /// <summary>
 /// Gets or sets a value indicating whether showing adjust handles on the shape is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoAdjustHandles))]
 public bool? NoAdjustHandles { get => _NoAdjustHandles; set => UpdateField(ref _NoAdjustHandles, value, nameof(NoAdjustHandles)); }

 private bool? _NoAdjustHandles;
 /// <summary>
 /// Gets or sets a value indicating whether changing the arrowheads of the connector is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoChangeArrowheads))]
 public bool? NoChangeArrowheads { get => _NoChangeArrowheads; set => UpdateField(ref _NoChangeArrowheads, value, nameof(NoChangeArrowheads)); }

 private bool? _NoChangeArrowheads;
 /// <summary>
 /// Gets or sets a value indicating whether changing the shape type is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.NoChangeShapeType))]
 public bool? NoChangeShapeType { get => _NoChangeShapeType; set => UpdateField(ref _NoChangeShapeType, value, nameof(NoChangeShapeType)); }

 private bool? _NoChangeShapeType;
 /// <summary>
 /// Extension list for additional connector locking options.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectionShapeLocks.ConnectorLockingExtensionList))]
 public ConnectorLockingExtensionList? ConnectorLockingExtensionList { get => _ConnectorLockingExtensionList; set => UpdateField(ref _ConnectorLockingExtensionList, value, nameof(ConnectorLockingExtensionList)); }

 private ConnectorLockingExtensionList? _ConnectorLockingExtensionList;
}