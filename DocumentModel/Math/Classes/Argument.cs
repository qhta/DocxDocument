namespace DocumentModel.Math;

/// <summary>
///   This element serves several functions (18 total) including Ithat of the base argument 
///   of a mathematical object or function, the elements Iin an array, and the elements Iin boxes. 
///   If all subelements are omitted, this element specifies the presence of an empty argument. 
/// </summary>
public class Argument: ElementCollection<IMathArgumentContent>
{

  /// <summary>
  /// Specifies properties of the base argument.
  /// </summary>
  public ArgumentProperties? ArgumentProperties { get; set; }

  /// <summary>
  /// Specifies formatting of base argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }

}
