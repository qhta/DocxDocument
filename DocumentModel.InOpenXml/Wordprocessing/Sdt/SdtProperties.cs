namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the set of properties that define the behavior, appearance, and functionality of a structured document tag (SDT) in a WordprocessingML document.
/// This class provides configuration for identity, data binding, appearance, content type, behavior, locking, and specialized controls, enabling advanced management and customization of SDTs at block, inline, row, or cell level.
/// </summary>
[OpenXmlType(typeof(DXW.SdtProperties))]
[DataContract]
[XmlRoot("SdtProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class SdtProperties : ModelElement<DXW.SdtProperties>, IStoryContent
{
 /// <summary>
 /// Unique numerical identifier for this structured document tag.
 /// </summary>
 public HexInt? SdtId { get => _SdtId; set => UpdateField(ref _SdtId, value, nameof(SdtId)); }
 private HexInt? _SdtId;

 /// <summary>
 /// Run properties applied to text runs within the structured document tag.
 /// </summary>
 public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }
 private RunProperties? _RunProperties;

 /// <summary>
 /// Friendly name (alias) associated with this structured document tag.
 /// </summary>
 public string? SdtAlias { get => _SdtAlias; set => UpdateField(ref _SdtAlias, value, nameof(SdtAlias)); }
 private string? _SdtAlias;

 /// <summary>
 /// Locking behavior that controls how the content and the SDT itself can be edited.
 /// </summary>
 public Locking? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }
 private Locking? _Lock;

 /// <summary>
 /// Placeholder configuration that defines the text displayed when the SDT is empty.
 /// </summary>
 public SdtPlaceholder? SdtPlaceholder { get => _SdtPlaceholder; set => UpdateField(ref _SdtPlaceholder, value, nameof(SdtPlaceholder)); }
 private SdtPlaceholder? _SdtPlaceholder;

 /// <summary>
 /// Indicates whether the SDT is currently displaying placeholder text.
 /// </summary>
 public bool? ShowingPlaceholder { get => _ShowingPlaceholder; set => UpdateField(ref _ShowingPlaceholder, value, nameof(ShowingPlaceholder)); }
 private bool? _ShowingPlaceholder;

 /// <summary>
 /// Data binding configuration that maps this SDT to an XML element in a Custom XML Data part.
 /// </summary>
 public SdtDataBinding? DataBinding { get => _DataBinding; set => UpdateField(ref _DataBinding, value, nameof(DataBinding)); }
 private SdtDataBinding? _DataBinding;

 /// <summary>
 /// Indicates whether this SDT should be automatically removed when its contents are modified.
 /// </summary>
 public bool? TemporarySdt { get => _TemporarySdt; set => UpdateField(ref _TemporarySdt, value, nameof(TemporarySdt)); }
 private bool? _TemporarySdt;

 /// <summary>
 /// Programmatic tag that identifies this SDT for application code.
 /// </summary>
 public string? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
 private string? _Tag;

 /// <summary>
 /// Color used for visual highlighting or borders of the SDT.
 /// </summary>
 public DocumentModel.AnyColor? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private DocumentModel.AnyColor? _Color;

 /// <summary>
 /// Visual appearance style for this structured document tag.
 /// </summary>
 public SdtAppearance? Appearance { get => _Appearance; set => UpdateField(ref _Appearance, value, nameof(Appearance)); }
 private SdtAppearance? _Appearance;

 /// <summary>
 /// Indicates whether this SDT is linked to a web extension (Office Add-in).
 /// </summary>
 public bool? WebExtensionLinked { get => _WebExtensionLinked; set => UpdateField(ref _WebExtensionLinked, value, nameof(WebExtensionLinked)); }
 private bool? _WebExtensionLinked;

 /// <summary>
 /// Indicates whether this SDT was created by a web extension (Office Add-in).
 /// </summary>
 public bool? WebExtensionCreated { get => _WebExtensionCreated; set => UpdateField(ref _WebExtensionCreated, value, nameof(WebExtensionCreated)); }
 private bool? _WebExtensionCreated;

 /// <summary>
 /// Indicates whether this SDT represents an equation content control.
 /// </summary>
 public bool? SdtContentEquation { get => _SdtContentEquation; set => UpdateField(ref _SdtContentEquation, value, nameof(SdtContentEquation)); }
 private bool? _SdtContentEquation;

 /// <summary>
 /// Indicates whether this SDT represents a picture content control.
 /// </summary>
 public bool? SdtContentPicture { get => _SdtContentPicture; set => UpdateField(ref _SdtContentPicture, value, nameof(SdtContentPicture)); }
 private bool? _SdtContentPicture;

 /// <summary>
 /// Indicates whether this SDT represents a rich text content control.
 /// </summary>
 public bool? SdtContentRichText { get => _SdtContentRichText; set => UpdateField(ref _SdtContentRichText, value, nameof(SdtContentRichText)); }
 private bool? _SdtContentRichText;

 /// <summary>
 /// Indicates whether this SDT represents a citation content control.
 /// </summary>
 public bool? SdtContentCitation { get => _SdtContentCitation; set => UpdateField(ref _SdtContentCitation, value, nameof(SdtContentCitation)); }
 private bool? _SdtContentCitation;

 /// <summary>
 /// Indicates whether this SDT represents a group content control.
 /// </summary>
 public bool? SdtContentGroup { get => _SdtContentGroup; set => UpdateField(ref _SdtContentGroup, value, nameof(SdtContentGroup)); }
 private bool? _SdtContentGroup;

 /// <summary>
 /// Indicates whether this SDT represents a bibliography content control.
 /// </summary>
 public bool? SdtContentBibliography { get => _SdtContentBibliography; set => UpdateField(ref _SdtContentBibliography, value, nameof(SdtContentBibliography)); }
 private bool? _SdtContentBibliography;

 /// <summary>
 /// Indicates whether the entity picker for this SDT is in an empty state.
 /// </summary>
 public bool? EntityPickerEmpty { get => _EntityPickerEmpty; set => UpdateField(ref _EntityPickerEmpty, value, nameof(EntityPickerEmpty)); }
 private bool? _EntityPickerEmpty;

 /// <summary>
 /// Indicates whether this SDT is an item within a repeating section.
 /// </summary>
 public bool? IsRepeatedSectionItem { get => _IsRepeatedSectionItem; set => UpdateField(ref _IsRepeatedSectionItem, value, nameof(IsRepeatedSectionItem)); }
 private bool? _IsRepeatedSectionItem;

 /// <summary>
 /// Plain text or formatted text content control configuration.
 /// </summary>
 public SdtContentText? SdtContentText { get => _SdtContentText; set => UpdateField(ref _SdtContentText, value, nameof(SdtContentText)); }
 private SdtContentText? _SdtContentText;

 /// <summary>
 /// Checkbox content control configuration.
 /// </summary>
 public SdtContentCheckBox? SdtContentCheckBox { get => _SdtContentCheckBox; set => UpdateField(ref _SdtContentCheckBox, value, nameof(SdtContentCheckBox)); }
 private SdtContentCheckBox? _SdtContentCheckBox;

 /// <summary>
 /// Combo box content control configuration.
 /// </summary>
 public SdtContentComboBox? SdtContentComboBox { get => _SdtContentComboBox; set => UpdateField(ref _SdtContentComboBox, value, nameof(SdtContentComboBox)); }
 private SdtContentComboBox? _SdtContentComboBox;

 /// <summary>
 /// Date picker content control configuration.
 /// </summary>
 public SdtContentDate? SdtContentDate { get => _SdtContentDate; set => UpdateField(ref _SdtContentDate, value, nameof(SdtContentDate)); }
 private SdtContentDate? _SdtContentDate;

 /// <summary>
 /// Document part object content control configuration.
 /// </summary>
 public SdtContentDocPartObject? SdtContentDocPartObject { get => _SdtContentDocPartObject; set => UpdateField(ref _SdtContentDocPartObject, value, nameof(SdtContentDocPartObject)); }
 private SdtContentDocPartObject? _SdtContentDocPartObject;

 /// <summary>
 /// Document part list content control configuration.
 /// </summary>
 public SdtContentDocPartObject? SdtContentDocPartList { get => _SdtContentDocPartList; set => UpdateField(ref _SdtContentDocPartList, value, nameof(SdtContentDocPartList)); }
 private SdtContentDocPartObject? _SdtContentDocPartList;

 /// <summary>
 /// Drop-down list content control configuration.
 /// </summary>
 public SdtContentDropDownList? SdtContentDropDownList { get => _SdtContentDropDownList; set => UpdateField(ref _SdtContentDropDownList, value, nameof(SdtContentDropDownList)); }
 private SdtContentDropDownList? _SdtContentDropDownList;

 /// <summary>
 /// Repeating section content control configuration.
 /// </summary>
 public SdtRepeatedSection? SdtRepeatedSection { get => _SdtRepeatedSection; set => UpdateField(ref _SdtRepeatedSection, value, nameof(SdtRepeatedSection)); }
 private SdtRepeatedSection? _SdtRepeatedSection;
}