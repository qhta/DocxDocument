namespace DocumentModel.Math;

/// <summary>
/// Bar.
/// </summary>
public class BarImpl: ModelElement<DocumentFormat.OpenXml.Math.Bar>, Bar
{
  /// <summary>
  /// Bar Properties.
  /// </summary>
  public BarProperties? BarProperties
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
