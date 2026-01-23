namespace DocumentModel.Vml;
/// <summary>
///   Skew Transform.
/// </summary>
public partial class Skew : ModelElement<DXVO.Skew>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Skew ID
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Skew Toggle
    /// </summary>
    public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

    private bool? _On;
    /// <summary>
    ///   Skew Offset
    /// </summary>
    public string? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

    private string? _Offset;
    /// <summary>
    ///   Skew Origin
    /// </summary>
    public string? Origin { get => _Origin; set => UpdateField(ref _Origin, value, nameof(Origin)); }

    private string? _Origin;
    /// <summary>
    ///   Skew Perspective Matrix
    /// </summary>
    public string? Matrix { get => _Matrix; set => UpdateField(ref _Matrix, value, nameof(Matrix)); }

    private string? _Matrix;
}