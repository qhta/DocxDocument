namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the ComboBox Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:comboBox.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Item"/> <c>&lt;mso14:item&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.ComboBox))]
[XmlRoot("ComboBox", Namespace = "DocumentModel.CustomUI")]
public class ComboBox : ModelElement<DXO10CUI.ComboBox>
{
 /// <summary>
 /// Specifies whether item images are shown in the dropdown list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.ShowItemImage))]
 public Boolean? ShowItemImage { get => _ShowItemImage; set => UpdateField(ref _ShowItemImage, value, nameof(ShowItemImage)); }

 private Boolean? _ShowItemImage;
 /// <summary>
 /// Specifies the callback that returns the number of items.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetItemCount))]
 public String? GetItemCount { get => _GetItemCount; set => UpdateField(ref _GetItemCount, value, nameof(GetItemCount)); }

 private String? _GetItemCount;
 /// <summary>
 /// Specifies the callback that returns an item label by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetItemLabel))]
 public String? GetItemLabel { get => _GetItemLabel; set => UpdateField(ref _GetItemLabel, value, nameof(GetItemLabel)); }

 private String? _GetItemLabel;
 /// <summary>
 /// Specifies the callback that returns an item screen tip by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetItemScreentip))]
 public String? GetItemScreentip { get => _GetItemScreentip; set => UpdateField(ref _GetItemScreentip, value, nameof(GetItemScreentip)); }

 private String? _GetItemScreentip;
 /// <summary>
 /// Specifies the callback that returns an item super tip by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetItemSupertip))]
 public String? GetItemSupertip { get => _GetItemSupertip; set => UpdateField(ref _GetItemSupertip, value, nameof(GetItemSupertip)); }

 private String? _GetItemSupertip;
 /// <summary>
 /// Specifies the callback that returns an item image by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetItemImage))]
 public String? GetItemImage { get => _GetItemImage; set => UpdateField(ref _GetItemImage, value, nameof(GetItemImage)); }

 private String? _GetItemImage;
 /// <summary>
 /// Specifies the callback that returns an item identifier by index.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetItemID))]
 public String? GetItemID { get => _GetItemID; set => UpdateField(ref _GetItemID, value, nameof(GetItemID)); }

 private String? _GetItemID;
 /// <summary>
 /// Specifies sample text used to size the combo box.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.SizeString))]
 public String? SizeString { get => _SizeString; set => UpdateField(ref _SizeString, value, nameof(SizeString)); }

 private String? _SizeString;
 /// <summary>
 /// Specifies whether item content is refreshed when the list is opened.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.InvalidateContentOnDrop))]
 public Boolean? InvalidateContentOnDrop { get => _InvalidateContentOnDrop; set => UpdateField(ref _InvalidateContentOnDrop, value, nameof(InvalidateContentOnDrop)); }

 private Boolean? _InvalidateContentOnDrop;
 /// <summary>
 /// Specifies whether the control is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Enabled))]
 public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

 private Boolean? _Enabled;
 /// <summary>
 /// Specifies the callback that returns whether the control is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetEnabled))]
 public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }

 private String? _GetEnabled;
 /// <summary>
 /// Specifies a custom image resource identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Image))]
 public String? Image { get => _Image; set => UpdateField(ref _Image, value, nameof(Image)); }

 private String? _Image;
 /// <summary>
 /// Specifies the built-in Office image identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.ImageMso))]
 public String? ImageMso { get => _ImageMso; set => UpdateField(ref _ImageMso, value, nameof(ImageMso)); }

 private String? _ImageMso;
 /// <summary>
 /// Specifies the callback that returns the control image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetImage))]
 public String? GetImage { get => _GetImage; set => UpdateField(ref _GetImage, value, nameof(GetImage)); }

 private String? _GetImage;
 /// <summary>
 /// Specifies the maximum number of characters allowed in the text value.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.MaxLength))]
 public int? MaxLength { get => _MaxLength; set => UpdateField(ref _MaxLength, value, nameof(MaxLength)); }

 private int? _MaxLength;
 /// <summary>
 /// Specifies the callback that returns the current text value.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetText))]
 public String? GetText { get => _GetText; set => UpdateField(ref _GetText, value, nameof(GetText)); }

 private String? _GetText;
 /// <summary>
 /// Specifies the callback invoked when the text value changes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.OnChange))]
 public String? OnChange { get => _OnChange; set => UpdateField(ref _OnChange, value, nameof(OnChange)); }

 private String? _OnChange;
 /// <summary>
 /// Specifies the unique identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Id))]
 public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private String? _Id;
 /// <summary>
 /// Specifies the qualified identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.QualifiedId))]
 public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

 private String? _QualifiedId;
 /// <summary>
 /// Specifies an application-defined tag for the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Tag))]
 public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

 private String? _Tag;
 /// <summary>
 /// Specifies the identifier of a built-in Office control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.IdMso))]
 public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }

 private String? _IdMso;
 /// <summary>
 /// Specifies the short screen tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Screentip))]
 public String? Screentip { get => _Screentip; set => UpdateField(ref _Screentip, value, nameof(Screentip)); }

 private String? _Screentip;
 /// <summary>
 /// Specifies the callback that returns screen tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetScreentip))]
 public String? GetScreentip { get => _GetScreentip; set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip)); }

 private String? _GetScreentip;
 /// <summary>
 /// Specifies the extended super tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Supertip))]
 public String? Supertip { get => _Supertip; set => UpdateField(ref _Supertip, value, nameof(Supertip)); }

 private String? _Supertip;
 /// <summary>
 /// Specifies the callback that returns super tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetSupertip))]
 public String? GetSupertip { get => _GetSupertip; set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip)); }

 private String? _GetSupertip;
 /// <summary>
 /// Specifies the display label of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Label))]
 public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

 private String? _Label;
 /// <summary>
 /// Specifies the callback that returns the control label.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetLabel))]
 public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

 private String? _GetLabel;
 /// <summary>
 /// Specifies a built-in control after which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.InsertAfterMso))]
 public String? InsertAfterMso { get => _InsertAfterMso; set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso)); }

 private String? _InsertAfterMso;
 /// <summary>
 /// Specifies a built-in control before which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.InsertBeforeMso))]
 public String? InsertBeforeMso { get => _InsertBeforeMso; set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso)); }

 private String? _InsertBeforeMso;
 /// <summary>
 /// Specifies a qualified control identifier after which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.InsertAfterQulifiedId))]
 public String? InsertAfterQualifiedId { get => _InsertAfterQualifiedId; set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId)); }

 private String? _InsertAfterQualifiedId;
 /// <summary>
 /// Specifies a qualified control identifier before which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.InsertBeforeQulifiedId))]
 public String? InsertBeforeQualifiedId { get => _InsertBeforeQualifiedId; set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId)); }

 private String? _InsertBeforeQualifiedId;
 /// <summary>
 /// Specifies whether the control is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Visible))]
 public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

 private Boolean? _Visible;
 /// <summary>
 /// Specifies the callback that returns whether the control is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetVisible))]
 public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

 private String? _GetVisible;
 /// <summary>
 /// Specifies the keyboard tip shown for quick access.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.Keytip))]
 public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }

 private String? _Keytip;
 /// <summary>
 /// Specifies the callback that returns the keyboard tip.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetKeytip))]
 public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }

 private String? _GetKeytip;
 /// <summary>
 /// Specifies whether the label is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.ShowLabel))]
 public Boolean? ShowLabel { get => _ShowLabel; set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel)); }

 private Boolean? _ShowLabel;
 /// <summary>
 /// Specifies the callback that returns whether the label is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetShowLabel))]
 public String? GetShowLabel { get => _GetShowLabel; set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel)); }

 private String? _GetShowLabel;
 /// <summary>
 /// Specifies whether the image is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.ShowImage))]
 public Boolean? ShowImage { get => _ShowImage; set => UpdateField(ref _ShowImage, value, nameof(ShowImage)); }

 private Boolean? _ShowImage;
 /// <summary>
 /// Specifies the callback that returns whether the image is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ComboBox.GetShowImage))]
 public String? GetShowImage { get => _GetShowImage; set => UpdateField(ref _GetShowImage, value, nameof(GetShowImage)); }

 private String? _GetShowImage;
}