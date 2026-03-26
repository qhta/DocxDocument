using DocumentModel.Wordprocessing;

namespace DocumentModel.Interop.Word;

/// <summary>
/// An individual content control. Content controls are bounded and potentially labeled regions in a document that serve as containers for specific types of content. Individual content controls may contain contents such as dates, lists, or paragraphs of formatted text. The ContentControl object is a member of the ContentControls collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol?view=word-pia"/>
public partial interface ContentControl : InteropObject
{
  /// <summary>
  /// Gets the range of text contained in the content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the content control itself is locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.lockcontentcontrol?view=word-pia"/>
  public bool LockContentControl { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the contents of the content control are locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.lockcontents?view=word-pia"/>
  public bool LockContents { get; set; }

  /// <summary>
  /// Gets the XML mapping for the content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.xmlmapping?view=word-pia"/>
  public XMLMapping XMLMapping { get; }

  /// <summary>
  /// Gets or sets the type of content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.type?view=word-pia"/>
  public ContentControlType Type { get; set; }

  /// <summary>
  /// Gets the collection of list entries for a drop-down or combo box content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.dropdownlistentries?view=word-pia"/>
  public ContentControlListEntries DropdownListEntries { get; }

  /// <summary>
  /// Gets the placeholder text building block for the content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.placeholdertext?view=word-pia"/>
  public BuildingBlock PlaceholderText { get; }

  /// <summary>
  /// Gets or sets the title of the content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// Gets or sets the display format for date values.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.datedisplayformat?view=word-pia"/>
  public string DateDisplayFormat { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the content control supports multiple lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.multiline?view=word-pia"/>
  public bool MultiLine { get; set; }

  /// <summary>
  /// Gets the parent content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.parentcontentcontrol?view=word-pia"/>
  public ContentControl ParentContentControl { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the content control is removed after it is edited.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.temporary?view=word-pia"/>
  public bool Temporary { get; set; }

  /// <summary>
  /// Gets the unique identifier of the content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.id?view=word-pia"/>
  public string ID { get; }

  /// <summary>
  /// Gets a value indicating whether placeholder text is currently displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.showingplaceholdertext?view=word-pia"/>
  public bool ShowingPlaceholderText { get; }

  /// <summary>
  /// Gets or sets how date values are stored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.datestorageformat?view=word-pia"/>
  public DateStorageFormat DateStorageFormat { get; set; }

  /// <summary>
  /// Gets or sets the building block type for a building block gallery content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.buildingblocktype?view=word-pia"/>
  public BuildingBlockTypes BuildingBlockType { get; set; }

  /// <summary>
  /// Gets or sets the building block category for a building block gallery content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.buildingblockcategory?view=word-pia"/>
  public string BuildingBlockCategory { get; set; }

  /// <summary>
  /// Gets or sets the locale used to display dates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.datedisplaylocale?view=word-pia"/>
  public LanguageID DateDisplayLocale { get; set; }

  /// <summary>
  /// Gets or sets the default text style for the content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.defaulttextstyle?view=word-pia"/>
  public object DefaultTextStyle { get; set; }

  /// <summary>
  /// Gets or sets the calendar type used for date values.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.datecalendartype?view=word-pia"/>
  public CalendarType DateCalendarType { get; set; }

  /// <summary>
  /// Gets or sets a tag value for identifying the content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.tag?view=word-pia"/>
  public string Tag { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether a check box content control is checked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.checked?view=word-pia"/>
  public bool Checked { get; set; }

  /// <summary>
  /// Gets or sets the color of the content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.color?view=word-pia"/>
  public RgbColor Color { get; set; }

  /// <summary>
  /// Gets or sets how the content control appears in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.appearance?view=word-pia"/>
  public ContentControlAppearance Appearance { get; set; }

  /// <summary>
  /// Gets the level of the content control in the content control hierarchy.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.level?view=word-pia"/>
  public ContentControlLevel Level { get; }

  /// <summary>
  /// Gets the collection of repeating section items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.repeatingsectionitems?view=word-pia"/>
  public RepeatingSectionItemColl RepeatingSectionItems { get; }

  /// <summary>
  /// Gets or sets the title displayed for each repeating section item.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.repeatingsectionitemtitle?view=word-pia"/>
  public string RepeatingSectionItemTitle { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether users can insert or delete repeating section items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.allowinsertdeletesection?view=word-pia"/>
  public bool AllowInsertDeleteSection { get; set; }
}
