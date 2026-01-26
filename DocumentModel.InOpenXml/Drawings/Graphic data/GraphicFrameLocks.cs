namespace DocumentModel.Drawings;
/// <summary>
///   Represents locking options for a graphic frame, restricting user actions such as grouping, selection, movement, and resizing.
/// </summary>
[OpenXmlType(typeof(DXD.GraphicFrameLocks))]
public partial class GraphicFrameLocks : ModelElement<DXD.GraphicFrameLocks>, IExtendableElement
{
 /// <summary>
 ///   Disallows grouping of the graphic frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GraphicFrameLocks.NoGrouping))]
 [OpenXmlElement(typeof(DXD.GraphicFrameLocks))]
 public bool? NoGrouping { get => _NoGrouping; set => UpdateField(ref _NoGrouping, value, nameof(NoGrouping)); }

 private bool? _NoGrouping;
 /// <summary>
 ///   Disallows selection of child shapes within the graphic frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GraphicFrameLocks.NoDrilldown))]
 [OpenXmlElement(typeof(DXD.GraphicFrameLocks))]
 public bool? NoDrilldown { get => _NoDrilldown; set => UpdateField(ref _NoDrilldown, value, nameof(NoDrilldown)); }

 private bool? _NoDrilldown;
 /// <summary>
 ///   Disallows selection of the graphic frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GraphicFrameLocks.NoSelection))]
 [OpenXmlElement(typeof(DXD.GraphicFrameLocks))]
 public bool? NoSelection { get => _NoSelection; set => UpdateField(ref _NoSelection, value, nameof(NoSelection)); }

 private bool? _NoSelection;
 /// <summary>
 ///   Disallows changing the aspect ratio of the graphic frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GraphicFrameLocks.NoChangeAspect))]
 [OpenXmlElement(typeof(DXD.GraphicFrameLocks))]
 public bool? NoChangeAspect { get => _NoChangeAspect; set => UpdateField(ref _NoChangeAspect, value, nameof(NoChangeAspect)); }

 private bool? _NoChangeAspect;
 /// <summary>
 ///   Disallows moving the graphic frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GraphicFrameLocks.NoMove))]
 [OpenXmlElement(typeof(DXD.GraphicFrameLocks))]
 public bool? NoMove { get => _NoMove; set => UpdateField(ref _NoMove, value, nameof(NoMove)); }

 private bool? _NoMove;
 /// <summary>
 ///   Disallows resizing the graphic frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GraphicFrameLocks.NoResize))]
 [OpenXmlElement(typeof(DXD.GraphicFrameLocks))]
 public bool? NoResize { get => _NoResize; set => UpdateField(ref _NoResize, value, nameof(NoResize)); }

 private bool? _NoResize;
 /// <summary>
 /// List of extensions for the graphic frame locks.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GraphicFrameLocks.ExtensionList))]
 [OpenXmlElement(typeof(DXD.GraphicFrameLocks))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}