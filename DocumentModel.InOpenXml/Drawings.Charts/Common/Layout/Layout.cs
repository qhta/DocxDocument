using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Layout.
/// </summary>
[OpenXmlType(typeof(DXDC.Layout))]
public class Layout : ModelElement<DXDC.Layout>
{
 /// <summary>
 ///   Manual Layout.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Layout.ManualLayout))]
 public ManualLayout? ManualLayout { get; set; }

 /// <summary>
 ///   Chart Extensibility.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Layout.ExtensionList))]
 public ExtensionList? ExtensionList { get; set; }
}