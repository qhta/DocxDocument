namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents the columns layout in a section.
/// </summary>
public class Columns: ModelElement, ISectionPropertiesElement
{
  /// <summary>
  ///   Equal Column Widths
  /// </summary>
  public Boolean? EqualWidth { get; set; }

  /// <summary>
  ///   Spacing Between Equal Width Columns
  /// </summary>
  public Twips? Space { get; set; }

  /// <summary>
  ///   Number of Equal Width Columns
  /// </summary>
  public int? ColumnCount { get; set; }

  /// <summary>
  ///   Draw Line Between Columns
  /// </summary>
  public Boolean? Separator { get; set; }

  public Collection<Column>? Items { get; set; }
}