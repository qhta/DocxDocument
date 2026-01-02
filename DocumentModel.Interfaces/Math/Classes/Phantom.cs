namespace DocumentModel.Math;
/// <summary>
///   This element specifies the phantom object. This object has two primary uses: 
///   adding the spacing of the phantom base element e without displaying that base; 
///   and suppressing part of the glyph for spacing considerations.
/// </summary>
public class Phantom: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Phantom Properties.
  /// </summary>
  public PhantomProperties? PhantomProperties { get; set; }
  /// <summary>
  ///   Phantom object argument.
  /// </summary>
  public Argument? Argument { get; set; }
}