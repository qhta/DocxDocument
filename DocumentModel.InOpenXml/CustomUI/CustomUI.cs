namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the CustomUI Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:customUI.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Backstage"/> <c>&lt;mso14:backstage&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Commands"/> <c>&lt;mso14:commands&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus"/> <c>&lt;mso14:contextMenus&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon"/> <c>&lt;mso14:ribbon&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.CustomUI))]
[DataContract]
[XmlRoot("CustomUI", Namespace = "DocumentModel.CustomUI")]
public partial class CustomUI : ModelElement<DXO10CUI.CustomUI>
{
  /// <summary>
  /// Specifies the callback invoked when the custom UI is loaded.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.CustomUI.OnLoad))]
  public String? OnLoad { get => _OnLoad; set => UpdateField(ref _OnLoad, value, nameof(OnLoad)); }
  private String? _OnLoad;

  /// <summary>
  /// Specifies the callback that resolves custom images.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.CustomUI.LoadImage))]
  public String? LoadImage { get => _LoadImage; set => UpdateField(ref _LoadImage, value, nameof(LoadImage)); }
  private String? _LoadImage;

  /// <summary>
  /// Specifies the command definitions available in the custom UI.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.CustomUI.Commands))]
  public Commands? Commands { get => _Commands; set => UpdateField(ref _Commands, value, nameof(Commands)); }
  private Commands? _Commands;

  /// <summary>
  /// Specifies the ribbon customization definition.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.CustomUI.Ribbon))]
  public Ribbon? Ribbon { get => _Ribbon; set => UpdateField(ref _Ribbon, value, nameof(Ribbon)); }
  private Ribbon? _Ribbon;

  /// <summary>
  /// Specifies the Backstage customization definition.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.CustomUI.Backstage))]
  public Backstage? Backstage { get => _Backstage; set => UpdateField(ref _Backstage, value, nameof(Backstage)); }
  private Backstage? _Backstage;

  /// <summary>
  /// Specifies context menu customizations.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.CustomUI.ContextMenus))]
  public ContextMenus? ContextMenus { get => _ContextMenus; set => UpdateField(ref _ContextMenus, value, nameof(ContextMenus)); }
  private ContextMenus? _ContextMenus;

  /// <summary>
  /// Specifies the package part that stores ribbon and Backstage customizations.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.CustomUI.RibbonAndBackstageCustomizationsPart))]
  public DXPP.RibbonAndBackstageCustomizationsPart? RibbonAndBackstageCustomizationsPart { get => _RibbonAndBackstageCustomizationsPart; set => UpdateField(ref _RibbonAndBackstageCustomizationsPart, value, nameof(RibbonAndBackstageCustomizationsPart)); }
  private DXPP.RibbonAndBackstageCustomizationsPart? _RibbonAndBackstageCustomizationsPart;
}