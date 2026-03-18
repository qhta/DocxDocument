namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the MenuRoot Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox"/> <c>&lt;mso14:checkBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular"/> <c>&lt;mso14:control&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular"/> <c>&lt;mso14:dynamicMenu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular"/> <c>&lt;mso14:gallery&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular"/> <c>&lt;mso14:menu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator"/> <c>&lt;mso14:menuSeparator&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular"/> <c>&lt;mso14:splitButton&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular"/> <c>&lt;mso14:toggleButton&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.MenuRoot))]
public class MenuRoot: ModelElement<DXO10CUI.MenuRoot>
{
  /// <summary>
  /// Specifies the title.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.MenuRoot.Title))]
  public String? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

  private String? _Title;

  /// <summary>
  /// Specifies the callback that returns title.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.MenuRoot.GetTitle))]
  public String? GetTitle { get => _GetTitle; set => UpdateField(ref _GetTitle, value, nameof(GetTitle)); }

  private String? _GetTitle;

  /// <summary>
  /// Specifies the item size mode used by the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.MenuRoot.ItemSize))]
  public ItemSize? ItemSize { get => _ItemSize; set => UpdateField(ref _ItemSize, value, nameof(ItemSize)); }

  private ItemSize? _ItemSize;
}