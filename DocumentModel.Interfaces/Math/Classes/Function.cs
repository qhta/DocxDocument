namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Function-Apply object, which consists of a function name and an argument element (e) acted upon. 
///   It is often applied using a form of linear format. 
/// </summary>
public class Function: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Function Properties.
  /// </summary>
  public FunctionProperties? FunctionProperties { get; set; }
  /// <summary>
  ///   Function Name.
  /// </summary>
  public FunctionName? FunctionName { get; set; }
  /// <summary>
  ///   Base (Argument).
  /// </summary>
  public Argument? Argument { get; set; }
}