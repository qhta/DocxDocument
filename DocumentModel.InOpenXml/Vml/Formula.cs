namespace DocumentModel.Vml;
/// <summary>
///   Single Formula.
/// </summary>
public partial class Formula : ModelElement<DXV.Formula>
{
    /// <summary>
    ///   Equation
    /// </summary>
    public string? Equation { get => _Equation; set => UpdateField(ref _Equation, value, nameof(Equation)); }

    private string? _Equation;
}