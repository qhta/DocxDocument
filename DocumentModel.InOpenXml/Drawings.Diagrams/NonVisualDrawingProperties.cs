namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines the NonVisualDrawingProperties Class.
/// </summary>
[OpenXmlType(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties))]
[DataContract]
[XmlRoot("NonVisualDrawingProperties", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class NonVisualDrawingProperties : ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties>
{
 /// <summary>
 ///   Application defined unique identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties.Id))]
 public UInt32? Id { get => _Id ??= GetProperty<UInt32?>(GetUpdatableElement()?.Id); set => UpdateField(ref _Id, value, nameof(Id)); }
 private UInt32? _Id;

 /// <summary>
 ///   Name compatible with Object Model (non-unique).
 /// </summary>
 [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties.Name))]
 public string? Name { get => _Name ??= GetProperty<string?>(GetUpdatableElement()?.Name); set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;

 /// <summary>
 ///   Description of the drawing element.
 /// </summary>
 [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties.Description))]
 public string? Description { get => _Description ??= GetProperty<string?>(GetUpdatableElement()?.Description); set => UpdateField(ref _Description, value, nameof(Description)); }
 private string? _Description;

 /// <summary>
 ///   Flag determining to show or hide this element.
 /// </summary>
 [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties.Hidden))]
 public bool? Hidden { get => _Hidden ??= GetProperty<bool?>(GetUpdatableElement()?.Hidden); set => UpdateField(ref _Hidden, value, nameof(Hidden)); }
 private bool? _Hidden;

 /// <summary>
 ///   Title
 /// </summary>
 [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties.Title))]
 public string? Title { get => _Title ??= GetProperty<string?>(GetUpdatableElement()?.Title); set => UpdateField(ref _Title, value, nameof(Title)); }
 private string? _Title;

 /// <summary>
 ///   IHyperlink associated with clicking or selecting the element..
 /// </summary>
 [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties.HyperlinkOnClick))]
 public HyperlinkOnClick? HyperlinkOnClick { get => _HyperlinkOnClick ??= GetProperty<HyperlinkOnClick?>(GetUpdatableElement()?.HyperlinkOnClick); set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick)); }
 private HyperlinkOnClick? _HyperlinkOnClick;

 /// <summary>
 ///   IHyperlink associated with hovering over the element..
 /// </summary>
 [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties.HyperlinkOnHover))]
 public HyperlinkOnHover? HyperlinkOnHover { get => _HyperlinkOnHover ??= GetProperty<HyperlinkOnHover?>(GetUpdatableElement()?.HyperlinkOnHover); set => UpdateField(ref _HyperlinkOnHover, value, nameof(HyperlinkOnHover)); }
 private HyperlinkOnHover? _HyperlinkOnHover;

 /// <summary>
 ///   Future extension.
 /// </summary>
 [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties.NonVisualDrawingPropertiesExtensionList))]
 public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get => _NonVisualDrawingPropertiesExtensionList ??= GetProperty<NonVisualDrawingPropertiesExtensionList?>(GetUpdatableElement()?.NonVisualDrawingPropertiesExtensionList); set => UpdateField(ref _NonVisualDrawingPropertiesExtensionList, value, nameof(NonVisualDrawingPropertiesExtensionList)); }
 private NonVisualDrawingPropertiesExtensionList? _NonVisualDrawingPropertiesExtensionList;
}