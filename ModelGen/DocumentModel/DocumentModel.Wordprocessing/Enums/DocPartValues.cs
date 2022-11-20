namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocPartValues enumeration.
/// </summary>
public enum DocPartValues
{
  /// <summary>
  /// No Type.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Normal.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// Automatically Replace Name With Content.
  /// </summary>
  [XmlEnum("autoExp")]
  AutoExp,
  
  /// <summary>
  /// AutoText User Interface Entry.
  /// </summary>
  [XmlEnum("toolbar")]
  Toolbar,
  
  /// <summary>
  /// AutoCorrect Entry.
  /// </summary>
  [XmlEnum("speller")]
  Speller,
  
  /// <summary>
  /// Form Field Help Text.
  /// </summary>
  [XmlEnum("formFld")]
  FormField,
  
  /// <summary>
  /// Structured Document Tag Placeholder Text.
  /// </summary>
  [XmlEnum("bbPlcHdr")]
  SdtPlaceholder,
  
}
