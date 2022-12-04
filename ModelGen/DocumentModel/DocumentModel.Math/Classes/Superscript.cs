namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public class Superscript
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public SuperscriptProperties? SuperscriptProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get;
    set;
  }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument
  {
    get;
    set;
  }
  
}
