namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the Ribbon Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:ribbon.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs"/> <c>&lt;mso14:contextualTabs&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar"/> <c>&lt;mso14:qat&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Tabs"/> <c>&lt;mso14:tabs&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.Ribbon))]
public class Ribbon: ModelElement<DXO10CUI.Ribbon>
{
  /// <summary>
  /// Specifies the start from scratch.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Ribbon.StartFromScratch))]
  public Boolean? StartFromScratch
  {
    get => _StartFromScratch;
    set => UpdateField(ref _StartFromScratch, value, nameof(StartFromScratch));
  }
  private Boolean? _StartFromScratch;
  /// <summary>
  /// Specifies the quick access toolbar.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Ribbon.QuickAccessToolbar))]
  public QuickAccessToolbar? QuickAccessToolbar
  {
    get => _QuickAccessToolbar;
    set => UpdateField(ref _QuickAccessToolbar, value, nameof(QuickAccessToolbar));
  }
  private QuickAccessToolbar? _QuickAccessToolbar;
  /// <summary>
  /// Specifies the tabs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Ribbon.Tabs))]
  public Tabs? Tabs { get => _Tabs; set => UpdateField(ref _Tabs, value, nameof(Tabs)); }
  private Tabs? _Tabs;
  /// <summary>
  /// Specifies the contextual tabs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Ribbon.ContextualTabs))]
  public ContextualTabs? ContextualTabs
  {
    get => _ContextualTabs;
    set => UpdateField(ref _ContextualTabs, value, nameof(ContextualTabs));
  }
  private ContextualTabs? _ContextualTabs;
}