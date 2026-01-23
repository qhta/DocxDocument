namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Non-Visual Drawing Properties.
/// </summary>
public partial class NonVisualDrawingProperties : ModelElement<DXDP.NonVisualDrawingProperties>
{
    /// <summary>
    ///   Application defined unique identifier.
    /// </summary>
    [OpenXmlProperty(nameof(DXDP.NonVisualDrawingProperties.Id))]
    /// <summary>
    ///   Application defined unique identifier.
    /// </summary>
    [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
    public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private UInt32? _Id;
    /// <summary>
    ///   Name compatible with Object Model (non-unique).
    /// </summary>
    [OpenXmlProperty(nameof(DXDP.NonVisualDrawingProperties.Name))]
    /// <summary>
    ///   Name compatible with Object Model (non-unique).
    /// </summary>
    [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    ///   Description of the drawing element.
    /// </summary>
    [OpenXmlProperty(nameof(DXDP.NonVisualDrawingProperties.Description))]
    /// <summary>
    ///   Description of the drawing element.
    /// </summary>
    [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
    public string? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }

    private string? _Description;
    /// <summary>
    ///   Flag determining to show or hide this element.
    /// </summary>
    [OpenXmlProperty(nameof(DXDP.NonVisualDrawingProperties.Hidden))]
    /// <summary>
    ///   Flag determining to show or hide this element.
    /// </summary>
    [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
    public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }

    private bool? _Hidden;
    /// <summary>
    ///   Title
    /// </summary>
    [OpenXmlProperty(nameof(DXDP.NonVisualDrawingProperties.Title))]
    /// <summary>
    ///   Title
    /// </summary>
    [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
    public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

    private string? _Title;
    /// <summary>
    ///   IHyperlink associated with clicking or selecting the element..
    /// </summary>
    [OpenXmlProperty(nameof(DXDP.NonVisualDrawingProperties.HyperlinkOnClick))]
    /// <summary>
    ///   IHyperlink associated with clicking or selecting the element..
    /// </summary>
    [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
    public HyperlinkOnClick? HyperlinkOnClick { get => _HyperlinkOnClick; set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick)); }

    private HyperlinkOnClick? _HyperlinkOnClick;
    /// <summary>
    ///   IHyperlink associated with hovering over the element..
    /// </summary>
    [OpenXmlProperty(nameof(DXDP.NonVisualDrawingProperties.HyperlinkOnHover))]
    /// <summary>
    ///   IHyperlink associated with hovering over the element..
    /// </summary>
    [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
    public HyperlinkOnHover? HyperlinkOnHover { get => _HyperlinkOnHover; set => UpdateField(ref _HyperlinkOnHover, value, nameof(HyperlinkOnHover)); }

    private HyperlinkOnHover? _HyperlinkOnHover;
    /// <summary>
    ///   Future extension.
    /// </summary>
    [OpenXmlProperty(nameof(DXDP.NonVisualDrawingProperties.NonVisualDrawingPropertiesExtensionList))]
    /// <summary>
    ///   Future extension.
    /// </summary>
    [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
    public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get => _NonVisualDrawingPropertiesExtensionList; set => UpdateField(ref _NonVisualDrawingPropertiesExtensionList, value, nameof(NonVisualDrawingPropertiesExtensionList)); }

    private NonVisualDrawingPropertiesExtensionList? _NonVisualDrawingPropertiesExtensionList;
}