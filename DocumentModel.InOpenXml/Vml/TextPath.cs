namespace DocumentModel.Vml;
/// <summary>
///   Defines the TextPath Class.
/// </summary>
public partial class TextPath : ModelElement<DXV.TextPath>
{
    /// <summary>
    ///   Unique Identifier
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Shape Styling Properties
    /// </summary>
    public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

    private string? _Style;
    /// <summary>
    ///   Text Path Toggle
    /// </summary>
    public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

    private bool? _On;
    /// <summary>
    ///   Shape Fit Toggle
    /// </summary>
    public bool? FitShape { get => _FitShape; set => UpdateField(ref _FitShape, value, nameof(FitShape)); }

    private bool? _FitShape;
    /// <summary>
    ///   Path Fit Toggle
    /// </summary>
    public bool? FitPath { get => _FitPath; set => UpdateField(ref _FitPath, value, nameof(FitPath)); }

    private bool? _FitPath;
    /// <summary>
    ///   Text Path Trim Toggle
    /// </summary>
    public bool? Trim { get => _Trim; set => UpdateField(ref _Trim, value, nameof(Trim)); }

    private bool? _Trim;
    /// <summary>
    ///   Text X-Scaling
    /// </summary>
    public bool? XScale { get => _XScale; set => UpdateField(ref _XScale, value, nameof(XScale)); }

    private bool? _XScale;
    /// <summary>
    ///   Text Path Text
    /// </summary>
    public string? String { get => _String; set => UpdateField(ref _String, value, nameof(String)); }

    private string? _String;
}