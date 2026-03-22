namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the BackstageTab Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:tab.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups"/> <c>&lt;mso14:firstColumn&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups"/> <c>&lt;mso14:secondColumn&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.BackstageTab))]
public class BackstageTab: ModelElement<DXO10CUI.BackstageTab>
{
  /// <summary>
  /// Specifies the unique identifier of the tab.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private String? _Id;
  /// <summary>
  /// Specifies the qualified identifier of the tab.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }
  private String? _QualifiedId;
  /// <summary>
  /// Specifies an application-defined tag for the tab.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
  private String? _Tag;
  /// <summary>
  /// Specifies the identifier of a built-in Office tab.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.IdMso))]
  public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }
  private String? _IdMso;
  /// <summary>
  /// Specifies a built-in tab after which this tab is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.InsertAfterMso))]
  public String? InsertAfterMso
  {
    get => _InsertAfterMso;
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }
  private String? _InsertAfterMso;
  /// <summary>
  /// Specifies a built-in tab before which this tab is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.InsertBeforeMso))]
  public String? InsertBeforeMso
  {
    get => _InsertBeforeMso;
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }
  private String? _InsertBeforeMso;
  /// <summary>
  /// Specifies a qualified tab identifier after which this tab is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId;
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }
  private String? _InsertAfterQualifiedId;
  /// <summary>
  /// Specifies a qualified tab identifier before which this tab is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId;
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }
  private String? _InsertBeforeQualifiedId;
  /// <summary>
  /// Specifies whether the tab is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.Enabled))]
  public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }
  private Boolean? _Enabled;
  /// <summary>
  /// Specifies the callback that returns whether the tab is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.GetEnabled))]
  public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }
  private String? _GetEnabled;
  /// <summary>
  /// Specifies the display label of the tab.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.Label))]
  public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }
  private String? _Label;
  /// <summary>
  /// Specifies the callback that returns the tab label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.GetLabel))]
  public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }
  private String? _GetLabel;
  /// <summary>
  /// Specifies whether the tab is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }
  private Boolean? _Visible;
  /// <summary>
  /// Specifies the callback that returns whether the tab is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }
  private String? _GetVisible;
  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.Keytip))]
  public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }
  private String? _Keytip;
  /// <summary>
  /// Specifies the callback that returns the keyboard tip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.GetKeytip))]
  public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }
  private String? _GetKeytip;
  /// <summary>
  /// Specifies the title text shown in Backstage.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.Title))]
  public String? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }
  private String? _Title;
  /// <summary>
  /// Specifies the callback that returns the tab title.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.GetTitle))]
  public String? GetTitle { get => _GetTitle; set => UpdateField(ref _GetTitle, value, nameof(GetTitle)); }
  private String? _GetTitle;
  /// <summary>
  /// Specifies the relative width percentage assigned to the first column.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.ColumnWidthPercent))]
  public int? ColumnWidthPercent
  {
    get => _ColumnWidthPercent;
    set => UpdateField(ref _ColumnWidthPercent, value, nameof(ColumnWidthPercent));
  }
  private int? _ColumnWidthPercent;
  /// <summary>
  /// Specifies the minimum width of the first column.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.FirstColumnMinWidth))]
  public int? FirstColumnMinWidth
  {
    get => _FirstColumnMinWidth;
    set => UpdateField(ref _FirstColumnMinWidth, value, nameof(FirstColumnMinWidth));
  }
  private int? _FirstColumnMinWidth;
  /// <summary>
  /// Specifies the maximum width of the first column.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.FirstColumnMaxWidth))]
  public int? FirstColumnMaxWidth
  {
    get => _FirstColumnMaxWidth;
    set => UpdateField(ref _FirstColumnMaxWidth, value, nameof(FirstColumnMaxWidth));
  }
  private int? _FirstColumnMaxWidth;
  /// <summary>
  /// Specifies the minimum width of the second column.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.SecondColumnMinWidth))]
  public int? SecondColumnMinWidth
  {
    get => _SecondColumnMinWidth;
    set => UpdateField(ref _SecondColumnMinWidth, value, nameof(SecondColumnMinWidth));
  }
  private int? _SecondColumnMinWidth;
  /// <summary>
  /// Specifies the maximum width of the second column.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.SecondColumnMaxWidth))]
  public int? SecondColumnMaxWidth
  {
    get => _SecondColumnMaxWidth;
    set => UpdateField(ref _SecondColumnMaxWidth, value, nameof(SecondColumnMaxWidth));
  }
  private int? _SecondColumnMaxWidth;
  /// <summary>
  /// Specifies the content groups displayed in the first Backstage column.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.BackstageGroups))]
  public BackstageGroups? BackstageGroups
  {
    get => _BackstageGroups;
    set => UpdateField(ref _BackstageGroups, value, nameof(BackstageGroups));
  }
  private BackstageGroups? _BackstageGroups;
  /// <summary>
  /// Specifies the content groups displayed in the second Backstage column.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageTab.SimpleGroups))]
  public SimpleGroups? SimpleGroups
  {
    get => _SimpleGroups;
    set => UpdateField(ref _SimpleGroups, value, nameof(SimpleGroups));
  }
  private SimpleGroups? _SimpleGroups;
}