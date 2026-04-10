namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MinorGridlinesGridlines Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.MinorGridlinesGridlines))]
[XmlRoot("MinorGridlinesGridlines", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class MinorGridlinesGridlines : ModelElement<DXO16DCD.MinorGridlinesGridlines>
{
 /// <summary>
 /// Specifies the shape properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.MinorGridlinesGridlines.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

 private ShapeProperties? _ShapeProperties;
 /// <summary>
 /// Specifies the extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.MinorGridlinesGridlines.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}