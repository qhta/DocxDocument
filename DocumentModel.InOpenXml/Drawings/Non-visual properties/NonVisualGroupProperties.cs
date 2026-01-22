namespace DocumentModel.Drawings;
/// <summary>
///   Defines the NonVisualGroupProperties interface.
/// </summary>
public partial class NonVisualGroupProperties : ModelElement<DXO13D.NonVisualGroupProperties>
{
    /// <summary>
    ///   isLegacyGroup
    /// </summary>
    public bool? IsLegacyGroup { get => _IsLegacyGroup; set => UpdateField(ref _IsLegacyGroup, value, nameof(IsLegacyGroup)); }

    private bool? _IsLegacyGroup;
}