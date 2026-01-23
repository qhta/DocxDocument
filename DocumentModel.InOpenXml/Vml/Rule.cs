namespace DocumentModel.Vml;
/// <summary>
/// Represents a VML rule, including rule type, alignment, shape reference, and proxies.
/// </summary>
public partial class Rule : ModelElement<DXVO.Rule>
{
    /// <summary>
    /// Rule identifier string.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    /// Specifies the rule type.
    /// </summary>
    public RuleKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private RuleKind? _Type;
    /// <summary>
    /// Specifies the alignment rule type.
    /// </summary>
    public AlignmentKind? How { get => _How; set => UpdateField(ref _How, value, nameof(How)); }

    private AlignmentKind? _How;
    /// <summary>
    /// Reference to the shape associated with this rule.
    /// </summary>
    public string? ShapeReference { get => _ShapeReference; set => UpdateField(ref _ShapeReference, value, nameof(ShapeReference)); }

    private string? _ShapeReference;
    /// <summary>
    /// Proxies collection associated with this rule.
    /// </summary>
    public Proxies? Proxies { get => _Proxies; set => UpdateField(ref _Proxies, value, nameof(Proxies)); }

    private Proxies? _Proxies;
}