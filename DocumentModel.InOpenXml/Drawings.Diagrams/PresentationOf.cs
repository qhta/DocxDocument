namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Presentation Of.
/// </summary>
[OpenXmlType(typeof(DXDD.PresentationOf))]
[XmlRoot("PresentationOf", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class PresentationOf : ModelElement<DXDD.PresentationOf>
{
 /// <summary>
 ///   Axis
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PresentationOf.Axis))]
 public List<AxisType>? Axis { get => _Axis; set => UpdateField(ref _Axis, value, nameof(Axis)); }
 private List<AxisType>? _Axis;

 /// <summary>
 ///   Data Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PresentationOf.PointType))]
 public List<ElementType>? PointType { get => _PointType; set => UpdateField(ref _PointType, value, nameof(PointType)); }
 private List<ElementType>? _PointType;

 /// <summary>
 ///   Hide Last Transition
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PresentationOf.HideLastTrans))]
 public List<Boolean>? HideLastTrans { get => _HideLastTrans; set => UpdateField(ref _HideLastTrans, value, nameof(HideLastTrans)); }
 private List<Boolean>? _HideLastTrans;

 /// <summary>
 ///   Start
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PresentationOf.Start))]
 public List<Int32>? Start { get => _Start; set => UpdateField(ref _Start, value, nameof(Start)); }
 private List<Int32>? _Start;

 /// <summary>
 ///   Count
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PresentationOf.Count))]
 public List<UInt32>? Count { get => _Count; set => UpdateField(ref _Count, value, nameof(Count)); }
 private List<UInt32>? _Count;

 /// <summary>
 ///   Step
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PresentationOf.Step))]
 public List<Int32>? Step { get => _Step; set => UpdateField(ref _Step, value, nameof(Step)); }
 private List<Int32>? _Step;

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.PresentationOf.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}