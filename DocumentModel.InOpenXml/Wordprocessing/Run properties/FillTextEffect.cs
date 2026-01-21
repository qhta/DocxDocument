namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the fill text effect for a text run, providing options for no fill, solid color fill, or gradient fill.
/// This interface enables advanced text fill formatting in WordprocessingML documents.
/// </summary>
public partial class FillTextEffect : ModelElement<DXO10W.FillTextEffect>
{
  /// <summary>
  /// Indicates that no fill is applied to the text.
  /// </summary>
  public bool? NoFillEmpty { get; set; }
  /// <summary>
  /// Solid color fill properties for the text, specifying a single color fill effect.
  /// </summary>
  public SolidColorFillProperties? SolidColorFillProperties { get; set; }
  /// <summary>
  /// Gradient fill properties for the text, specifying a gradient color fill effect.
  /// </summary>
  public DMWD.GradientFillProperties? GradientFillProperties { get; set; }
}