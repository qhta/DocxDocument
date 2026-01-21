using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;
/// <summary>
///   This element specifies the numerator of the Fraction object f. 
/// </summary>
public partial class Numerator : OfficeMathArgumentType<DXM.Numerator>
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