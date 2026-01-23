namespace DocumentModel.Math;
/// <summary>
///   This element specifies an n-ary object, consisting of an n-ary object, a base (or operand) and optional upper and lower limits.
///   Examples of n-ary objects are: integral, sum, product.
/// </summary>
public partial class Nary : ModelElement<DXM.Nary>, ICommonMathContent
{
    /// <summary>
    ///   n-ary Properties.
    /// </summary>
    public NaryProperties? NaryProperties { get => _NaryProperties; set => UpdateField(ref _NaryProperties, value, nameof(NaryProperties)); }

    private NaryProperties? _NaryProperties;
    /// <summary>
    ///   Lower limit (n-ary) .
    /// </summary>
    public SubArgument? SubArgument { get => _SubArgument; set => UpdateField(ref _SubArgument, value, nameof(SubArgument)); }

    private SubArgument? _SubArgument;
    /// <summary>
    ///   Upper limit (n-ary).
    /// </summary>
    public SuperArgument? SuperArgument { get => _SuperArgument; set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument)); }

    private SuperArgument? _SuperArgument;
    /// <summary>
    ///   Base argument.
    /// </summary>
    public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

    private Argument? _Argument;
}