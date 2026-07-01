namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a chart, including title, formatting, 3D view and wall settings, plot area, legend, visibility, blank cell display, and data label options.
/// </summary>
[OpenXmlType(typeof(DXDC.Chart))]
[DataContract]
[XmlRoot("Chart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Chart : ModelElement<DXDC.Chart>
{
 /// <summary>
 ///   Title data and formatting for the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.Title))]
 public Title? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }
 private Title? _Title;

 /// <summary>
 ///   Indicates if the chart automatic title has been deleted.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.AutoTitleDeleted))]
 public bool? AutoTitleDeleted { get => _AutoTitleDeleted; set => UpdateField(ref _AutoTitleDeleted, value, nameof(AutoTitleDeleted)); }
 private bool? _AutoTitleDeleted;

 /// <summary>
 ///   Pivot chart format persistence data.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.PivotFormats))]
 public PivotFormats? PivotFormats { get => _PivotFormats; set => UpdateField(ref _PivotFormats, value, nameof(PivotFormats)); }
 private PivotFormats? _PivotFormats;

 /// <summary>
 ///   3D view settings for the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.View3D))]
 public View3D? View3D { get => _View3D; set => UpdateField(ref _View3D, value, nameof(View3D)); }
 private View3D? _View3D;

 /// <summary>
 ///   3D floor formatting for the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.Floor))]
 public Floor? Floor { get => _Floor; set => UpdateField(ref _Floor, value, nameof(Floor)); }
 private Floor? _Floor;

 /// <summary>
 ///   3D side wall formatting for the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.SideWall))]
 public SideWall? SideWall { get => _SideWall; set => UpdateField(ref _SideWall, value, nameof(SideWall)); }
 private SideWall? _SideWall;

 /// <summary>
 ///   3D back wall formatting for the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.BackWall))]
 public BackWall? BackWall { get => _BackWall; set => UpdateField(ref _BackWall, value, nameof(BackWall)); }
 private BackWall? _BackWall;

 /// <summary>
 ///   Plot data and formatting for the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.PlotArea))]
 public PlotArea? PlotArea { get => _PlotArea; set => UpdateField(ref _PlotArea, value, nameof(PlotArea)); }
 private PlotArea? _PlotArea;

 /// <summary>
 ///   Legend data and formatting for the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.Legend))]
 public Legend? Legend { get => _Legend; set => UpdateField(ref _Legend, value, nameof(Legend)); }
 private Legend? _Legend;

 /// <summary>
 ///   Indicates if only visible cells are plotted.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.PlotVisibleOnly))]
 public bool? PlotVisibleOnly { get => _PlotVisibleOnly; set => UpdateField(ref _PlotVisibleOnly, value, nameof(PlotVisibleOnly)); }
 private bool? _PlotVisibleOnly;

 /// <summary>
 ///   Specifies how blank cells are plotted on the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.DisplayBlanksAs))]
 public DisplayBlanksAs? DisplayBlanksAs { get => _DisplayBlanksAs; set => UpdateField(ref _DisplayBlanksAs, value, nameof(DisplayBlanksAs)); }
 private DisplayBlanksAs? _DisplayBlanksAs;

 /// <summary>
 ///   Indicates if data labels should be rendered over the maximum scale.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Chart.ShowDataLabelsOverMaximum))]
 public bool? ShowDataLabelsOverMaximum { get => _ShowDataLabelsOverMaximum; set => UpdateField(ref _ShowDataLabelsOverMaximum, value, nameof(ShowDataLabelsOverMaximum)); }
 private bool? _ShowDataLabelsOverMaximum;
}