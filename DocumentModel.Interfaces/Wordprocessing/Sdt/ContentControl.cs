using Microsoft.Office.Interop.Word;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a content control in a Wordprocessing document.
/// This interface is used as a base for structured document tag (SDT) content controls, enabling advanced management and customization of content regions within the document.
/// Adds properties corresponding to Microsoft.Office.Interop.Word.ContentControl.
/// </summary>
public partial interface ContentControl : CollectionItem
{
  /// <summary>
  /// Application object for the content control.
  /// </summary>
  public object? Application { get; }

  /// <summary>
  /// Creator code (32-bit integer) for the content control.
  /// </summary>
  public int Creator { get; }

  /// <summary>
  /// Parent object of the content control.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  /// Range object associated with the content control.
  /// </summary>
  public object? Range { get; }

  /// <summary>
  /// Indicates whether the content control itself is locked.
  /// </summary>
  public bool? LockContentControl { get; set; }

  /// <summary>
  /// Indicates whether the contents of the control are locked.
  /// </summary>
  public bool? LockContents { get; set; }

  /// <summary>
  /// XML mapping for the content control.
  /// </summary>
  public object? XMLMapping { get; }

  /// <summary>
  /// Type of the content control.
  /// </summary>
  public ContentControlType? Type { get; set; }

  /// <summary>
  /// List entries for dropdown or combo box content controls.
  /// </summary>
  public object? DropdownListEntries { get; }

  /// <summary>
  /// Placeholder text building block.
  /// </summary>
  public object? PlaceholderText { get; }


  /// <summary>
  /// Title of the content control.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  /// Date display format for date content controls.
  /// </summary>
  public string? DateDisplayFormat { get; set; }

  /// <summary>
  /// Indicates whether the content control allows multiple lines.
  /// </summary>
  public bool? MultiLine { get; set; }

  /// <summary>
  /// Parent content control if nested.
  /// </summary>
  public ContentControl? ParentContentControl { get; }

  /// <summary>
  /// Indicates whether the content control is temporary.
  /// </summary>
  public bool? Temporary { get; set; }

  /// <summary>
  /// Unique ID for the content control.
  /// </summary>
  public string? ID { get; }

  /// <summary>
  /// Indicates whether the placeholder text is currently shown.
  /// </summary>
  public bool? ShowingPlaceholderText { get; }

  /// <summary>
  /// Date storage format for date content controls.
  /// </summary>
  public DateStorageFormat? DateStorageFormat { get; set; }

  /// <summary>
  /// Building block type for building block content controls.
  /// </summary>
  public BuildingBlockType? BuildingBlockType { get; set; }

  /// <summary>
  /// Building block category for building block content controls.
  /// </summary>
  public string? BuildingBlockCategory { get; set; }

  /// <summary>
  /// Date display locale for date content controls.
  /// </summary>
  public int? DateDisplayLocale { get; set; }

  /// <summary>
  /// Default text style for the content control.
  /// </summary>
  public object? DefaultTextStyle { get; set; }

  /// <summary>
  /// Calendar type for date content controls.
  /// </summary>
  public CalendarType? DateCalendarType { get; set; }

  /// <summary>
  /// Tag for programmatic identification.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Indicates whether the checkbox content control is checked.
  /// </summary>
  public bool? Checked { get; set; }

  /// <summary>
  /// Color of the content control.
  /// </summary>
  public int? Color { get; set; }

  /// <summary>
  /// Appearance of the content control (bounding box, tags, hidden).
  /// </summary>
  public AppearanceKind? Appearance { get; set; }

  /// <summary>
  /// Level of the content control (inline, block, etc.).
  /// </summary>
  public int? Level { get; }

  /// <summary>
  /// Collection of repeating section items.
  /// </summary>
  public object? RepeatingSectionItems { get; }

  /// <summary>
  /// Title for a repeating section item.
  /// </summary>
  public string? RepeatingSectionItemTitle { get; set; }

  /// <summary>
  /// Indicates whether insert/delete section is allowed in repeating section.
  /// </summary>
  public bool? AllowInsertDeleteSection { get; set; }
}