namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public interface BorderBox // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public BorderBoxProperties? BorderBoxProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base { get ; set; }
  
}
