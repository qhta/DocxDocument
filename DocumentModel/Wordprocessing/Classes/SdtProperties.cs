namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///  Specifies the set of properties which shall be applied to the parent structured document tag.
/// </summary>
public class SdtProperties : ModelElement, IBodyElement
{
  /// <summary>
  /// specifies a unique numerical ID for the nearest ancestor structured document tag. 
  /// This ID shall be persisted through multiple sessions (i.e. shall not be changed once specified).
  /// </summary>
  [XmlAttribute] public HexInt? SdtId { get; set; }

  /// <summary>
  /// Run properties of text runs in the structured document tag.
  /// </summary>
  [XmlContentElement] public RunProperties? RunProperties { get; set; }

  /// <summary>
  /// Specifies the friendly name associated with the current structured document tag.
  /// </summary>
  public String? SdtAlias { get; set; }

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
  [XmlContentElement] public SdtPlaceholder? SdtPlaceholder { get; set; }

  /// <summary>
  /// Specifies whether the content of the SdtContent element for the parent structured document tag 
  /// shall be interpreted to contain placeholder text for this structured document tag 
  /// (as opposed to regular text contents within the structured document tag). 
  /// If this element is present and set to true, this state shall be resumed (showing placeholder text) upon opening this document.
  /// </summary>
  public Boolean? ShowingPlaceholder { get; set; }

  /// <summary>
  /// Specifies the information that shall be used to establish a mapping between the parent structured document tag 
  /// and an XML element stored within a Custom XML Data part in the current WordprocessingML document. 
  /// </summary>
  [XmlContentElement] public DataBinding? DataBinding { get; set; }

  /// <summary>
  /// Specifies whether the parent structured document tag shall be removed from the WordprocessingML document 
  /// when the its contents are modified.
  /// </summary>
  public Boolean? TemporarySdt { get; set; }

  /// <summary>
  /// Specifies a programmatic tag associated with the current structured document tag. 
  /// A programmatic tag is an arbitrary string which applications can associate with a structured document tag 
  /// in order to identify it without providing a visible friendly name. 
  /// The string representing the programmatic tag shall be stored on this element's val attribute.
  /// </summary>
  public String? Tag { get; set; }

  [XmlContentElement] public Color3? Color { get; set; }

  public AppearanceKind? Appearance { get; set; }

  public Boolean? WebExtensionLinked { get; set; }

  public Boolean? WebExtensionCreated { get; set; }

  public Boolean? SdtContentEquation { get; set; }

  public Boolean? SdtContentPicture { get; set; }

  public Boolean? SdtContentRichText { get; set; }

  public Boolean? SdtContentCitation { get; set; }

  public Boolean? SdtContentGroup { get; set; }

  public Boolean? SdtContentBibliography { get; set; }

  public Boolean? EntityPickerEmpty { get; set; }

  public Boolean? IsRepeatedSectionItem { get; set; }

  [XmlContentElement] public SdtContentText? SdtContentText { get; set; }

  [XmlContentElement] public SdtContentCheckBox? SdtContentCheckBox { get; set; }

  [XmlContentElement] public SdtContentComboBox? SdtContentComboBox { get; set; }

  [XmlContentElement] public SdtContentDate? SdtContentDate { get; set; }

  public SdtContentDocPartObject? SdtContentDocPartObject { get; set; }

  [XmlContentElement] public SdtContentDocPartList? SdtContentDocPartList { get; set; }

  [XmlContentElement] public SdtContentDropDownList? SdtContentDropDownList { get; set; }

  [XmlContentElement] public SdtRepeatedSection? SdtRepeatedSection { get; set; }
}