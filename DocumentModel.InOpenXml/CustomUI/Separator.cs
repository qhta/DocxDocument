namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the Separator Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:separator.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.Separator))]
public class Separator: ModelElement<DXO10CUI.Separator>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private String? _Id;
  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }
  private String? _QualifiedId;
  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
  private String? _Tag;
  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }
  private Boolean? _Visible;
  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }
  private String? _GetVisible;
  /// <summary>
  /// Specifies a built-in control after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.InsertAfterMso))]
  public String? InsertAfterMso
  {
    get => _InsertAfterMso;
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }
  private String? _InsertAfterMso;
  /// <summary>
  /// Specifies a built-in control before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.InsertBeforeMso))]
  public String? InsertBeforeMso
  {
    get => _InsertBeforeMso;
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }
  private String? _InsertBeforeMso;
  /// <summary>
  /// Specifies a qualified control identifier after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId;
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }
  private String? _InsertAfterQualifiedId;
  /// <summary>
  /// Specifies a qualified control identifier before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Separator.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId;
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }
  private String? _InsertBeforeQualifiedId;
}