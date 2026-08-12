namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
[OpenXmlType(typeof(DXDC.UpDownBars))]
[DataContract]
[XmlRoot("UpDownBars", Namespace = "DocumentModel.Drawings.Charts")]
public partial class UpDownBars : ModelElement<DXDC.UpDownBars>
{
 /// <summary>
 ///   Gap Width.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.UpDownBars.GapWidth))]
 public UInt16? GapWidth { get => _GapWidth; set => UpdateField(ref _GapWidth, value, nameof(GapWidth)); }
 private UInt16? _GapWidth;

 /// <summary>
 ///   Up Bars.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.UpDownBars.UpBars))]
 public UpBars? UpBars { get => _UpBars; set => UpdateField(ref _UpBars, value, nameof(UpBars)); }
 private UpBars? _UpBars;

 /// <summary>
 ///   Down Bars.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.UpDownBars.DownBars))]
 public DownBars? DownBars { get => _DownBars; set => UpdateField(ref _DownBars, value, nameof(DownBars)); }
 private DownBars? _DownBars;

 /// <summary>
 ///   Chart Extensibility.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.UpDownBars.ExtensionList))]
 public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private IExtensionList? _ExtensionList;
}