namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FillTextEffect Class.
/// </summary>
public record FillTextEffect
{
  /// <summary>
  ///   NoFillEmpty.
  /// </summary>
  public Boolean? NoFillEmpty { get; set; }

  /// <summary>
  ///   SolidColorFillProperties.
  /// </summary>
  public SolidColorFillProperties? SolidColorFillProperties { get; set; }

  /// <summary>
  ///   GradientFillProperties.
  /// </summary>
  public GradientFillProperties? GradientFillProperties { get; set; }
}