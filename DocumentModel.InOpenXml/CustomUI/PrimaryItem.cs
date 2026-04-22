namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the PrimaryItem Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:primaryItem.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu"/> <c>&lt;mso14:menu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton"/> <c>&lt;mso14:button&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.PrimaryItem))]
[XmlRoot("PrimaryItem", Namespace = "DocumentModel.CustomUI")]
public partial class PrimaryItem : ModelElement<DXO10CUI.PrimaryItem>
{
  /// <summary>
  /// Specifies the backstage regular button.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.PrimaryItem.BackstageRegularButton))]
  public BackstageRegularButton? BackstageRegularButton { get => _BackstageRegularButton; set => UpdateField(ref _BackstageRegularButton, value, nameof(BackstageRegularButton)); }
  private BackstageRegularButton? _BackstageRegularButton;

  /// <summary>
  /// Specifies the backstage primary menu.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.PrimaryItem.BackstagePrimaryMenu))]
  public BackstagePrimaryMenu? BackstagePrimaryMenu { get => _BackstagePrimaryMenu; set => UpdateField(ref _BackstagePrimaryMenu, value, nameof(BackstagePrimaryMenu)); }
  private BackstagePrimaryMenu? _BackstagePrimaryMenu;
}