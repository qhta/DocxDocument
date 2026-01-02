namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FillTextEffect Class.
/// </summary>
public class FillTextEffect: ModelElement
{
  /// <summary>
  ///   NoFillEmpty.
  /// </summary>
  public bool? NoFillEmpty { get; set; }
  /// <summary>
  ///   SolidColorFillProperties.
  /// </summary>
  public SolidColorFillProperties? SolidColorFillProperties { get; set; }
  /// <summary>
  ///   GradientFillProperties.
  /// </summary>
  public GradientFillProperties? GradientFillProperties { get; set; }
}