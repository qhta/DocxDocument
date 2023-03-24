namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ValueColors Class.
/// </summary>
public class ValueColors: ModelElement
{
  /// <summary>
  ///   MinColorSolidColorFillProperties.
  /// </summary>
  public MinColorSolidColorFillProperties? MinColorSolidColorFillProperties { get; set; }

  /// <summary>
  ///   MidColorSolidColorFillProperties.
  /// </summary>
  public MidColorSolidColorFillProperties? MidColorSolidColorFillProperties { get; set; }

  /// <summary>
  ///   MaxColorSolidColorFillProperties.
  /// </summary>
  public MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties { get; set; }
}