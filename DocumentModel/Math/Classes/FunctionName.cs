using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   This element specifies the name of the function in the Function-Apply object func. 
///   For example, function names are sin and cos.
/// </summary>
public class FunctionName: ElementCollection<IMathArgumentContent>
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