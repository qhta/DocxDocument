namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public interface ISdtProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IRunProperties>? RunPropertieses { get ; set; }
  
  public Collection<String>? SdtAliases { get ; set; }
  
  public Collection<LockingKind>? Locks { get ; set; }
  
  public Collection<ISdtPlaceholder>? SdtPlaceholders { get ; set; }
  
  public Collection<Boolean>? ShowingPlaceholders { get ; set; }
  
  public Collection<IDataBinding>? DataBindings { get ; set; }
  
  public Collection<Boolean>? TemporarySdts { get ; set; }
  
  public Collection<Int32>? SdtIds { get ; set; }
  
  public Collection<String>? Tags { get ; set; }
  
  public Collection<IColor>? Colors { get ; set; }
  
  public Collection<SdtAppearance>? Appearances { get ; set; }
  
  public Collection<Boolean>? WebExtensionLinkeds { get ; set; }
  
  public Collection<Boolean>? WebExtensionCreateds { get ; set; }
  
  public Collection<Boolean>? SdtContentEquations { get ; set; }
  
  public Collection<ISdtContentComboBox>? SdtContentComboBoxs { get ; set; }
  
  public Collection<ISdtContentDate>? SdtContentDates { get ; set; }
  
  public Collection<ISdtContentDocPartObject>? SdtContentDocPartObjects { get ; set; }
  
  public Collection<ISdtContentDocPartList>? SdtContentDocPartLists { get ; set; }
  
  public Collection<ISdtContentDropDownList>? SdtContentDropDownLists { get ; set; }
  
  public Collection<Boolean>? SdtContentPictures { get ; set; }
  
  public Collection<Boolean>? SdtContentRichTexts { get ; set; }
  
  public Collection<ISdtContentText>? SdtContentTexts { get ; set; }
  
  public Collection<Boolean>? SdtContentCitations { get ; set; }
  
  public Collection<Boolean>? SdtContentGroups { get ; set; }
  
  public Collection<Boolean>? SdtContentBibliographies { get ; set; }
  
  public Collection<Boolean>? EntityPickerEmpties { get ; set; }
  
  public Collection<ISdtContentCheckBox>? SdtContentCheckBoxs { get ; set; }
  
  public Collection<ISdtRepeatedSection>? SdtRepeatedSections { get ; set; }
  
  public Collection<Boolean>? SdtRepeatedSectionItems { get ; set; }
  
}
