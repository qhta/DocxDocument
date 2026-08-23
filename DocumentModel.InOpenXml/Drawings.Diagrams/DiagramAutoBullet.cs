namespace DocumentModel.Drawings.Diagram1;

/// <summary>
///   Defines the DiagramAutoBullet Class.
/// </summary>
[OpenXmlType(typeof(DXO19DD1.DiagramAutoBullet))]
[DataContract]
[XmlRoot("DiagramAutoBullet", Namespace = "DocumentModel.Drawings.Diagram1")]
public partial class
  DiagramAutoBullet: ModelElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>
{
  /// <summary>
  ///   prefix
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.DiagramAutoBullet.AutoBulletPrefix))]
  public string? AutoBulletPrefix
  {
    get => _AutoBulletPrefix ??= GetProperty<string?>(GetUpdatableElement()?.AutoBulletPrefix);
    set => UpdateField(ref _AutoBulletPrefix, value, nameof(AutoBulletPrefix));
  }

  private string? _AutoBulletPrefix;

  /// <summary>
  ///   leadZeros
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.DiagramAutoBullet.LeadZeros))]
  public bool? LeadZeros
  {
    get => _LeadZeros ??= GetProperty<bool?>(GetUpdatableElement()?.LeadZeros);
    set => UpdateField(ref _LeadZeros, value, nameof(LeadZeros));
  }

  private bool? _LeadZeros;

  /// <summary>
  ///   No Bullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.DiagramAutoBullet.NoBullet))]
  public bool? NoBullet
  {
    get => _NoBullet ??= GetProperty<bool?>(GetUpdatableElement()?.NoBullet);
    set => UpdateField(ref _NoBullet, value, nameof(NoBullet));
  }

  private bool? _NoBullet;

  /// <summary>
  ///   Auto-Numbered Bullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.DiagramAutoBullet.AutoNumberedBullet))]
  public AutoNumberedBullet? AutoNumberedBullet
  {
    get => _AutoNumberedBullet ??= GetProperty<AutoNumberedBullet?>(GetUpdatableElement()?.AutoNumberedBullet);
    set => UpdateField(ref _AutoNumberedBullet, value, nameof(AutoNumberedBullet));
  }

  private AutoNumberedBullet? _AutoNumberedBullet;

  /// <summary>
  ///   Character Bullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.DiagramAutoBullet.CharacterBullet))]
  public CharacterBullet? CharacterBullet
  {
    get => _CharacterBullet ??= GetProperty<CharacterBullet?>(GetUpdatableElement()?.CharacterBullet);
    set => UpdateField(ref _CharacterBullet, value, nameof(CharacterBullet));
  }

  private CharacterBullet? _CharacterBullet;

  /// <summary>
  ///   Picture Bullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DD1.DiagramAutoBullet.PictureBullet))]
  public PictureBullet? PictureBullet
  {
    get => _PictureBullet ??= GetProperty<PictureBullet?>(GetUpdatableElement()?.PictureBullet);
    set => UpdateField(ref _PictureBullet, value, nameof(PictureBullet));
  }

  private PictureBullet? _PictureBullet;
}