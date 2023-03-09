namespace DocumentModel.Wordprocessing;

/// <summary>
///   Structured Document Tag Properties.
/// </summary>
public class SdtProperties : IBodyElement
{
  [XmlContentElement] public RunProperties? RunProperties { get; set; }

  public String? SdtAlias { get; set; }

  public LockingKind? Lock { get; set; }

  [XmlContentElement] public SdtPlaceholder? SdtPlaceholder { get; set; }

  public Boolean? ShowingPlaceholder { get; set; }

  [XmlContentElement] public DataBinding? DataBinding { get; set; }

  public Boolean? TemporarySdt { get; set; }

  [XmlAttribute] public HexInt? SdtId { get; set; }

  public String? Tag { get; set; }

  [XmlContentElement] public Color3? Color { get; set; }

  [XmlContentElement] public SdtAppearance? Appearance { get; set; }

  public Boolean? WebExtensionLinked { get; set; }

  public Boolean? WebExtensionCreated { get; set; }

  public Boolean? SdtContentEquation { get; set; }

  [XmlContentElement] public SdtContentComboBox? SdtContentComboBox { get; set; }

  public SdtContentDate? SdtContentDate { get; set; }

  [XmlContentElement] public SdtContentDocPartObject? SdtContentDocPartObject { get; set; }

  [XmlContentElement] public SdtContentDocPartList? SdtContentDocPartList { get; set; }

  [XmlContentElement] public SdtContentDropDownList? SdtContentDropDownList { get; set; }

  public Boolean? SdtContentPicture { get; set; }

  public Boolean? SdtContentRichText { get; set; }

  [XmlContentElement] public SdtContentText? SdtContentText { get; set; }

  public Boolean? SdtContentCitation { get; set; }

  public Boolean? SdtContentGroup { get; set; }

  public Boolean? SdtContentBibliography { get; set; }

  public Boolean? EntityPickerEmpty { get; set; }

  [XmlContentElement] public SdtContentCheckBox? SdtContentCheckBox { get; set; }

  [XmlContentElement] public SdtRepeatedSection? SdtRepeatedSection { get; set; }

  public Boolean? SdtRepeatedSectionItem { get; set; }
}