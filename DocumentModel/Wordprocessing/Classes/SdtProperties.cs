namespace DocumentModel.Wordprocessing;

/// <summary>
///   Structured Document Tag Properties.
/// </summary>
public class SdtProperties : IBodyElement
{
  [XmlAnyElement] public RunProperties? RunProperties { get; set; }

  public String? SdtAlias { get; set; }

  public LockingKind? Lock { get; set; }

  [XmlAnyElement] public SdtPlaceholder? SdtPlaceholder { get; set; }

  public Boolean? ShowingPlaceholder { get; set; }

  [XmlAnyElement] public DataBinding? DataBinding { get; set; }

  public Boolean? TemporarySdt { get; set; }

  [XmlAttribute] public HexInt? SdtId { get; set; }

  public String? Tag { get; set; }

  [XmlAnyElement] public Color3? Color { get; set; }

  [XmlAnyElement] public SdtAppearance? Appearance { get; set; }

  public Boolean? WebExtensionLinked { get; set; }

  public Boolean? WebExtensionCreated { get; set; }

  public Boolean? SdtContentEquation { get; set; }

  [XmlAnyElement] public SdtContentComboBox? SdtContentComboBox { get; set; }

  public SdtContentDate? SdtContentDate { get; set; }

  [XmlAnyElement] public SdtContentDocPartObject? SdtContentDocPartObject { get; set; }

  [XmlAnyElement] public SdtContentDocPartList? SdtContentDocPartList { get; set; }

  [XmlAnyElement] public SdtContentDropDownList? SdtContentDropDownList { get; set; }

  public Boolean? SdtContentPicture { get; set; }

  public Boolean? SdtContentRichText { get; set; }

  [XmlAnyElement] public SdtContentText? SdtContentText { get; set; }

  public Boolean? SdtContentCitation { get; set; }

  public Boolean? SdtContentGroup { get; set; }

  public Boolean? SdtContentBibliography { get; set; }

  public Boolean? EntityPickerEmpty { get; set; }

  [XmlAnyElement] public SdtContentCheckBox? SdtContentCheckBox { get; set; }

  [XmlAnyElement] public SdtRepeatedSection? SdtRepeatedSection { get; set; }

  public Boolean? SdtRepeatedSectionItem { get; set; }
}