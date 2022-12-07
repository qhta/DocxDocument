namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public class BorderBoxImpl: ModelElement<DocumentFormat.OpenXml.Math.BorderBox>, BorderBox
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public BorderBoxProperties? BorderBoxProperties
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
