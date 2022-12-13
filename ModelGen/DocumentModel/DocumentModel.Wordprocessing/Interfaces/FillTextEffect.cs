namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public interface FillTextEffect
{
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public Boolean? NoFillEmpty { get ; set; }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.SolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.GradientFillProperties? GradientFillProperties { get ; set; }
  
}
