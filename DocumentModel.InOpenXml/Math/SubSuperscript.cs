namespace DocumentModel.Math;
/// <summary>
///   Sub-Superscript Function.
/// </summary>
public partial class SubSuperscript : ModelElement<DXM.SubSuperscript>, ICommonMathContent
{
    /// <summary>
    ///   Sub-Superscript Properties.
    /// </summary>
    public SubSuperscriptProperties? SubSuperscriptProperties { get => _SubSuperscriptProperties; set => UpdateField(ref _SubSuperscriptProperties, value, nameof(SubSuperscriptProperties)); }

    private SubSuperscriptProperties? _SubSuperscriptProperties;
    /// <summary>
    ///   Base argument.
    /// </summary>
    public Argument? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }

    private Argument? _Base;
    /// <summary>
    ///   Subscript (Sub-Superscript).
    /// </summary>
    public SubArgument? SubArgument { get => _SubArgument; set => UpdateField(ref _SubArgument, value, nameof(SubArgument)); }

    private SubArgument? _SubArgument;
    /// <summary>
    ///   Superscript (Sub-Superscript function).
    /// </summary>
    public SuperArgument? SuperArgument { get => _SuperArgument; set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument)); }

    private SuperArgument? _SuperArgument;
}