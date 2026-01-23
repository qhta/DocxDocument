namespace DocumentModel.Drawings;
/// <summary>
/// Represents a character bullet, including the bullet character and additional extension options.
/// </summary>
public partial class CharacterBullet : ModelElement<DXD.CharacterBullet>, IExtendableElement
{
    /// <summary>
    /// Bullet character.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.CharacterBullet.Char))]
    /// <summary>
    /// Bullet character.
    /// </summary>
    [OpenXmlElement(typeof(DXD.CharacterBullet))]
    public string? Char { get => _Char; set => UpdateField(ref _Char, value, nameof(Char)); }

    private string? _Char;
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlElement(typeof(DXD.CharacterBullet))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}