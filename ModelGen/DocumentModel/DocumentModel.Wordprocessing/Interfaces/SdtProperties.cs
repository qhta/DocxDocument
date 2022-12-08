namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public interface SdtProperties
{
  public Collection<RunProperties>? RunPropertieses { get ; set; }
  
  public Collection<String>? SdtAliases { get ; set; }
  
  public Collection<LockingKind>? Locks { get ; set; }
  
  public Collection<SdtPlaceholder>? SdtPlaceholders { get ; set; }
  
  public Collection<Boolean>? ShowingPlaceholders { get ; set; }
  
  public Collection<DataBinding>? DataBindings { get ; set; }
  
  public Collection<Boolean>? TemporarySdts { get ; set; }
  
  public Collection<Int32>? SdtIds { get ; set; }
  
  public Collection<String>? Tags { get ; set; }
  
  public Collection<Color>? Colors { get ; set; }
  
  public Collection<SdtAppearance>? Appearances { get ; set; }
  
  public Collection<Boolean>? WebExtensionLinkeds { get ; set; }
  
  public Collection<Boolean>? WebExtensionCreateds { get ; set; }
  
  public Collection<Boolean>? SdtContentEquations { get ; set; }
  
  public Collection<SdtContentComboBox>? SdtContentComboBoxs { get ; set; }
  
  public Collection<SdtContentDate>? SdtContentDates { get ; set; }
  
  public Collection<SdtContentDocPartObject>? SdtContentDocPartObjects { get ; set; }
  
  public Collection<SdtContentDocPartList>? SdtContentDocPartLists { get ; set; }
  
  public Collection<SdtContentDropDownList>? SdtContentDropDownLists { get ; set; }
  
  public Collection<Boolean>? SdtContentPictures { get ; set; }
  
  public Collection<Boolean>? SdtContentRichTexts { get ; set; }
  
  public Collection<SdtContentText>? SdtContentTexts { get ; set; }
  
  public Collection<Boolean>? SdtContentCitations { get ; set; }
  
  public Collection<Boolean>? SdtContentGroups { get ; set; }
  
  public Collection<Boolean>? SdtContentBibliographies { get ; set; }
  
  public Collection<Boolean>? EntityPickerEmpties { get ; set; }
  
  public Collection<SdtContentCheckBox>? SdtContentCheckBoxs { get ; set; }
  
  public Collection<SdtRepeatedSection>? SdtRepeatedSections { get ; set; }
  
  public Collection<Boolean>? SdtRepeatedSectionItems { get ; set; }
  
}
