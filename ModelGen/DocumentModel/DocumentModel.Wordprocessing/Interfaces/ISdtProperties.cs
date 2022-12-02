namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public interface ISdtProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
  public System.String? SdtAlias { get ; set; }
  
  public DocumentModel.Wordprocessing.LockingKind? Lock { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtPlaceholder? SdtPlaceholder { get ; set; }
  
  public System.Boolean? ShowingPlaceholder { get ; set; }
  
  public DocumentModel.Wordprocessing.IDataBinding? DataBinding { get ; set; }
  
  public System.Boolean? TemporarySdt { get ; set; }
  
  public System.Int32? SdtId { get ; set; }
  
  public System.String? Tag { get ; set; }
  
  public DocumentModel.Wordprocessing.IColor? Color { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtAppearance? Appearance { get ; set; }
  
  public System.Boolean? WebExtensionLinked { get ; set; }
  
  public System.Boolean? WebExtensionCreated { get ; set; }
  
  public System.Boolean? SdtContentEquation { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtContentComboBox? SdtContentComboBox { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtContentDate? SdtContentDate { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtContentDocPartObject? SdtContentDocPartObject { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtContentDocPartList? SdtContentDocPartList { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtContentDropDownList? SdtContentDropDownList { get ; set; }
  
  public System.Boolean? SdtContentPicture { get ; set; }
  
  public System.Boolean? SdtContentRichText { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtContentText? SdtContentText { get ; set; }
  
  public System.Boolean? SdtContentCitation { get ; set; }
  
  public System.Boolean? SdtContentGroup { get ; set; }
  
  public System.Boolean? SdtContentBibliography { get ; set; }
  
  public System.Boolean? EntityPickerEmpty { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtContentCheckBox? SdtContentCheckBox { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtRepeatedSection? SdtRepeatedSection { get ; set; }
  
  public System.Boolean? SdtRepeatedSectionItem { get ; set; }
  
}
