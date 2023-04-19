namespace DocumentModel.Math;

/// <summary>
///   This element specifies the border-box object, consisting of a border drawn around an instance of mathematical text 
///   (such as a formula or equation). If borderBoxPr is omitted then the default behavior of borderBox is a rectangular border 
/// </summary>
public class BorderBox: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Specifies properties of border-box object.
  /// </summary>
  public BorderBoxProperties? BorderBoxProperties { get; set; }

  /// <summary>
  ///   Specifies argument of border-box object.
  /// </summary>
  public Argument? Argument { get; set; }
}