namespace DocumentModel.Wordprocessing;

/// <summary>
///   Structured Document Tag Properties.
/// </summary>
public class SdtProperties : IBodyElement
{
  public RunProperties? RunProperties { get; set; }

  public String? SdtAlias { get; set; }

  public LockingKind? Lock { get; set; }

  public SdtPlaceholder? SdtPlaceholder { get; set; }

  public Boolean? ShowingPlaceholder { get; set; }

  public DataBinding? DataBinding { get; set; }

  public Boolean? TemporarySdt { get; set; }

  public Int32? SdtId { get; set; }

  public String? Tag { get; set; }

  public Color3? Color { get; set; }

  public SdtAppearance? Appearance { get; set; }

  public Boolean? WebExtensionLinked { get; set; }

  public Boolean? WebExtensionCreated { get; set; }

  public Boolean? SdtContentEquation { get; set; }

  public SdtContentComboBox? SdtContentComboBox { get; set; }

  public SdtContentDate? SdtContentDate { get; set; }

  public SdtContentDocPartObject? SdtContentDocPartObject { get; set; }

  public SdtContentDocPartList? SdtContentDocPartList { get; set; }

  public SdtContentDropDownList? SdtContentDropDownList { get; set; }

  public Boolean? SdtContentPicture { get; set; }

  public Boolean? SdtContentRichText { get; set; }

  public SdtContentText? SdtContentText { get; set; }

  public Boolean? SdtContentCitation { get; set; }

  public Boolean? SdtContentGroup { get; set; }

  public Boolean? SdtContentBibliography { get; set; }

  public Boolean? EntityPickerEmpty { get; set; }

  public SdtContentCheckBox? SdtContentCheckBox { get; set; }

  public SdtRepeatedSection? SdtRepeatedSection { get; set; }

  public Boolean? SdtRepeatedSectionItem { get; set; }
}