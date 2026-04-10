namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the Tab Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:tab.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Group"/> <c>&lt;mso14:group&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.Tab))]
[XmlRoot("Tab", Namespace = "DocumentModel.CustomUI")]
public class Tab : ModelElement<DXO10CUI.Tab>
{
 /// <summary>
 /// Specifies the unique identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.Id))]
 public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private String? _Id;
 /// <summary>
 /// Specifies the qualified identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.QualifiedId))]
 public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

 private String? _QualifiedId;
 /// <summary>
 /// Specifies an application-defined tag for the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.Tag))]
 public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

 private String? _Tag;
 /// <summary>
 /// Specifies the identifier of a built-in Office control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.IdMso))]
 public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }

 private String? _IdMso;
 /// <summary>
 /// Specifies the display label of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.Label))]
 public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

 private String? _Label;
 /// <summary>
 /// Specifies the callback that returns label.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.GetLabel))]
 public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

 private String? _GetLabel;
 /// <summary>
 /// Specifies a built-in control after which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.InsertAfterMso))]
 public String? InsertAfterMso { get => _InsertAfterMso; set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso)); }

 private String? _InsertAfterMso;
 /// <summary>
 /// Specifies a built-in control before which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.InsertBeforeMso))]
 public String? InsertBeforeMso { get => _InsertBeforeMso; set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso)); }

 private String? _InsertBeforeMso;
 /// <summary>
 /// Specifies a qualified control identifier after which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.InsertAfterQulifiedId))]
 public String? InsertAfterQualifiedId { get => _InsertAfterQualifiedId; set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId)); }

 private String? _InsertAfterQualifiedId;
 /// <summary>
 /// Specifies a qualified control identifier before which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.InsertBeforeQulifiedId))]
 public String? InsertBeforeQualifiedId { get => _InsertBeforeQualifiedId; set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId)); }

 private String? _InsertBeforeQualifiedId;
 /// <summary>
 /// Specifies whether the control is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.Visible))]
 public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

 private Boolean? _Visible;
 /// <summary>
 /// Specifies the callback that returns visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.GetVisible))]
 public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

 private String? _GetVisible;
 /// <summary>
 /// Specifies the keyboard tip shown for quick access.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.Keytip))]
 public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }

 private String? _Keytip;
 /// <summary>
 /// Specifies the callback that returns keytip.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Tab.GetKeytip))]
 public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }

 private String? _GetKeytip;
}