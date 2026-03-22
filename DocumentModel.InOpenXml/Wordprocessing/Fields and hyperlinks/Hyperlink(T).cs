using DocumentModel.Math;
namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the presence of a hyperlink at the current location in a WordprocessingML document.
/// This class extends <see cref = "IParagraphContent"/>, <see cref = "ISdtRunContent"/>, <see cref = "IBidirectionalContent"/>, and <see cref = "IMathArgumentContent"/>, enabling advanced linking, navigation, and integration of hyperlinks within paragraphs, structured document tags, bidirectional content, and mathematical arguments.
/// </summary>
public abstract partial class Hyperlink<T> : ModelElement<T>, IParagraphContent, ISdtRunContent, IBidirectionalContent, DMM.IMathArgumentContent where T : DX.OpenXmlElement
{
    /// <summary>
    /// Target frame for the hyperlink, specifying where the linked content should open.
    /// </summary>
    public string? TargetFrame { get => _TargetFrame; set => UpdateField(ref _TargetFrame, value, nameof(TargetFrame)); }
    private string? _TargetFrame;
    /// <summary>
    /// Tooltip text associated with the hyperlink, providing additional information to users.
    /// </summary>
    public string? Tooltip { get => _Tooltip; set => UpdateField(ref _Tooltip, value, nameof(Tooltip)); }
    private string? _Tooltip;
    /// <summary>
    /// Location in the target document to which the hyperlink points.
    /// </summary>
    public string? DocLocation { get => _DocLocation; set => UpdateField(ref _DocLocation, value, nameof(DocLocation)); }
    private string? _DocLocation;
    /// <summary>
    /// Indicates whether the hyperlink should be added to the list of viewed hyperlinks (history).
    /// </summary>
    public bool? History { get => _History; set => UpdateField(ref _History, value, nameof(History)); }
    private bool? _History;
    /// <summary>
    /// Anchor within the target document for the hyperlink.
    /// </summary>
    public string? Anchor { get => _Anchor; set => UpdateField(ref _Anchor, value, nameof(Anchor)); }
    private string? _Anchor;
    /// <summary>
    /// Target identifier for the hyperlink, referencing the external or internal resource.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
    private string? _Id;
}