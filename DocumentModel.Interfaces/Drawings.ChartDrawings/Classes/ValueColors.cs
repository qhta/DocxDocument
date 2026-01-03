namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the ValueColors Class.
/// </summary>
public interface ValueColors: IModelElement
{
  /// <summary>
  ///   MinColorSolidColorFillProperties.
  /// </summary>
  public SolidColorFillProperties? MinColorSolidColorFillProperties { get; set; }
  /// <summary>
  ///   MidColorSolidColorFillProperties.
  /// </summary>
  public SolidColorFillProperties? MidColorSolidColorFillProperties { get; set; }
  /// <summary>
  ///   MaxColorSolidColorFillProperties.
  /// </summary>
  public SolidColorFillProperties? MaxColorSolidColorFillProperties { get; set; }
}