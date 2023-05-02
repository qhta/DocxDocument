using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   This element specifies the denominator of a fraction.
/// </summary>
public class Denominator: ElementCollection<IMathArgumentContent>
{
  /// <summary>
  ///   Specifies properties of argument object.
  /// </summary>
  public ArgumentProperties? ArgumentProperties { get; set; }

  /// <summary>
  ///   Specifies formatting of argument object.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}