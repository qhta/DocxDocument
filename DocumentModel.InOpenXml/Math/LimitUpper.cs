namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Upper-Limit object, consisting of text on the baseline and reduced-size text immediately above it.
/// </summary>
public partial class LimitUpper : ModelElement<DXM.LimitUpper>, ICommonMathContent
{
    /// <summary>
    ///   Upper Limit Properties.
    /// </summary>
    public LimitUpperProperties? LimitUpperProperties { get => _LimitUpperProperties; set => UpdateField(ref _LimitUpperProperties, value, nameof(LimitUpperProperties)); }

    private LimitUpperProperties? _LimitUpperProperties;
    /// <summary>
    ///   Argument.
    /// </summary>
    public Argument? Argument { get; set; }
    /// <summary>
    ///   Limit (Upper).
    /// </summary>
    public Limit? Limit { get; set; }
}