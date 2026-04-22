namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the NonVisualDrawingProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO10DCD.NonVisualDrawingProperties))]
[XmlRoot("NonVisualDrawingProperties", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class NonVisualDrawingProperties : ModelElement<DXO10DCD.NonVisualDrawingProperties>
{
 /// <summary>
 /// Specifies the unique identifier of the element.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualDrawingProperties.Id))]
 public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private UInt32? _Id;

 /// <summary>
 /// Specifies the name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualDrawingProperties.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;

 /// <summary>
 /// Specifies descriptive text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualDrawingProperties.Description))]
 public string? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }
 private string? _Description;

 /// <summary>
 /// Specifies the hidden.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualDrawingProperties.Hidden))]
 public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }
 private bool? _Hidden;

 /// <summary>
 /// Specifies the title.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualDrawingProperties.Title))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }
 private string? _Title;

 /// <summary>
 /// Specifies the hyperlink on click.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualDrawingProperties.HyperlinkOnClick))]
 public HyperlinkOnClick? HyperlinkOnClick { get => _HyperlinkOnClick; set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick)); }
 private HyperlinkOnClick? _HyperlinkOnClick;

 /// <summary>
 /// Specifies the hyperlink on hover.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualDrawingProperties.HyperlinkOnHover))]
 public HyperlinkOnHover? HyperlinkOnHover { get => _HyperlinkOnHover; set => UpdateField(ref _HyperlinkOnHover, value, nameof(HyperlinkOnHover)); }
 private HyperlinkOnHover? _HyperlinkOnHover;

 /// <summary>
 /// Specifies the non visual drawing properties extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualDrawingProperties.NonVisualDrawingPropertiesExtensionList))]
 public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get => _NonVisualDrawingPropertiesExtensionList; set => UpdateField(ref _NonVisualDrawingPropertiesExtensionList, value, nameof(NonVisualDrawingPropertiesExtensionList)); }
 private NonVisualDrawingPropertiesExtensionList? _NonVisualDrawingPropertiesExtensionList;
}