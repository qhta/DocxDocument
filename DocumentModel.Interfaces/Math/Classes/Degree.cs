using DocumentModel.Wordprocessing;
namespace DocumentModel.Math;
/// <summary>
///   This element specifies the degree in the mathematical radical. This element is optional. 
///   When omitted, the square root function, as in √x, is assumed.
/// </summary>
public class Degree: ElementCollection<IMathArgumentContent>
{
  /// <summary>
  /// Specifies properties of the degree argument.
  /// </summary>
  public ArgumentProperties? ArgumentProperties { get; set; }
  /// <summary>
  /// Specifies formatting of degree argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}