namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualDrawingProperties Class.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualDrawingProperties))]
public partial class NonVisualDrawingProperties<T>: ModelElement<T> where T: DX.OpenXmlElement
{
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.NonVisualDrawingProperties.Id))]
  [OpenXmlElement(typeof(DXD.NonVisualDrawingProperties))]
  public UInt32? Id
  {
    get => _Id;
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private UInt32? _Id;

  /// <summary>
  ///   FontName compatible with Object Model (non-unique).
  /// </summary>
  [OpenXmlProperty(nameof(DXD.NonVisualDrawingProperties.Name))]
  [OpenXmlElement(typeof(DXD.NonVisualDrawingProperties))]
  public string? Name
  {
    get => _Name;
    set => UpdateField(ref _Name, value, nameof(Name));
  }

  private string? _Name;

  /// <summary>
  ///   Description of the drawing element.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.NonVisualDrawingProperties.Description))]
  [OpenXmlElement(typeof(DXD.NonVisualDrawingProperties))]
  public string? Description
  {
    get => _Description;
    set => UpdateField(ref _Description, value, nameof(Description));
  }

  private string? _Description;

  /// <summary>
  ///   Flag determining to show or hide this element.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.NonVisualDrawingProperties.Hidden))]
  [OpenXmlElement(typeof(DXD.NonVisualDrawingProperties))]
  public bool? Hidden
  {
    get => _Hidden;
    set => UpdateField(ref _Hidden, value, nameof(Hidden));
  }

  private bool? _Hidden;

  /// <summary>
  ///   Title
  /// </summary>
  [OpenXmlProperty(nameof(DXD.NonVisualDrawingProperties.Title))]
  [OpenXmlElement(typeof(DXD.NonVisualDrawingProperties))]
  public string? Title
  {
    get => _Title;
    set => UpdateField(ref _Title, value, nameof(Title));
  }

  private string? _Title;

  /// <summary>
  ///   IHyperlink associated with clicking or selecting the element..
  /// </summary>
  [OpenXmlProperty(nameof(DXD.NonVisualDrawingProperties.HyperlinkOnClick))]
  [OpenXmlElement(typeof(DXD.NonVisualDrawingProperties))]
  public HyperlinkOnClick? HyperlinkOnClick
  {
    get => _HyperlinkOnClick;
    set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick));
  }

  private HyperlinkOnClick? _HyperlinkOnClick;

  /// <summary>
  ///   IHyperlink associated with hovering over the element..
  /// </summary>
  [OpenXmlProperty(nameof(DXD.NonVisualDrawingProperties.HyperlinkOnHover))]
  [OpenXmlElement(typeof(DXD.NonVisualDrawingProperties))]
  public HyperlinkOnHover? HyperlinkOnHover
  {
    get => _HyperlinkOnHover;
    set => UpdateField(ref _HyperlinkOnHover, value, nameof(HyperlinkOnHover));
  }

  private HyperlinkOnHover? _HyperlinkOnHover;

  /// <summary>
  ///   Future extension.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.NonVisualDrawingProperties.NonVisualDrawingPropertiesExtensionList))]
  [OpenXmlElement(typeof(DXD.NonVisualDrawingProperties))]
  public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get => _NonVisualDrawingPropertiesExtensionList;
    set => UpdateField(ref _NonVisualDrawingPropertiesExtensionList, value,
      nameof(NonVisualDrawingPropertiesExtensionList));
  }

  private NonVisualDrawingPropertiesExtensionList? _NonVisualDrawingPropertiesExtensionList;
}

/// <summary>
/// Specific DXD.NonVisualDrawingProperties mapping type
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualDrawingProperties))]
public class NonVisualDrawingProperties: NonVisualDrawingProperties<DXD.NonVisualDrawingProperties>
{

}