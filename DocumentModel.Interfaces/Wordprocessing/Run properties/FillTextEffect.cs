namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FillTextEffect Class.
/// </summary>
public interface FillTextEffect
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
  public DMWD.GradientFillProperties? GradientFillProperties { get; set; }
}