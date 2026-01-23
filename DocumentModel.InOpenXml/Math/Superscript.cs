namespace DocumentModel.Math;
/// <summary>
///   Superscript Function.
/// </summary>
public partial class Superscript : ModelElement<DXM.Superscript>, ICommonMathContent
{
    /// <summary>
    ///   Superscript Properties.
    /// </summary>
    public SuperscriptProperties? SuperscriptProperties { get => _SuperscriptProperties; set => UpdateField(ref _SuperscriptProperties, value, nameof(SuperscriptProperties)); }

    private SuperscriptProperties? _SuperscriptProperties;
    /// <summary>
    ///   Superscript base argument
    /// </summary>
    public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

    private Argument? _Argument;
    /// <summary>
    ///   Superscript (Superscript function).
    /// </summary>
    public SuperArgument? SuperArgument { get => _SuperArgument; set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument)); }

    private SuperArgument? _SuperArgument;
}