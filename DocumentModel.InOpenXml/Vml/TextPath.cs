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
    public string? Style { get; set; }
    /// <summary>
    ///   Text Path Toggle
    /// </summary>
    public bool? On { get; set; }
    /// <summary>
    ///   Shape Fit Toggle
    /// </summary>
    public bool? FitShape { get; set; }
    /// <summary>
    ///   Path Fit Toggle
    /// </summary>
    public bool? FitPath { get; set; }
    /// <summary>
    ///   Text Path Trim Toggle
    /// </summary>
    public bool? Trim { get; set; }
    /// <summary>
    ///   Text X-Scaling
    /// </summary>
    public bool? XScale { get; set; }
    /// <summary>
    ///   Text Path Text
    /// </summary>
    public string? String { get; set; }
}