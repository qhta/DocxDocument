namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the DropDownRegular Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:dropDown.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Item"/> <c>&lt;mso14:item&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.DropDownRegular))]
[XmlRoot("DropDownRegular", Namespace = "DocumentModel.CustomUI")]
public class DropDownRegular : ModelElement<DXO10CUI.DropDownRegular>
{
 /// <summary>
 /// Specifies the callback invoked when the control action occurs.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.OnAction))]
 public String? OnAction { get => _OnAction; set => UpdateField(ref _OnAction, value, nameof(OnAction)); }

 private String? _OnAction;
 /// <summary>
 /// Specifies whether the control is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Enabled))]
 public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

 private Boolean? _Enabled;
 /// <summary>
 /// Specifies the callback that returns whether the control is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetEnabled))]
 public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }

 private String? _GetEnabled;
 /// <summary>
 /// Specifies a custom image resource identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Image))]
 public String? Image { get => _Image; set => UpdateField(ref _Image, value, nameof(Image)); }

 private String? _Image;
 /// <summary>
 /// Specifies the built-in Office image identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.ImageMso))]
 public String? ImageMso { get => _ImageMso; set => UpdateField(ref _ImageMso, value, nameof(ImageMso)); }

 private String? _ImageMso;
 /// <summary>
 /// Specifies the callback that returns the control image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetImage))]
 public String? GetImage { get => _GetImage; set => UpdateField(ref _GetImage, value, nameof(GetImage)); }

 private String? _GetImage;
 /// <summary>
 /// Specifies whether item images are shown in the dropdown list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.ShowItemImage))]
 public Boolean? ShowItemImage { get => _ShowItemImage; set => UpdateField(ref _ShowItemImage, value, nameof(ShowItemImage)); }

 private Boolean? _ShowItemImage;
 /// <summary>
 /// Specifies the callback that returns the number of items.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetItemCount))]
 public String? GetItemCount { get => _GetItemCount; set => UpdateField(ref _GetItemCount, value, nameof(GetItemCount)); }

 private String? _GetItemCount;
 /// <summary>
 /// Specifies the callback that returns an item label by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetItemLabel))]
 public String? GetItemLabel { get => _GetItemLabel; set => UpdateField(ref _GetItemLabel, value, nameof(GetItemLabel)); }

 private String? _GetItemLabel;
 /// <summary>
 /// Specifies the callback that returns an item screen tip by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetItemScreentip))]
 public String? GetItemScreentip { get => _GetItemScreentip; set => UpdateField(ref _GetItemScreentip, value, nameof(GetItemScreentip)); }

 private String? _GetItemScreentip;
 /// <summary>
 /// Specifies the callback that returns an item super tip by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetItemSupertip))]
 public String? GetItemSupertip { get => _GetItemSupertip; set => UpdateField(ref _GetItemSupertip, value, nameof(GetItemSupertip)); }

 private String? _GetItemSupertip;
 /// <summary>
 /// Specifies the callback that returns an item image by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetItemImage))]
 public String? GetItemImage { get => _GetItemImage; set => UpdateField(ref _GetItemImage, value, nameof(GetItemImage)); }

 private String? _GetItemImage;
 /// <summary>
 /// Specifies the callback that returns an item identifier by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetItemID))]
 public String? GetItemID { get => _GetItemID; set => UpdateField(ref _GetItemID, value, nameof(GetItemID)); }

 private String? _GetItemID;
 /// <summary>
 /// Specifies sample text used to size the dropdown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.SizeString))]
 public String? SizeString { get => _SizeString; set => UpdateField(ref _SizeString, value, nameof(SizeString)); }

 private String? _SizeString;
 /// <summary>
 /// Specifies the callback that returns the selected item identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetSelectedItemID))]
 public String? GetSelectedItemID { get => _GetSelectedItemID; set => UpdateField(ref _GetSelectedItemID, value, nameof(GetSelectedItemID)); }

 private String? _GetSelectedItemID;
 /// <summary>
 /// Specifies the callback that returns the selected item index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetSelectedItemIndex))]
 public String? GetSelectedItemIndex { get => _GetSelectedItemIndex; set => UpdateField(ref _GetSelectedItemIndex, value, nameof(GetSelectedItemIndex)); }

 private String? _GetSelectedItemIndex;
 /// <summary>
 /// Specifies whether item labels are shown in the dropdown list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.ShowItemLabel))]
 public Boolean? ShowItemLabel { get => _ShowItemLabel; set => UpdateField(ref _ShowItemLabel, value, nameof(ShowItemLabel)); }

 private Boolean? _ShowItemLabel;
 /// <summary>
 /// Specifies the unique identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Id))]
 public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private String? _Id;
 /// <summary>
 /// Specifies the qualified identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.QualifiedId))]
 public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

 private String? _QualifiedId;
 /// <summary>
 /// Specifies an application-defined tag for the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Tag))]
 public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

 private String? _Tag;
 /// <summary>
 /// Specifies the identifier of a built-in Office control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.IdMso))]
 public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }

 private String? _IdMso;
 /// <summary>
 /// Specifies the short screen tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Screentip))]
 public String? Screentip { get => _Screentip; set => UpdateField(ref _Screentip, value, nameof(Screentip)); }

 private String? _Screentip;
 /// <summary>
 /// Specifies the callback that returns screen tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetScreentip))]
 public String? GetScreentip { get => _GetScreentip; set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip)); }

 private String? _GetScreentip;
 /// <summary>
 /// Specifies the extended super tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Supertip))]
 public String? Supertip { get => _Supertip; set => UpdateField(ref _Supertip, value, nameof(Supertip)); }

 private String? _Supertip;
 /// <summary>
 /// Specifies the callback that returns super tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetSupertip))]
 public String? GetSupertip { get => _GetSupertip; set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip)); }

 private String? _GetSupertip;
 /// <summary>
 /// Specifies the display label of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Label))]
 public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

 private String? _Label;
 /// <summary>
 /// Specifies the callback that returns the control label.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetLabel))]
 public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

 private String? _GetLabel;
 /// <summary>
 /// Specifies a built-in control after which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.InsertAfterMso))]
 public String? InsertAfterMso { get => _InsertAfterMso; set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso)); }

 private String? _InsertAfterMso;
 /// <summary>
 /// Specifies a built-in control before which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.InsertBeforeMso))]
 public String? InsertBeforeMso { get => _InsertBeforeMso; set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso)); }

 private String? _InsertBeforeMso;
 /// <summary>
 /// Specifies a qualified control identifier after which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.InsertAfterQulifiedId))]
 public String? InsertAfterQualifiedId { get => _InsertAfterQualifiedId; set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId)); }

 private String? _InsertAfterQualifiedId;
 /// <summary>
 /// Specifies a qualified control identifier before which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.InsertBeforeQulifiedId))]
 public String? InsertBeforeQualifiedId { get => _InsertBeforeQualifiedId; set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId)); }

 private String? _InsertBeforeQualifiedId;
 /// <summary>
 /// Specifies whether the control is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Visible))]
 public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

 private Boolean? _Visible;
 /// <summary>
 /// Specifies the callback that returns whether the control is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetVisible))]
 public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

 private String? _GetVisible;
 /// <summary>
 /// Specifies the keyboard tip shown for quick access.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.Keytip))]
 public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }

 private String? _Keytip;
 /// <summary>
 /// Specifies the callback that returns the keyboard tip.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetKeytip))]
 public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }

 private String? _GetKeytip;
 /// <summary>
 /// Specifies whether the label is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.ShowLabel))]
 public Boolean? ShowLabel { get => _ShowLabel; set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel)); }

 private Boolean? _ShowLabel;
 /// <summary>
 /// Specifies the callback that returns whether the label is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetShowLabel))]
 public String? GetShowLabel { get => _GetShowLabel; set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel)); }

 private String? _GetShowLabel;
 /// <summary>
 /// Specifies whether the image is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.ShowImage))]
 public Boolean? ShowImage { get => _ShowImage; set => UpdateField(ref _ShowImage, value, nameof(ShowImage)); }

 private Boolean? _ShowImage;
 /// <summary>
 /// Specifies the callback that returns whether the image is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.DropDownRegular.GetShowImage))]
 public String? GetShowImage { get => _GetShowImage; set => UpdateField(ref _GetShowImage, value, nameof(GetShowImage)); }

 private String? _GetShowImage;
}