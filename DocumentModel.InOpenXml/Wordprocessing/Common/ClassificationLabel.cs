namespace DocumentModel;
/// <summary>
///   Defines the ClassificationLabel Class.
/// </summary>
public partial class ClassificationLabel : ModelElement<DXO21MLMD.ClassificationLabel>
{
    /// <summary>
    ///   id
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Id))]
    /// <summary>
    ///   id
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   enabled
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Enabled))]
    /// <summary>
    ///   enabled
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public bool? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

    private bool? _Enabled;
    /// <summary>
    ///   setDate
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.SetDate))]
    /// <summary>
    ///   setDate
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public string? SetDate { get => _SetDate; set => UpdateField(ref _SetDate, value, nameof(SetDate)); }

    private string? _SetDate;
    /// <summary>
    ///   method
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Method))]
    /// <summary>
    ///   method
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public string? Method { get => _Method; set => UpdateField(ref _Method, value, nameof(Method)); }

    private string? _Method;
    /// <summary>
    ///   name
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Name))]
    /// <summary>
    ///   name
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    ///   siteId
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.SiteId))]
    /// <summary>
    ///   siteId
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public string? SiteId { get => _SiteId; set => UpdateField(ref _SiteId, value, nameof(SiteId)); }

    private string? _SiteId;
    /// <summary>
    ///   actionId
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.ActionId))]
    /// <summary>
    ///   actionId
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public string? ActionId { get => _ActionId; set => UpdateField(ref _ActionId, value, nameof(ActionId)); }

    private string? _ActionId;
    /// <summary>
    ///   contentBits
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.ContentBits))]
    /// <summary>
    ///   contentBits
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public UInt32? ContentBits { get => _ContentBits; set => UpdateField(ref _ContentBits, value, nameof(ContentBits)); }

    private UInt32? _ContentBits;
    /// <summary>
    ///   removed
    /// </summary>
    [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Removed))]
    /// <summary>
    ///   removed
    /// </summary>
    [OpenXmlElement(typeof(DXO21MLMD.ClassificationLabel))]
    public bool? Removed { get => _Removed; set => UpdateField(ref _Removed, value, nameof(Removed)); }

    private bool? _Removed;
}