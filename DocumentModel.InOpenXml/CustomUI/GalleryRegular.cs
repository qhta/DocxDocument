namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the GalleryRegular Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:gallery.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Item"/> <c>&lt;mso14:item&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.GalleryRegular))]
public class GalleryRegular: ModelElement<DXO10CUI.GalleryRegular>
{
  /// <summary>
  /// Specifies descriptive text associated with the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Description))]
  public String? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }

  private String? _Description;

  /// <summary>
  /// Specifies the callback that returns description.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetDescription))]
  public String? GetDescription
  {
    get => _GetDescription;
    set => UpdateField(ref _GetDescription, value, nameof(GetDescription));
  }

  private String? _GetDescription;

  /// <summary>
  /// Specifies whether content is refreshed when the list is opened.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.InvalidateContentOnDrop))]
  public Boolean? InvalidateContentOnDrop
  {
    get => _InvalidateContentOnDrop;
    set => UpdateField(ref _InvalidateContentOnDrop, value, nameof(InvalidateContentOnDrop));
  }

  private Boolean? _InvalidateContentOnDrop;

  /// <summary>
  /// Specifies the number of columns.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Columns))]
  public int? Columns { get => _Columns; set => UpdateField(ref _Columns, value, nameof(Columns)); }

  private int? _Columns;

  /// <summary>
  /// Specifies the number of rows.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Rows))]
  public int? Rows { get => _Rows; set => UpdateField(ref _Rows, value, nameof(Rows)); }

  private int? _Rows;

  /// <summary>
  /// Specifies the width of each item.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.ItemWidth))]
  public int? ItemWidth { get => _ItemWidth; set => UpdateField(ref _ItemWidth, value, nameof(ItemWidth)); }

  private int? _ItemWidth;

  /// <summary>
  /// Specifies the height of each item.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.ItemHeight))]
  public int? ItemHeight { get => _ItemHeight; set => UpdateField(ref _ItemHeight, value, nameof(ItemHeight)); }

  private int? _ItemHeight;

  /// <summary>
  /// Specifies the callback that returns item width.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetItemWidth))]
  public String? GetItemWidth
  {
    get => _GetItemWidth;
    set => UpdateField(ref _GetItemWidth, value, nameof(GetItemWidth));
  }

  private String? _GetItemWidth;

  /// <summary>
  /// Specifies the callback that returns item height.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetItemHeight))]
  public String? GetItemHeight
  {
    get => _GetItemHeight;
    set => UpdateField(ref _GetItemHeight, value, nameof(GetItemHeight));
  }

  private String? _GetItemHeight;

  /// <summary>
  /// Specifies whether item labels are shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.ShowItemLabel))]
  public Boolean? ShowItemLabel
  {
    get => _ShowItemLabel;
    set => UpdateField(ref _ShowItemLabel, value, nameof(ShowItemLabel));
  }

  private Boolean? _ShowItemLabel;

  /// <summary>
  /// Specifies whether the control is shown in the ribbon.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.ShowInRibbon))]
  public GalleryShowInRibbon? ShowInRibbon
  {
    get => _ShowInRibbon;
    set => UpdateField(ref _ShowInRibbon, value, nameof(ShowInRibbon));
  }

  private GalleryShowInRibbon? _ShowInRibbon;

  /// <summary>
  /// Specifies the callback invoked when action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.OnAction))]
  public String? OnAction { get => _OnAction; set => UpdateField(ref _OnAction, value, nameof(OnAction)); }

  private String? _OnAction;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Enabled))]
  public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

  private Boolean? _Enabled;

  /// <summary>
  /// Specifies the callback that returns enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetEnabled))]
  public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }

  private String? _GetEnabled;

  /// <summary>
  /// Specifies a custom image resource identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Image))]
  public String? Image { get => _Image; set => UpdateField(ref _Image, value, nameof(Image)); }

  private String? _Image;

  /// <summary>
  /// Specifies the built-in Office image identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.ImageMso))]
  public String? ImageMso { get => _ImageMso; set => UpdateField(ref _ImageMso, value, nameof(ImageMso)); }

  private String? _ImageMso;

  /// <summary>
  /// Specifies the callback that returns image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetImage))]
  public String? GetImage { get => _GetImage; set => UpdateField(ref _GetImage, value, nameof(GetImage)); }

  private String? _GetImage;

  /// <summary>
  /// Specifies whether item images are shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.ShowItemImage))]
  public Boolean? ShowItemImage
  {
    get => _ShowItemImage;
    set => UpdateField(ref _ShowItemImage, value, nameof(ShowItemImage));
  }

  private Boolean? _ShowItemImage;

  /// <summary>
  /// Specifies the callback that returns item count.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetItemCount))]
  public String? GetItemCount
  {
    get => _GetItemCount;
    set => UpdateField(ref _GetItemCount, value, nameof(GetItemCount));
  }

  private String? _GetItemCount;

  /// <summary>
  /// Specifies the callback that returns item label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetItemLabel))]
  public String? GetItemLabel
  {
    get => _GetItemLabel;
    set => UpdateField(ref _GetItemLabel, value, nameof(GetItemLabel));
  }

  private String? _GetItemLabel;

  /// <summary>
  /// Specifies the callback that returns item screentip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetItemScreentip))]
  public String? GetItemScreentip
  {
    get => _GetItemScreentip;
    set => UpdateField(ref _GetItemScreentip, value, nameof(GetItemScreentip));
  }

  private String? _GetItemScreentip;

  /// <summary>
  /// Specifies the callback that returns item supertip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetItemSupertip))]
  public String? GetItemSupertip
  {
    get => _GetItemSupertip;
    set => UpdateField(ref _GetItemSupertip, value, nameof(GetItemSupertip));
  }

  private String? _GetItemSupertip;

  /// <summary>
  /// Specifies the callback that returns item image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetItemImage))]
  public String? GetItemImage
  {
    get => _GetItemImage;
    set => UpdateField(ref _GetItemImage, value, nameof(GetItemImage));
  }

  private String? _GetItemImage;

  /// <summary>
  /// Specifies the callback that returns item id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetItemID))]
  public String? GetItemID { get => _GetItemID; set => UpdateField(ref _GetItemID, value, nameof(GetItemID)); }

  private String? _GetItemID;

  /// <summary>
  /// Specifies sample text used to size the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.SizeString))]
  public String? SizeString { get => _SizeString; set => UpdateField(ref _SizeString, value, nameof(SizeString)); }

  private String? _SizeString;

  /// <summary>
  /// Specifies the callback that returns selected item id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetSelectedItemID))]
  public String? GetSelectedItemID
  {
    get => _GetSelectedItemID;
    set => UpdateField(ref _GetSelectedItemID, value, nameof(GetSelectedItemID));
  }

  private String? _GetSelectedItemID;

  /// <summary>
  /// Specifies the callback that returns selected item index.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetSelectedItemIndex))]
  public String? GetSelectedItemIndex
  {
    get => _GetSelectedItemIndex;
    set => UpdateField(ref _GetSelectedItemIndex, value, nameof(GetSelectedItemIndex));
  }

  private String? _GetSelectedItemIndex;

  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

  private String? _Tag;

  /// <summary>
  /// Specifies the identifier of a built-in Office control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.IdMso))]
  public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }

  private String? _IdMso;

  /// <summary>
  /// Specifies the short screen tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Screentip))]
  public String? Screentip { get => _Screentip; set => UpdateField(ref _Screentip, value, nameof(Screentip)); }

  private String? _Screentip;

  /// <summary>
  /// Specifies the callback that returns screentip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetScreentip))]
  public String? GetScreentip
  {
    get => _GetScreentip;
    set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip));
  }

  private String? _GetScreentip;

  /// <summary>
  /// Specifies the extended super tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Supertip))]
  public String? Supertip { get => _Supertip; set => UpdateField(ref _Supertip, value, nameof(Supertip)); }

  private String? _Supertip;

  /// <summary>
  /// Specifies the callback that returns supertip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetSupertip))]
  public String? GetSupertip { get => _GetSupertip; set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip)); }

  private String? _GetSupertip;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Label))]
  public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetLabel))]
  public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

  private String? _GetLabel;

  /// <summary>
  /// Specifies a built-in control after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.InsertAfterMso))]
  public String? InsertAfterMso
  {
    get => _InsertAfterMso;
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }

  private String? _InsertAfterMso;

  /// <summary>
  /// Specifies a built-in control before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.InsertBeforeMso))]
  public String? InsertBeforeMso
  {
    get => _InsertBeforeMso;
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }

  private String? _InsertBeforeMso;

  /// <summary>
  /// Specifies a qualified control identifier after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId;
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }

  private String? _InsertAfterQualifiedId;

  /// <summary>
  /// Specifies a qualified control identifier before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId;
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }

  private String? _InsertBeforeQualifiedId;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

  private String? _GetVisible;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.Keytip))]
  public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }

  private String? _Keytip;

  /// <summary>
  /// Specifies the callback that returns keytip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetKeytip))]
  public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }

  private String? _GetKeytip;

  /// <summary>
  /// Specifies whether the label is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.ShowLabel))]
  public Boolean? ShowLabel { get => _ShowLabel; set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel)); }

  private Boolean? _ShowLabel;

  /// <summary>
  /// Specifies the callback that returns show label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetShowLabel))]
  public String? GetShowLabel
  {
    get => _GetShowLabel;
    set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel));
  }

  private String? _GetShowLabel;

  /// <summary>
  /// Specifies whether the image is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.ShowImage))]
  public Boolean? ShowImage { get => _ShowImage; set => UpdateField(ref _ShowImage, value, nameof(ShowImage)); }

  private Boolean? _ShowImage;

  /// <summary>
  /// Specifies the callback that returns show image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.GalleryRegular.GetShowImage))]
  public String? GetShowImage
  {
    get => _GetShowImage;
    set => UpdateField(ref _GetShowImage, value, nameof(GetShowImage));
  }

  private String? _GetShowImage;
}