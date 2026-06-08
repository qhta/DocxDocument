namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents the columns layout in a section.
/// </summary>
public class IColumns: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   Equal IColumn Widths
  /// </summary>
  public bool? EqualWidth { get; set; }

  /// <summary>
  ///   Spacing Between Equal Width IColumns
  /// </summary>
  public Twips? Space { get; set; }

  /// <summary>
  ///   Number of Equal Width IColumns
  /// </summary>
  public int? ColumnCount { get; set; }

  /// <summary>
  ///   Draw ILine Between IColumns
  /// </summary>
  public bool? Separator { get; set; }

  public Collection<IColumn>? Items { get; set; }
}
