namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the NonVisualDrawingProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.NonVisualDrawingProperties))]
public partial class NonVisualDrawingProperties : ModelElement<DXOD.NonVisualDrawingProperties>
{
 /// <summary>
 ///   Application defined unique identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualDrawingProperties.Id))]
 /// <summary>
 ///   Application defined unique identifier.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualDrawingProperties))]
 public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private UInt32? _Id;
 /// <summary>
 ///   FontName compatible with Object Model (non-unique).
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualDrawingProperties.Name))]
 /// <summary>
 ///   FontName compatible with Object Model (non-unique).
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualDrawingProperties))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 ///   Description of the drawing element.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualDrawingProperties.Description))]
 /// <summary>
 ///   Description of the drawing element.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualDrawingProperties))]
 public string? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }

 private string? _Description;
 /// <summary>
 ///   Flag determining to show or hide this element.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualDrawingProperties.Hidden))]
 /// <summary>
 ///   Flag determining to show or hide this element.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualDrawingProperties))]
 public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }

 private bool? _Hidden;
 /// <summary>
 ///   Title
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualDrawingProperties.Title))]
 /// <summary>
 ///   Title
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualDrawingProperties))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

 private string? _Title;
 /// <summary>
 ///   IHyperlink associated with clicking or selecting the element..
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualDrawingProperties.HyperlinkOnClick))]
 /// <summary>
 ///   IHyperlink associated with clicking or selecting the element..
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualDrawingProperties))]
 public HyperlinkOnClick? HyperlinkOnClick { get => _HyperlinkOnClick; set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick)); }

 private HyperlinkOnClick? _HyperlinkOnClick;
 /// <summary>
 ///   IHyperlink associated with hovering over the element..
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualDrawingProperties.HyperlinkOnHover))]
 /// <summary>
 ///   IHyperlink associated with hovering over the element..
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualDrawingProperties))]
 public HyperlinkOnHover? HyperlinkOnHover { get => _HyperlinkOnHover; set => UpdateField(ref _HyperlinkOnHover, value, nameof(HyperlinkOnHover)); }

 private HyperlinkOnHover? _HyperlinkOnHover;
 /// <summary>
 ///   Future extension.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.NonVisualDrawingProperties.NonVisualDrawingPropertiesExtensionList))]
 /// <summary>
 ///   Future extension.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.NonVisualDrawingProperties))]
 public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get => _NonVisualDrawingPropertiesExtensionList; set => UpdateField(ref _NonVisualDrawingPropertiesExtensionList, value, nameof(NonVisualDrawingPropertiesExtensionList)); }

 private NonVisualDrawingPropertiesExtensionList? _NonVisualDrawingPropertiesExtensionList;
}