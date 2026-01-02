namespace DocumentModel.Wordprocessing;

/// <summary>
///  Specifies the set of properties which shall be applied to the parent structured document tag.
/// </summary>
public class SdtProperties : ModelElement, IStoryContent
{
  /// <summary>
  /// specifies a unique numerical ID for the nearest ancestor structured document tag. 
  /// This ID shall be persisted through multiple sessions (i.e. shall not be changed once specified).
  /// </summary>
  public IHexInt? SdtId { get; set; }
  /// <summary>
  /// Run properties of text runs in the structured document tag.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
  /// <summary>
  /// Specifies the friendly name associated with the current structured document tag.
  /// </summary>
  public string? SdtAlias { get; set; }
  /// <summary>
  /// Specifies the set of behaviors that shall be applied to the contents of the parent structured document tag 
  /// when the contents of this document are edited by an application (whether through a user interface or directly).
  /// </summary>
  public LockingKind? Lock { get; set; }
  /// <summary>
  /// Specifies the placeholder text which should be displayed when the parent structured document tag's run contents are empty, 
  /// the associated mapped XML element is empty as specified via the dataBinding element 
  /// or the showingPlcHdr element is set in the structured document tag's properties. 
  /// The placeholder text which shall be shown is itself specified via the child element docPart.
  /// </summary>
  public SdtPlaceholder? SdtPlaceholder { get; set; }
  /// <summary>
  /// Specifies whether the content of the SdtContent element for the parent structured document tag 
  /// shall be interpreted to contain placeholder text for this structured document tag 
  /// (as opposed to regular text contents within the structured document tag). 
  /// If this element is present and set to true, this state shall be resumed (showing placeholder text) upon opening this document.
  /// </summary>
  public bool? ShowingPlaceholder { get; set; }
  /// <summary>
  /// Specifies the information that shall be used to establish a mapping between the parent structured document tag 
  /// and an XML element stored within a Custom XML Data part in the current WordprocessingML document. 
  /// </summary>
  public DataBinding? DataBinding { get; set; }
  /// <summary>
  /// Specifies whether the parent structured document tag shall be removed from the WordprocessingML document 
  /// when the its contents are modified.
  /// </summary>
  public bool? TemporarySdt { get; set; }
  /// <summary>
  /// Specifies a programmatic tag associated with the current structured document tag. 
  /// A programmatic tag is an arbitrary string which applications can associate with a structured document tag 
  /// in order to identify it without providing a visible friendly name. 
  /// The string representing the programmatic tag shall be stored on this element's val attribute.
  /// </summary>
  public string? Tag { get; set; }
  public DM.IColor? Color { get; set; }
  public AppearanceKind? Appearance { get; set; }
  public bool? WebExtensionLinked { get; set; }
  public bool? WebExtensionCreated { get; set; }
  public bool? SdtContentEquation { get; set; }
  public bool? SdtContentPicture { get; set; }
  public bool? SdtContentRichText { get; set; }
  public bool? SdtContentCitation { get; set; }
  public bool? SdtContentGroup { get; set; }
  public bool? SdtContentBibliography { get; set; }
  public bool? EntityPickerEmpty { get; set; }
  public bool? IsRepeatedSectionItem { get; set; }
  public SdtContentText? SdtContentText { get; set; }
  public SdtContentCheckBox? SdtContentCheckBox { get; set; }
  public SdtContentComboBox? SdtContentComboBox { get; set; }
  public SdtContentDate? SdtContentDate { get; set; }
  public SdtContentDocPartObject? SdtContentDocPartObject { get; set; }
  public SdtContentDocPartList? SdtContentDocPartList { get; set; }
  public SdtContentDropDownList? SdtContentDropDownList { get; set; }
  public SdtRepeatedSection? SdtRepeatedSection { get; set; }
}