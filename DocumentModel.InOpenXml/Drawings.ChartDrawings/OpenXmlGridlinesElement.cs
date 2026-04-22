namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the OpenXmlGridlinesElement Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.OpenXmlGridlinesElement))]
[XmlRoot("OpenXmlGridlinesElement", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class OpenXmlGridlinesElement : ModelElement<DXO16DCD.OpenXmlGridlinesElement>
{
 /// <summary>
 /// Specifies the shape properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.OpenXmlGridlinesElement.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }
 private ShapeProperties? _ShapeProperties;

 /// <summary>
 /// Specifies the extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.OpenXmlGridlinesElement.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}