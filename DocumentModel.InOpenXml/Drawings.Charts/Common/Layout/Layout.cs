using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Layout.
/// </summary>
[OpenXmlType(typeof(DXDC.Layout))]
[XmlRoot("Layout", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Layout : ModelElement<DXDC.Layout>
{
 /// <summary>
 ///   Manual Layout.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Layout.ManualLayout))]
 public ManualLayout? ManualLayout { get => _ManualLayout; set => UpdateField(ref _ManualLayout, value, nameof(ManualLayout)); }
 private ManualLayout? _ManualLayout;

 /// <summary>
 ///   Chart Extensibility.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Layout.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}