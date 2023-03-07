namespace DocumentModel.Math;

/// <summary>
///   Bar.
/// </summary>
public class Bar: DMW.IParagraphElement
{
  /// <summary>
  ///   Bar Properties.
  /// </summary>
  public BarProperties? BarProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}