namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for a drawing element in chart drawings, including identifiers, names, descriptions, visibility, hyperlinks, and extension data.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualDrawingProperties))]
public class NonVisualDrawingProperties: ModelElement<DXDCD.NonVisualDrawingProperties>
{
  /// <summary>
  /// Unique identifier assigned by the application to the drawing element.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualDrawingProperties.Id))]
  public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private UInt32? _Id;
  /// <summary>
  /// Name of the drawing element, compatible with the Office object model.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualDrawingProperties.Name))]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
  private string? _Name;
  /// <summary>
  /// Textual description of the drawing element for accessibility or documentation.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualDrawingProperties.Description))]
  public string? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }
  private string? _Description;
  /// <summary>
  /// Indicates whether the drawing element is hidden from view.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualDrawingProperties.Hidden))]
  public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }
  private bool? _Hidden;
  /// <summary>
  /// Title of the drawing element, used for display or accessibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualDrawingProperties.Title))]
  public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }
  private string? _Title;
  /// <summary>
  /// Hyperlink information for click or selection actions on the drawing element.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualDrawingProperties.HyperlinkOnClick))]
  public HyperlinkOnClick? HyperlinkOnClick
  {
    get => _HyperlinkOnClick;
    set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick));
  }
  private HyperlinkOnClick? _HyperlinkOnClick;
  /// <summary>
  /// Hyperlink information for mouse hover actions on the drawing element.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualDrawingProperties.HyperlinkOnHover))]
  public HyperlinkOnHover? HyperlinkOnHover
  {
    get => _HyperlinkOnHover;
    set => UpdateField(ref _HyperlinkOnHover, value, nameof(HyperlinkOnHover));
  }
  private HyperlinkOnHover? _HyperlinkOnHover;
  /// <summary>
  /// Extension list for future or custom non-visual drawing properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualDrawingProperties.NonVisualDrawingPropertiesExtensionList))]
  public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get => _NonVisualDrawingPropertiesExtensionList;
    set => UpdateField(ref _NonVisualDrawingPropertiesExtensionList, value,
      nameof(NonVisualDrawingPropertiesExtensionList));
  }
  private NonVisualDrawingPropertiesExtensionList? _NonVisualDrawingPropertiesExtensionList;
}