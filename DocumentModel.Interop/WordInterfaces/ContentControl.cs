namespace DocumentModel.Interop.Word;

/// <summary>
/// An individual content control. Content controls are bounded and potentially labeled regions in a document that serve as containers for specific types of content. Individual content controls may contain contents such as dates, lists, or paragraphs of formatted text. The ContentControl object is a member of the ContentControls collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol?view=word-pia"/>
public partial interface ContentControl : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The lock content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.lockcontentcontrol?view=word-pia"/>
  public bool LockContentControl { get; set; }

  /// <summary>
  /// The lock contents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.lockcontents?view=word-pia"/>
  public bool LockContents { get; set; }

  /// <summary>
  /// The xmlmapping.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.xmlmapping?view=word-pia"/>
  public XMLMapping XMLMapping { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.type?view=word-pia"/>
  public WdContentControlType Type { get; set; }

  /// <summary>
  /// The dropdown list entries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.dropdownlistentries?view=word-pia"/>
  public ContentControlListEntries DropdownListEntries { get; }

  /// <summary>
  /// The placeholder text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.placeholdertext?view=word-pia"/>
  public BuildingBlock PlaceholderText { get; }

  /// <summary>
  /// The title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// The date display format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.datedisplayformat?view=word-pia"/>
  public string DateDisplayFormat { get; set; }

  /// <summary>
  /// The multi line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.multiline?view=word-pia"/>
  public bool MultiLine { get; set; }

  /// <summary>
  /// The parent content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.parentcontentcontrol?view=word-pia"/>
  public ContentControl ParentContentControl { get; }

  /// <summary>
  /// The temporary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.temporary?view=word-pia"/>
  public bool Temporary { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.id?view=word-pia"/>
  public string ID { get; }

  /// <summary>
  /// The showing placeholder text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.showingplaceholdertext?view=word-pia"/>
  public bool ShowingPlaceholderText { get; }

  /// <summary>
  /// The date storage format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.datestorageformat?view=word-pia"/>
  public WdContentControlDateStorageFormat DateStorageFormat { get; set; }

  /// <summary>
  /// The building block type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.buildingblocktype?view=word-pia"/>
  public WdBuildingBlockTypes BuildingBlockType { get; set; }

  /// <summary>
  /// The building block category.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.buildingblockcategory?view=word-pia"/>
  public string BuildingBlockCategory { get; set; }

  /// <summary>
  /// The date display locale.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.datedisplaylocale?view=word-pia"/>
  public WdLanguageID DateDisplayLocale { get; set; }

  /// <summary>
  /// The default text style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.defaulttextstyle?view=word-pia"/>
  public object DefaultTextStyle { get; set; }

  /// <summary>
  /// The date calendar type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.datecalendartype?view=word-pia"/>
  public WdCalendarType DateCalendarType { get; set; }

  /// <summary>
  /// The tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.tag?view=word-pia"/>
  public string Tag { get; set; }

  /// <summary>
  /// The checked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.checked?view=word-pia"/>
  public bool Checked { get; set; }

  /// <summary>
  /// The color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.color?view=word-pia"/>
  public WdColor Color { get; set; }

  /// <summary>
  /// The appearance.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.appearance?view=word-pia"/>
  public WdContentControlAppearance Appearance { get; set; }

  /// <summary>
  /// The level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.level?view=word-pia"/>
  public WdContentControlLevel Level { get; }

  /// <summary>
  /// The repeating section items.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.repeatingsectionitems?view=word-pia"/>
  public RepeatingSectionItemColl RepeatingSectionItems { get; }

  /// <summary>
  /// The repeating section item title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.repeatingsectionitemtitle?view=word-pia"/>
  public string RepeatingSectionItemTitle { get; set; }

  /// <summary>
  /// The allow insert delete section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.allowinsertdeletesection?view=word-pia"/>
  public bool AllowInsertDeleteSection { get; set; }
}
