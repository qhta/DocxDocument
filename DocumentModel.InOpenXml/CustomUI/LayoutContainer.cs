namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the LayoutContainer Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:layoutContainer.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox"/> <c>&lt;mso14:checkBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox"/> <c>&lt;mso14:comboBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown"/> <c>&lt;mso14:dropDown&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox"/> <c>&lt;mso14:editBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl"/> <c>&lt;mso14:labelControl&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox"/> <c>&lt;mso14:groupBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink"/> <c>&lt;mso14:hyperlink&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl"/> <c>&lt;mso14:imageControl&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer"/> <c>&lt;mso14:layoutContainer&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup"/> <c>&lt;mso14:radioGroup&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.LayoutContainer))]
[XmlRoot("LayoutContainer", Namespace = "DocumentModel.CustomUI")]
public partial class LayoutContainer : ModelElement<DXO10CUI.LayoutContainer>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.LayoutContainer.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.LayoutContainer.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.LayoutContainer.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
  private String? _Tag;

  /// <summary>
  /// Specifies the alignment setting for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.LayoutContainer.Align))]
  public Expand? Align { get => _Align; set => UpdateField(ref _Align, value, nameof(Align)); }
  private Expand? _Align;

  /// <summary>
  /// Specifies the expansion position in the layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.LayoutContainer.Expand))]
  public Expand? Expand { get => _Expand; set => UpdateField(ref _Expand, value, nameof(Expand)); }
  private Expand? _Expand;

  /// <summary>
  /// Specifies how child controls are arranged.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.LayoutContainer.LayoutChildren))]
  public LayoutChildren? LayoutChildren { get => _LayoutChildren; set => UpdateField(ref _LayoutChildren, value, nameof(LayoutChildren)); }
  private LayoutChildren? _LayoutChildren;
}