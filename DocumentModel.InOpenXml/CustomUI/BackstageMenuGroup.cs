namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the BackstageMenuGroup Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:menuGroup.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox"/> <c>&lt;mso14:checkBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton"/> <c>&lt;mso14:toggleButton&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu"/> <c>&lt;mso14:menu&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.BackstageMenuGroup))]
[DataContract]
[XmlRoot("BackstageMenuGroup", Namespace = "DocumentModel.CustomUI")]
public partial class BackstageMenuGroup: ModelElement<DXO10CUI.BackstageMenuGroup>
{
  /// <summary>
  /// Specifies the unique identifier of the menu group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuGroup.Id))]
  public String? Id
  {
    get => _Id ??= GetProperty<String?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the menu group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuGroup.QualifiedId))]
  public String? QualifiedId
  {
    get => _QualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.QualifiedId);
    set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId));
  }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the menu group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuGroup.Tag))]
  public String? Tag
  {
    get => _Tag ??= GetProperty<String?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private String? _Tag;

  /// <summary>
  /// Specifies the display label of the menu group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuGroup.Label))]
  public String? Label
  {
    get => _Label ??= GetProperty<String?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns the menu group label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuGroup.GetLabel))]
  public String? GetLabel
  {
    get => _GetLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private String? _GetLabel;

  /// <summary>
  /// Specifies the item size mode used for child controls in the menu group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuGroup.ItemSize))]
  public ItemSize? ItemSize
  {
    get => _ItemSize ??= GetProperty<ItemSize?>(GetUpdatableElement()?.ItemSize);
    set => UpdateField(ref _ItemSize, value, nameof(ItemSize));
  }
  private ItemSize? _ItemSize;
}