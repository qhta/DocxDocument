namespace DocumentModel.Math;

/// <summary>
///   This element specifies the Group-Character object, consisting of a character drawn above or below text, 
///   often with the purpose of visually grouping items.
/// </summary>
public class GroupChar: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Group-Character Properties.
  /// </summary>
  public GroupCharProperties? GroupCharProperties { get; set; }

  /// <summary>
  ///   Arugment of the group-character object.
  /// </summary>
  public Argument? Argument { get; set; }
}