namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the Box Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:box.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Box"/> <c>&lt;mso14:box&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Button"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup"/> <c>&lt;mso14:buttonGroup&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox"/> <c>&lt;mso14:checkBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox"/> <c>&lt;mso14:comboBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone"/> <c>&lt;mso14:control&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular"/> <c>&lt;mso14:dropDown&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu"/> <c>&lt;mso14:dynamicMenu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.EditBox"/> <c>&lt;mso14:editBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Gallery"/> <c>&lt;mso14:gallery&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl"/> <c>&lt;mso14:labelControl&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Menu"/> <c>&lt;mso14:menu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton"/> <c>&lt;mso14:splitButton&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton"/> <c>&lt;mso14:toggleButton&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.Box))]
public class Box: ModelElement<DXO10CUI.Box>
{
  /// <summary>
  /// Specifies the unique identifier of the box.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the box.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the box.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

  private String? _Tag;

  /// <summary>
  /// Specifies whether the box is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns whether the box is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

  private String? _GetVisible;

  /// <summary>
  /// Specifies a built-in control after which this box is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.InsertAfterMso))]
  public String? InsertAfterMso
  {
    get => _InsertAfterMso;
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }

  private String? _InsertAfterMso;

  /// <summary>
  /// Specifies a built-in control before which this box is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.InsertBeforeMso))]
  public String? InsertBeforeMso
  {
    get => _InsertBeforeMso;
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }

  private String? _InsertBeforeMso;

  /// <summary>
  /// Specifies a qualified control identifier after which this box is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId;
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }

  private String? _InsertAfterQualifiedId;

  /// <summary>
  /// Specifies a qualified control identifier before which this box is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId;
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }

  private String? _InsertBeforeQualifiedId;

  /// <summary>
  /// Specifies the visual layout style of the box.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Box.BoxStyle))]
  public BoxStyle? BoxStyle { get => _BoxStyle; set => UpdateField(ref _BoxStyle, value, nameof(BoxStyle)); }

  private BoxStyle? _BoxStyle;
}