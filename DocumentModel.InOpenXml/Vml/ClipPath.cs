namespace DocumentModel.Vml;
/// <summary>
///   Shape Clipping Path.
/// </summary>
public partial class ClipPath : ModelElement<DXVO.ClipPath>
{
    /// <summary>
    ///   Path Definition
    /// </summary>
    public string? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

    private string? _Value;
}