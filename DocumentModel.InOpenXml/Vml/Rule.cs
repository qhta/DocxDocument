namespace DocumentModel.Vml;
/// <summary>
/// Represents a VML rule, including rule type, alignment, shape reference, and proxies.
/// </summary>
public partial class Rule : ModelElement<DXVO.Rule>
{
    /// <summary>
    /// Rule identifier string.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Rule.Id))]
    /// <summary>
    /// Rule identifier string.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Rule))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    /// Specifies the rule type.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Rule.Type))]
    /// <summary>
    /// Specifies the rule type.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Rule))]
    public RuleKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private RuleKind? _Type;
    /// <summary>
    /// Specifies the alignment rule type.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Rule.How))]
    /// <summary>
    /// Specifies the alignment rule type.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Rule))]
    public AlignmentKind? How { get => _How; set => UpdateField(ref _How, value, nameof(How)); }

    private AlignmentKind? _How;
    /// <summary>
    /// Reference to the shape associated with this rule.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Rule.ShapeReference))]
    /// <summary>
    /// Reference to the shape associated with this rule.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Rule))]
    public string? ShapeReference { get => _ShapeReference; set => UpdateField(ref _ShapeReference, value, nameof(ShapeReference)); }

    private string? _ShapeReference;
    /// <summary>
    /// Proxies collection associated with this rule.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Rule))]
    public Proxies? Proxies { get => _Proxies; set => UpdateField(ref _Proxies, value, nameof(Proxies)); }

    private Proxies? _Proxies;
}