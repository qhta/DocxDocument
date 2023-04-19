namespace DocumentModel.Math;

/// <summary>
///   This element specifies the radical object, consisting of a radical, a base e and an optional degree deg.
/// </summary>
public class Radical: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Radical Properties.
  /// </summary>
  public RadicalProperties? RadicalProperties { get; set; }

  /// <summary>
  ///   Degree.
  /// </summary>
  public Degree? Degree { get; set; }

  /// <summary>
  ///   Base argument.
  /// </summary>
  public Argument? Base { get; set; }
}