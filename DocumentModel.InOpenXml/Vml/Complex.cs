namespace DocumentModel.Vml;
/// <summary>
///   Complex.
/// </summary>
public partial class Complex : ModelElement<DXVO.Complex>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
}