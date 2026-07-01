namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the ButtonGroup Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:buttonGroup.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular"/> <c>&lt;mso14:control&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular"/> <c>&lt;mso14:dynamicMenu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular"/> <c>&lt;mso14:gallery&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular"/> <c>&lt;mso14:menu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Separator"/> <c>&lt;mso14:separator&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular"/> <c>&lt;mso14:splitButton&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular"/> <c>&lt;mso14:toggleButton&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.ButtonGroup))]
[DataContract]
[XmlRoot("ButtonGroup", Namespace = "DocumentModel.CustomUI")]
public partial class ButtonGroup : ModelElement<DXO10CUI.ButtonGroup>
{
  /// <summary>
  /// Specifies the unique identifier of the button group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the button group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the button group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
  private String? _Tag;

  /// <summary>
  /// Specifies whether the button group is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }
  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns whether the button group is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }
  private String? _GetVisible;

  /// <summary>
  /// Specifies a built-in control after which this button group is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.InsertAfterMso))]
  public String? InsertAfterMso { get => _InsertAfterMso; set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso)); }
  private String? _InsertAfterMso;

  /// <summary>
  /// Specifies a built-in control before which this button group is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.InsertBeforeMso))]
  public String? InsertBeforeMso { get => _InsertBeforeMso; set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso)); }
  private String? _InsertBeforeMso;

  /// <summary>
  /// Specifies a qualified control identifier after which this button group is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId { get => _InsertAfterQualifiedId; set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId)); }
  private String? _InsertAfterQualifiedId;

  /// <summary>
  /// Specifies a qualified control identifier before which this button group is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ButtonGroup.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId { get => _InsertBeforeQualifiedId; set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId)); }
  private String? _InsertBeforeQualifiedId;
}