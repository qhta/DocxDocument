namespace DocumentModel.Math;

/// <summary>
/// Box Function.
/// </summary>
public class BoxImpl: ModelElement<DocumentFormat.OpenXml.Math.Box>, Box
{
  /// <summary>
  /// Box Properties.
  /// </summary>
  public BoxProperties? BoxProperties
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
  
}
