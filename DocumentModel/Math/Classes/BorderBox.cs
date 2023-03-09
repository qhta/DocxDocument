namespace DocumentModel.Math;

/// <summary>
///   Border-Box Function.
/// </summary>
public class BorderBox: ICommonMathElement
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