namespace DocumentModel.Math;

/// <summary>
///   Radical Function.
/// </summary>
public class Radical: DMW.ParagraphElement
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
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}