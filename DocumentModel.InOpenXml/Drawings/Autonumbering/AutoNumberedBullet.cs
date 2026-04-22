namespace DocumentModel.Drawings;
/// <summary>
/// Represents an auto-numbered bullet, specifying the numbering scheme and starting value for bullet lists.
/// </summary>
[OpenXmlType(typeof(DXD.AutoNumberedBullet))]
[XmlRoot("AutoNumberedBullet", Namespace = "DocumentModel.Drawings")]
public partial class AutoNumberedBullet : ModelElement<DXD.AutoNumberedBullet>
{
 /// <summary>
 /// Bullet autonumbering type.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AutoNumberedBullet.Type))]
 public TextAutoNumberSchemeType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private TextAutoNumberSchemeType? _Type;

 /// <summary>
 /// Starting value for numbering.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AutoNumberedBullet.StartAt))]
 public Int32? StartAt { get => _StartAt; set => UpdateField(ref _StartAt, value, nameof(StartAt)); }
 private Int32? _StartAt;
}