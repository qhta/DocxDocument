namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the list formatting attributes that can be applied to paragraphs in a range.
/// </summary>
/// <remarks>
///   <para>
///   ListFormat provides access to all list-related properties and methods for managing
///   numbered and bulleted lists. It controls list level, numbering style, indentation,
///   and other formatting options.
///   </para>
///   <para>
///   This interface corresponds to the Microsoft.Office.Interop.Word.ListFormat interface
///   and provides comprehensive list manipulation capabilities.
///   </para>
/// </remarks>
public interface ListFormat
{
  #region List Properties

  /// <summary>
  ///   Gets the list template for the specified list format.
  /// </summary>
  /// <remarks>
  ///   Returns the list template that defines the numbering scheme and formatting
  ///   for the list. Can be null if no list formatting is applied.
  /// </remarks>
  public ListTemplate? ListTemplate { get; }

  /// <summary>
  ///   Gets or sets the list level (1-9) for the list.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   List levels are numbered from 1 to 9, where:
  ///   <list type="bullet">
  ///   <item><description>Level 1 is the outermost level</description></item>
  ///   <item><description>Level 9 is the most deeply nested level</description></item>
  ///   </list>
  ///   </para>
  ///   Setting this property changes the outline level of the paragraph.
  /// </remarks>
  public int? ListLevel { get; set; }

  /// <summary>
  ///   Gets or sets the list level for the range as a zero-based index.
  /// </summary>
  /// <remarks>
  ///   Same as ListLevel but uses zero-based indexing (0-8 instead of 1-9).
  /// </remarks>
  public int? ListLevelNumber { get; set; }

  /// <summary>
  ///   Gets the current list value (number) for the paragraph.
  /// </summary>
  /// <remarks>
  ///   Returns the actual number that will be displayed for the current paragraph
  ///   based on the numbering format and restart rules.
  /// </remarks>
  public int ListValue { get; }

  /// <summary>
  ///   Gets or sets the list string for the specified range.
  /// </summary>
  /// <remarks>
  ///   Returns the formatted list label text (e.g., "1.", "a.", "i)", etc.)
  ///   that appears before the paragraph text.
  /// </remarks>
  public string? ListString { get; }

  /// <summary>
  ///   Gets the list level picture bullet for the specified list format.
  /// </summary>
  /// <remarks>
  ///   Returns the InlineShape object that represents the picture bullet,
  ///   if the current list level uses a picture bullet.
  /// </remarks>
  public DMWD.InlineShape? ListPictureBullet { get; }

  /// <summary>
  ///   Gets or sets the character style applied to the list label.
  /// </summary>
  /// <remarks>
  ///   Specifies the character style name used to format the list number or bullet.
  /// </remarks>
  public string? ListLabelCharacterStyle { get; set; }

  #endregion

  #region List State

  /// <summary>
  ///   Gets whether a single-level number is used in a list.
  /// </summary>
  /// <remarks>
  ///   Returns true if the list uses simple single-level numbering rather than
  ///   outline numbering with multiple levels.
  /// </remarks>
  public bool SingleList { get; }

  /// <summary>
  ///   Gets the single list level.
  /// </summary>
  public int SingleListLevel { get; }

  /// <summary>
  ///   Gets the count of formatting overrides applied to the list.
  /// </summary>
  /// <remarks>
  ///   Returns the number of list levels that have been modified from the base list template.
  /// </remarks>
  public int NumberedItemsCount { get; }

  #endregion

  #region Indentation

  /// <summary>
  ///   Gets or sets the indentation (in points) for the list.
  /// </summary>
  /// <remarks>
  ///   Controls the left indent of the entire list paragraph including the number/bullet.
  /// </remarks>
  public float ListIndent { get; set; }

  /// <summary>
  ///   Gets or sets the distance (in points) between the list label and the text.
  /// </summary>
  /// <remarks>
  ///   Also known as tab stop distance or number position offset.
  /// </remarks>
  public float ListLabelTextPosition { get; set; }

  #endregion

  #region Apply List Formatting

  /// <summary>
  ///   Applies the specified list template to the range.
  /// </summary>
  /// <param name="listTemplate">The list template to apply.</param>
  /// <param name="continuePreviousList">Whether to continue numbering from a previous list.</param>
  /// <param name="defaultListBehavior">The default list behavior to use.</param>
  public void ApplyListTemplate(
    ListTemplate listTemplate,
    bool? continuePreviousList = null,
    ListApplyDefaultBehaviorKind? defaultListBehavior = null);

  /// <summary>
  ///   Applies the specified list template and sets the list level.
  /// </summary>
  /// <param name="listTemplate">The list template to apply.</param>
  /// <param name="listLevel">The list level (1-9) to apply.</param>
  /// <param name="continuePreviousList">Whether to continue numbering from a previous list.</param>
  public void ApplyListTemplateWithLevel(
    ListTemplate listTemplate,
    int listLevel,
    bool? continuePreviousList = null);

  /// <summary>
  ///   Applies bullet formatting to the paragraphs in the range.
  /// </summary>
  /// <param name="bulletType">The type of bullet to apply.</param>
  public void ApplyBulletDefault(BulletStyleKind? bulletType = null);

  /// <summary>
  ///   Applies number formatting to the paragraphs in the range.
  /// </summary>
  /// <param name="numberType">The type of numbering to apply.</param>
  public void ApplyNumberDefault(NumberStyleKind? numberType = null);

  /// <summary>
  ///   Applies outline numbering to the paragraphs in the range.
  /// </summary>
  /// <param name="outlineScheme">The outline scheme to apply.</param>
  public void ApplyOutlineNumberDefault(OutlineNumberDefaultKind? outlineScheme = null);

  #endregion

  #region Remove List Formatting

  /// <summary>
  ///   Removes list formatting from the specified range.
  /// </summary>
  public void RemoveNumbers();

  /// <summary>
  ///   Removes numbers from the specified range but retains indentation.
  /// </summary>
  public void RemoveNumbersAndIndent();

  /// <summary>
  ///   Converts numbers to text in the range.
  /// </summary>
  /// <param name="numberType">Type of conversion to perform.</param>
  public void ConvertNumbersToText(NumberConversionKind? numberType = null);

  #endregion

  #region List Level Manipulation

  /// <summary>
  ///   Increases the list level by one.
  /// </summary>
  /// <remarks>
  ///   Indents the paragraph one level deeper in the list hierarchy.
  ///   Cannot increase beyond level 9.
  /// </remarks>
  public void IncreaseListIndent();

  /// <summary>
  ///   Decreases the list level by one.
  /// </summary>
  /// <remarks>
  ///   Outdents the paragraph one level higher in the list hierarchy.
  ///   Cannot decrease below level 1.
  /// </remarks>
  public void DecrementListIndent();

  #endregion

  #region List Numbering Control

  /// <summary>
  ///   Gets whether the specified paragraph can be outdented.
  /// </summary>
  public bool CanContinuePreviousList { get; }

  /// <summary>
  ///   Gets the count of list paragraphs from the beginning of the list
  ///   to the range specified.
  /// </summary>
  /// <param name="level">The list level to count.</param>
  /// <returns>The count of list paragraphs.</returns>
  public int CountNumberedItems(int level);

  #endregion

  #region Parent Properties

  /// <summary>
  ///   Gets the parent Range object.
  /// </summary>
  public Range? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}