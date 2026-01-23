namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the Pre-Sub-Superscript objects Pre. 
/// </summary>
public partial class PreSubSuper : ModelElement<DXM.PreSubSuper>, ICommonMathContent
{
    /// <summary>
    ///   Pre-Sub-Superscript Properties.
    /// </summary>
    public PreSubSuperProperties? PreSubSuperProperties { get => _PreSubSuperProperties; set => UpdateField(ref _PreSubSuperProperties, value, nameof(PreSubSuperProperties)); }

    private PreSubSuperProperties? _PreSubSuperProperties;
    /// <summary>
    ///   Subscript (Pre-Sub-Superscript).
    /// </summary>
    public SubArgument? SubArgument { get => _SubArgument; set => UpdateField(ref _SubArgument, value, nameof(SubArgument)); }

    private SubArgument? _SubArgument;
    /// <summary>
    ///   Superscript(Pre-Sub-Superscript function).
    /// </summary>
    public SuperArgument? SuperArgument { get => _SuperArgument; set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument)); }

    private SuperArgument? _SuperArgument;
    /// <summary>
    ///   Base argument.
    /// </summary>
    public Argument? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }

    private Argument? _Base;
}