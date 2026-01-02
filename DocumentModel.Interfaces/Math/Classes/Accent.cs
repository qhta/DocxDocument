namespace DocumentModel.Math;
/// <summary>
///   This element specifies the accent function, consisting of a base and a combining diacritical mark. 
///   If AccentProperties is omitted, the default accent is U+0302 (COMBINING CIRCUMFLEX ACCENT).
/// </summary>
public class Accent: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Specifies formatting properties of accent function.
  /// </summary>
  public AccentProperties? AccentProperties { get; set; }
  /// <summary>
  ///   Specifies the argument of accent function.
  /// </summary>
  public Argument? Argument { get; set; }
}