namespace DocumentModel.Math;

/// <summary>
///   Border-Box Function.
/// </summary>
public class BorderBox: DMW.IParagraphElement
{
  /// <summary>
  ///   Border Box Properties.
  /// </summary>
  public BorderBoxProperties? BorderBoxProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}