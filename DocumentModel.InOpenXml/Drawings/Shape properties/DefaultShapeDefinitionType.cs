namespace DocumentModel.Drawings;
/// <summary>
///   Represents the default shape definition, including visual properties, body properties, list style, and shape style.
/// </summary>
[OpenXmlType(typeof(DXD.DefaultShapeDefinitionType))]
public partial class DefaultShapeDefinitionType : ModelElement<DXD.DefaultShapeDefinitionType>, IExtendableElement
{
 /// <summary>
 ///   Visual properties for the default shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.DefaultShapeDefinitionType.ShapeProperties))]
 /// <summary>
 ///   Visual properties for the default shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.DefaultShapeDefinitionType))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

 private ShapeProperties? _ShapeProperties;
 /// <summary>
 ///   Body properties for the default shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.DefaultShapeDefinitionType.BodyProperties))]
 /// <summary>
 ///   Body properties for the default shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.DefaultShapeDefinitionType))]
 public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }

 private BodyProperties? _BodyProperties;
 /// <summary>
 ///   List style for the default shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.DefaultShapeDefinitionType.ListStyle))]
 /// <summary>
 ///   List style for the default shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.DefaultShapeDefinitionType))]
 public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }

 private ListStyle? _ListStyle;
 /// <summary>
 ///   Shape style for the default shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.DefaultShapeDefinitionType.ShapeStyle))]
 /// <summary>
 ///   Shape style for the default shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.DefaultShapeDefinitionType))]
 public ShapeStyle? ShapeStyle { get => _ShapeStyle; set => UpdateField(ref _ShapeStyle, value, nameof(ShapeStyle)); }

 private ShapeStyle? _ShapeStyle;
 /// <summary>
 /// List of extension elements.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.DefaultShapeDefinitionType.ExtensionList))]
 /// <summary>
 /// List of extension elements.
 /// </summary>
 [OpenXmlElement(typeof(DXD.DefaultShapeDefinitionType))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}