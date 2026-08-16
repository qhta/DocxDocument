namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the set of properties that define the behavior, appearance, and functionality of a structured document tag (SDT) in a WordprocessingML document.
/// This class provides configuration for identity, data binding, appearance, content type, behavior, locking, and specialized controls, enabling advanced management and customization of SDTs at block, inline, row, or cell level.
/// </summary>
[OpenXmlType(typeof(DXW.SdtProperties))]
[DataContract]
[XmlRoot("SdtProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class SdtProperties: ModelElement<DXW.SdtProperties>, IStoryContent
{
  /// <summary>
  /// Unique numerical identifier for this structured document tag.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtId))]
  public HexInt? SdtId
  {
    get => _SdtId ??= GetElement<HexInt, DXW.SdtId>(GetUpdatableElement());
    set => UpdateField(ref _SdtId, value, nameof(SdtId));
  }
  private HexInt? _SdtId;

  /// <summary>
  /// Run properties applied to text runs within the structured document tag.
  /// </summary>
  [OpenXmlElement(typeof(DXW.RunProperties))]
  public RunProperties? RunProperties
  {
    get => _RunProperties ??= GetElement<RunProperties, DXW.RunProperties>(GetUpdatableElement());
    set => UpdateField(ref _RunProperties, value, nameof(RunProperties));
  }
  private RunProperties? _RunProperties;

  /// <summary>
  /// Friendly name (alias) associated with this structured document tag.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtAlias))]
  public string? SdtAlias
  {
    get => _SdtAlias ??= GetElement<string, DXW.SdtAlias>(GetUpdatableElement());
    set => UpdateField(ref _SdtAlias, value, nameof(SdtAlias));
  }
  private string? _SdtAlias;

  /// <summary>
  /// Locking behavior that controls how the content and the SDT itself can be edited.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Lock))]
  public Locking? Lock
  {
    get => _Lock ??= GetElement<Locking, DXW.Lock>(GetUpdatableElement());
    set => UpdateField(ref _Lock, value, nameof(Lock));
  }
  private Locking? _Lock;

  /// <summary>
  /// Placeholder configuration that defines the text displayed when the SDT is empty.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtPlaceholder))]
  public SdtPlaceholder? SdtPlaceholder
  {
    get => _SdtPlaceholder ??= GetElement<SdtPlaceholder, DXW.SdtPlaceholder>(GetUpdatableElement());
    set => UpdateField(ref _SdtPlaceholder, value, nameof(SdtPlaceholder));
  }
  private SdtPlaceholder? _SdtPlaceholder;

  /// <summary>
  /// Indicates whether the SDT is currently displaying placeholder text.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ShowingPlaceholder))]
  public bool? ShowingPlaceholder
  {
    get => _ShowingPlaceholder ??= GetElement<bool, DXW.ShowingPlaceholder>(GetUpdatableElement());
    set => UpdateField(ref _ShowingPlaceholder, value, nameof(ShowingPlaceholder));
  }
  private bool? _ShowingPlaceholder;

  /// <summary>
  /// Data binding configuration that maps this SDT to an XML element in a Custom XML Data part.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DataBinding))]
  public SdtDataBinding? DataBinding
  {
    get => _DataBinding ??= GetElement<SdtDataBinding, DXW.DataBinding>(GetUpdatableElement());
    set => UpdateField(ref _DataBinding, value, nameof(DataBinding));
  }
  private SdtDataBinding? _DataBinding;

  /// <summary>
  /// Indicates whether this SDT should be automatically removed when its contents are modified.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TemporarySdt))]
  public bool? TemporarySdt
  {
    get => _TemporarySdt ??= GetElement<bool, DXW.TemporarySdt>(GetUpdatableElement());
    set => UpdateField(ref _TemporarySdt, value, nameof(TemporarySdt));
  }
  private bool? _TemporarySdt;

  /// <summary>
  /// Programmatic tag that identifies this SDT for application code.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Tag))]
  public string? Tag
  {
    get => _Tag ??= GetElement<string, DXW.Tag>(GetUpdatableElement());
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private string? _Tag;

  /// <summary>
  /// Color used for visual highlighting or borders of the SDT.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Color))]
  public WordColor? Color
  {
    get => _Color ??= GetElement<WordColor, DXW.Color>(GetUpdatableElement());
    set => UpdateField(ref _Color, value, nameof(Color));
  }
  private WordColor? _Color;

  /// <summary>
  /// Visual appearance style for this structured document tag.
  /// </summary>
  [OpenXmlElement(typeof(DXO13W.Appearance))]
  public SdtAppearance? Appearance
  {
    get => _Appearance ??= GetElement<SdtAppearance, DXO13W.Appearance>(GetUpdatableElement());
    set => UpdateField(ref _Appearance, value, nameof(Appearance));
  }
  private SdtAppearance? _Appearance;

  /// <summary>
  /// Indicates whether this SDT is linked to a web extension (Office Add-in).
  /// </summary>
  [OpenXmlElement(typeof(DXO13W.WebExtensionLinked))]
  public bool? WebExtensionLinked
  {
    get => _WebExtensionLinked ??= GetElement<bool, DXO13W.WebExtensionLinked>(GetUpdatableElement());
    set => UpdateField(ref _WebExtensionLinked, value, nameof(WebExtensionLinked));
  }
  private bool? _WebExtensionLinked;

  /// <summary>
  /// Indicates whether this SDT was created by a web extension (Office Add-in).
  /// </summary>
  [OpenXmlElement(typeof(DXO13W.WebExtensionCreated))]
  public bool? WebExtensionCreated
  {
    get => _WebExtensionCreated ??= GetElement<bool, DXO13W.WebExtensionCreated>(GetUpdatableElement());
    set => UpdateField(ref _WebExtensionCreated, value, nameof(WebExtensionCreated));
  }
  private bool? _WebExtensionCreated;

  /// <summary>
  /// Indicates whether this SDT represents an equation content control.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentEquation))]
  public bool? SdtContentEquation
  {
    get => _SdtContentEquation ??= GetElement<bool, DXW.SdtContentEquation>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentEquation, value, nameof(SdtContentEquation));
  }
  private bool? _SdtContentEquation;

  /// <summary>
  /// Indicates whether this SDT represents a picture content control.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Picture))]
  public bool? SdtContentPicture
  {
    get => _SdtContentPicture ??= GetElement<bool, DXW.Picture>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentPicture, value, nameof(SdtContentPicture));
  }
  private bool? _SdtContentPicture;

  /// <summary>
  /// Indicates whether this SDT represents a rich text content control.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentRichText))]
  public bool? SdtContentRichText
  {
    get => _SdtContentRichText ??= GetElement<bool, DXW.SdtContentRichText>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentRichText, value, nameof(SdtContentRichText));
  }
  private bool? _SdtContentRichText;

  /// <summary>
  /// Indicates whether this SDT represents a citation content control.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentCitation))]
  public bool? SdtContentCitation
  {
    get => _SdtContentCitation ??= GetElement<bool, DXW.SdtContentCitation>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentCitation, value, nameof(SdtContentCitation));
  }
  private bool? _SdtContentCitation;

  /// <summary>
  /// Indicates whether this SDT represents a group content control.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentGroup))]
  public bool? SdtContentGroup
  {
    get => _SdtContentGroup ??= GetElement<bool, DXW.SdtContentGroup>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentGroup, value, nameof(SdtContentGroup));
  }
  private bool? _SdtContentGroup;

  /// <summary>
  /// Indicates whether this SDT represents a bibliography content control.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentBibliography))]
  public bool? SdtContentBibliography
  {
    get => _SdtContentBibliography ??= GetElement<bool, DXW.SdtContentBibliography>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentBibliography, value, nameof(SdtContentBibliography));
  }
  private bool? _SdtContentBibliography;

  /// <summary>
  /// Indicates whether the entity picker for this SDT is in an empty state.
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.EntityPickerEmpty))]
  public bool? EntityPickerEmpty
  {
    get => _EntityPickerEmpty ??= GetElement<bool, DXO10W.EntityPickerEmpty>(GetUpdatableElement());
    set => UpdateField(ref _EntityPickerEmpty, value, nameof(EntityPickerEmpty));
  }
  private bool? _EntityPickerEmpty;

  /// <summary>
  /// Indicates whether this SDT is an item within a repeating section.
  /// </summary>
  [OpenXmlElement(typeof(DXO13W.SdtRepeatedSectionItem))]
  public bool? IsRepeatedSectionItem
  {
    get => _IsRepeatedSectionItem;
    set => UpdateField(ref _IsRepeatedSectionItem, value, nameof(IsRepeatedSectionItem));
  }
  private bool? _IsRepeatedSectionItem;

  /// <summary>
  /// Plain text or formatted text content control configuration.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentText))]
  public SdtContentText? SdtContentText
  {
    get => _SdtContentText ??= GetElement<SdtContentText, DXW.SdtContentText>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentText, value, nameof(SdtContentText));
  }
  private SdtContentText? _SdtContentText;

  /// <summary>
  /// Checkbox content control configuration.
  /// </summary>
  [OpenXmlElement(typeof(DXO10W.SdtContentCheckBox))]
  public SdtContentCheckBox? SdtContentCheckBox
  {
    get => _SdtContentCheckBox ??= GetElement<SdtContentCheckBox, DXO10W.SdtContentCheckBox>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentCheckBox, value, nameof(SdtContentCheckBox));
  }
  private SdtContentCheckBox? _SdtContentCheckBox;

  /// <summary>
  /// Combo box content control configuration.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentComboBox))]
  public SdtContentComboBox? SdtContentComboBox
  {
    get => _SdtContentComboBox;
    set => UpdateField(ref _SdtContentComboBox, value, nameof(SdtContentComboBox));
  }
  private SdtContentComboBox? _SdtContentComboBox;

  /// <summary>
  /// Date picker content control configuration.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentDate))]
  public SdtContentDate? SdtContentDate
  {
    get => _SdtContentDate ??= GetElement<SdtContentDate, DXW.SdtContentDate>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentDate, value, nameof(SdtContentDate));
  }
  private SdtContentDate? _SdtContentDate;

  /// <summary>
  /// Document part object content control configuration.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentDocPartObject))]
  public SdtContentDocPartObject? SdtContentDocPartObject
  {
    get => _SdtContentDocPartObject ??=
      GetElement<SdtContentDocPartObject, DXW.SdtContentDocPartObject>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentDocPartObject, value, nameof(SdtContentDocPartObject));
  }
  private SdtContentDocPartObject? _SdtContentDocPartObject;

  /// <summary>
  /// Document part list content control configuration.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentDocPartList))]
  public SdtContentDocPartObject? SdtContentDocPartList
  {
    get => _SdtContentDocPartList ??=
      GetElement<SdtContentDocPartObject, DXW.SdtContentDocPartList>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentDocPartList, value, nameof(SdtContentDocPartList));
  }
  private SdtContentDocPartObject? _SdtContentDocPartList;

  /// <summary>
  /// Drop-down list content control configuration.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SdtContentDropDownList))]
  public SdtContentDropDownList? SdtContentDropDownList
  {
    get => _SdtContentDropDownList ??=
      GetElement<SdtContentDropDownList, DXW.SdtContentDropDownList>(GetUpdatableElement());
    set => UpdateField(ref _SdtContentDropDownList, value, nameof(SdtContentDropDownList));
  }
  private SdtContentDropDownList? _SdtContentDropDownList;

  /// <summary>
  /// Repeating section content control configuration.
  /// </summary>
  [OpenXmlElement(typeof(DXO13W.SdtRepeatedSection))]
  public SdtRepeatedSection? SdtRepeatedSection
  {
    get => _SdtRepeatedSection ??= GetElement<SdtRepeatedSection, DXO13W.SdtRepeatedSection>(GetUpdatableElement());
    set => UpdateField(ref _SdtRepeatedSection, value, nameof(SdtRepeatedSection));
  }
  private SdtRepeatedSection? _SdtRepeatedSection;
}