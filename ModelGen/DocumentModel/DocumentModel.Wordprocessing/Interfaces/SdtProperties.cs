namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public interface SdtProperties
{
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get ; set; }
  
  public String? SdtAlias { get ; set; }
  
  public DocumentModel.Wordprocessing.LockingKind? Lock { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtPlaceholder? SdtPlaceholder { get ; set; }
  
  public Boolean? ShowingPlaceholder { get ; set; }
  
  public DocumentModel.Wordprocessing.DataBinding? DataBinding { get ; set; }
  
  public Boolean? TemporarySdt { get ; set; }
  
  public Int32? SdtId { get ; set; }
  
  public String? Tag { get ; set; }
  
  public DocumentModel.Wordprocessing.Color? Color { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtAppearance? Appearance { get ; set; }
  
  public Boolean? WebExtensionLinked { get ; set; }
  
  public Boolean? WebExtensionCreated { get ; set; }
  
  public Boolean? SdtContentEquation { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtContentComboBox? SdtContentComboBox { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtContentDate? SdtContentDate { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtContentDocPartObject? SdtContentDocPartObject { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtContentDocPartList? SdtContentDocPartList { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtContentDropDownList? SdtContentDropDownList { get ; set; }
  
  public Boolean? SdtContentPicture { get ; set; }
  
  public Boolean? SdtContentRichText { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtContentText? SdtContentText { get ; set; }
  
  public Boolean? SdtContentCitation { get ; set; }
  
  public Boolean? SdtContentGroup { get ; set; }
  
  public Boolean? SdtContentBibliography { get ; set; }
  
  public Boolean? EntityPickerEmpty { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtContentCheckBox? SdtContentCheckBox { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtRepeatedSection? SdtRepeatedSection { get ; set; }
  
  public Boolean? SdtRepeatedSectionItem { get ; set; }
  
}
