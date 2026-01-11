namespace DocumentModel.Wordprocessing
{
  /// <summary>
  /// Specifies the type of a content control, corresponding to Word interop ContentControlType.
  /// </summary>
  public enum ContentControlType
  {
    /// <summary>
    /// Rich text content control.
    /// </summary>
    RichText,

    /// <summary>
    /// Plain text content control.
    /// </summary>
    PlainText,

    /// <summary>
    /// Picture content control.
    /// </summary>
    Picture,

    /// <summary>
    /// Combo box content control.
    /// </summary>
    ComboBox,

    /// <summary>
    /// Drop-down list content control.
    /// </summary>
    DropDownList,

    /// <summary>
    /// Date picker content control.
    /// </summary>
    Date,

    /// <summary>
    /// Building block gallery content control.
    /// </summary>
    BuildingBlockGallery,

    /// <summary>
    /// Check box content control.
    /// </summary>
    CheckBox,

    /// <summary>
    /// Group content control.
    /// </summary>
    Group,

    /// <summary>
    /// Repeating section content control.
    /// </summary>
    RepeatingSection,

    /// <summary>
    /// XML mapping only content control.
    /// </summary>
    XmlMappingOnly,

    /// <summary>
    /// Citation content control.
    /// </summary>
    Citation,

    /// <summary>
    /// Bibliography content control.
    /// </summary>
    Bibliography,

    /// <summary>
    /// Equation content control.
    /// </summary>
    Equation
  }
}