namespace DocumentModel.Math;

/// <summary>
///   This element specifies the delimiter object, consisting of opening and closing delimiters 
///   (such as parentheses, braces, brackets, and vertical bars), and an element contained inside. 
///   The delimiter may have more than one element, with a designated separator character between each element. 
/// </summary>
public class Delimiter: ElementCollection<Argument>, ICommonMathContent
{
  /// <summary>
  ///   Specifies Delimiter object properties.
  /// </summary>
  public DelimiterProperties? DelimiterProperties { get; set; }

}