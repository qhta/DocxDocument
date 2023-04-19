namespace DocumentModel.Math;

/// <summary>
///   This element specifies the box object, which is used to group components of an equation or other instance of mathematical text. 
///   A boxed object can (for example) serve as an operator emulator with or without an alignment point, 
///   serve as a line break point, have associated argSz, or be grouped such as not to allow line breaks within. 
///   If boxPr is omitted, all properties will be “false” by default.
/// </summary>
public class Box: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Specifies properties of box object.
  /// </summary>
  public BoxProperties? BoxProperties { get; set; }

  /// <summary>
  ///   Specifies argument of box object.
  /// </summary>
  public Argument? Argument { get; set; }
}