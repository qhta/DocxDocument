namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Manual Layout.
/// </summary>
[OpenXmlType(typeof(DXDC.ManualLayout))]
[XmlRoot("ManualLayout", Namespace = "DocumentModel.Drawings.Charts")]
public partial class ManualLayout : ModelElement<DXDC.ManualLayout>
{
 /// <summary>
 ///   Layout Target.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.LayoutTarget))]
 public LayoutTarget? LayoutTarget { get => _LayoutTarget; set => UpdateField(ref _LayoutTarget, value, nameof(LayoutTarget)); }
 private LayoutTarget? _LayoutTarget;

 /// <summary>
 ///   Left Mode.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.LeftMode))]
 public LayoutMode? LeftMode { get => _LeftMode; set => UpdateField(ref _LeftMode, value, nameof(LeftMode)); }
 private LayoutMode? _LeftMode;

 /// <summary>
 ///   Top Mode.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.TopMode))]
 public LayoutMode? TopMode { get => _TopMode; set => UpdateField(ref _TopMode, value, nameof(TopMode)); }
 private LayoutMode? _TopMode;

 /// <summary>
 ///   Width Mode.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.WidthMode))]
 public LayoutMode? WidthMode { get => _WidthMode; set => UpdateField(ref _WidthMode, value, nameof(WidthMode)); }
 private LayoutMode? _WidthMode;

 /// <summary>
 ///   Height Mode.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.HeightMode))]
 public LayoutMode? HeightMode { get => _HeightMode; set => UpdateField(ref _HeightMode, value, nameof(HeightMode)); }
 private LayoutMode? _HeightMode;

 /// <summary>
 ///   Left.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.Left))]
 public Double? Left { get => _Left; set => UpdateField(ref _Left, value, nameof(Left)); }
 private Double? _Left;

 /// <summary>
 ///   Top.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.Top))]
 public Double? Top { get => _Top; set => UpdateField(ref _Top, value, nameof(Top)); }
 private Double? _Top;

 /// <summary>
 ///   Width.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.Width))]
 public Double? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }
 private Double? _Width;

 /// <summary>
 ///   Height.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.Height))]
 public Double? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }
 private Double? _Height;

 /// <summary>
 ///   Chart Extensibility.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ManualLayout.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}