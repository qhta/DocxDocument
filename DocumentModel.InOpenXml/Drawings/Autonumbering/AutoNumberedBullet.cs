namespace DocumentModel.Drawings;
/// <summary>
/// Represents an auto-numbered bullet, specifying the numbering scheme and starting value for bullet lists.
/// </summary>
public partial class AutoNumberedBullet : ModelElement<DXD.AutoNumberedBullet>
{
    /// <summary>
    /// Bullet autonumbering type.
    /// </summary>
    public TextAutoNumberSchemeKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private TextAutoNumberSchemeKind? _Type;
    /// <summary>
    /// Starting value for numbering.
    /// </summary>
    public Int32? StartAt { get; set; }
}