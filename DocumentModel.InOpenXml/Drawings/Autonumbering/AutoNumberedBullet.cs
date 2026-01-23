namespace DocumentModel.Drawings;
/// <summary>
/// Represents an auto-numbered bullet, specifying the numbering scheme and starting value for bullet lists.
/// </summary>
public partial class AutoNumberedBullet : ModelElement<DXD.AutoNumberedBullet>
{
    /// <summary>
    /// Bullet autonumbering type.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AutoNumberedBullet.Type))]
    /// <summary>
    /// Bullet autonumbering type.
    /// </summary>
    [OpenXmlElement(typeof(DXD.AutoNumberedBullet))]
    public TextAutoNumberSchemeKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private TextAutoNumberSchemeKind? _Type;
    /// <summary>
    /// Starting value for numbering.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AutoNumberedBullet.StartAt))]
    /// <summary>
    /// Starting value for numbering.
    /// </summary>
    [OpenXmlElement(typeof(DXD.AutoNumberedBullet))]
    public Int32? StartAt { get => _StartAt; set => UpdateField(ref _StartAt, value, nameof(StartAt)); }

    private Int32? _StartAt;
}