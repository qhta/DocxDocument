namespace DocumentModel.Interop;

/// <summary>
/// An individual content control. Content controls are bounded and potentially labeled regions in a document that serve as containers for specific types of content. Individual content controls may contain contents such as dates, lists, or paragraphs of formatted text. The ContentControl object is a member of the ContentControls collection.
/// </summary>
public partial interface ContentControl : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The lock content control.
  /// </summary>
  public bool LockContentControl { get; set; }

  /// <summary>
  /// The lock contents.
  /// </summary>
  public bool LockContents { get; set; }

  /// <summary>
  /// The xmlmapping.
  /// </summary>
  public XMLMapping XMLMapping { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdContentControlType Type { get; set; }

  /// <summary>
  /// The dropdown list entries.
  /// </summary>
  public ContentControlListEntries DropdownListEntries { get; }

  /// <summary>
  /// The placeholder text.
  /// </summary>
  public BuildingBlock PlaceholderText { get; }

  /// <summary>
  /// The title.
  /// </summary>
  public string Title { get; set; }

  /// <summary>
  /// The date display format.
  /// </summary>
  public string DateDisplayFormat { get; set; }

  /// <summary>
  /// The multi line.
  /// </summary>
  public bool MultiLine { get; set; }

  /// <summary>
  /// The parent content control.
  /// </summary>
  public ContentControl ParentContentControl { get; }

  /// <summary>
  /// The temporary.
  /// </summary>
  public bool Temporary { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; }

  /// <summary>
  /// The showing placeholder text.
  /// </summary>
  public bool ShowingPlaceholderText { get; }

  /// <summary>
  /// The date storage format.
  /// </summary>
  public WdContentControlDateStorageFormat DateStorageFormat { get; set; }

  /// <summary>
  /// The building block type.
  /// </summary>
  public WdBuildingBlockTypes BuildingBlockType { get; set; }

  /// <summary>
  /// The building block category.
  /// </summary>
  public string BuildingBlockCategory { get; set; }

  /// <summary>
  /// The date display locale.
  /// </summary>
  public WdLanguageID DateDisplayLocale { get; set; }

  /// <summary>
  /// The default text style.
  /// </summary>
  public object DefaultTextStyle { get; set; }

  /// <summary>
  /// The date calendar type.
  /// </summary>
  public WdCalendarType DateCalendarType { get; set; }

  /// <summary>
  /// The tag.
  /// </summary>
  public string Tag { get; set; }

  /// <summary>
  /// The checked.
  /// </summary>
  public bool Checked { get; set; }

  /// <summary>
  /// The color.
  /// </summary>
  public WdColor Color { get; set; }

  /// <summary>
  /// The appearance.
  /// </summary>
  public WdContentControlAppearance Appearance { get; set; }

  /// <summary>
  /// The level.
  /// </summary>
  public WdContentControlLevel Level { get; }

  /// <summary>
  /// The repeating section items.
  /// </summary>
  public RepeatingSectionItemColl RepeatingSectionItems { get; }

  /// <summary>
  /// The repeating section item title.
  /// </summary>
  public string RepeatingSectionItemTitle { get; set; }

  /// <summary>
  /// The allow insert delete section.
  /// </summary>
  public bool AllowInsertDeleteSection { get; set; }
}
