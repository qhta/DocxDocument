namespace DocumentModel.Math;

/// <summary>
/// Accent.
/// </summary>
public class AccentImpl: ModelElement<DocumentFormat.OpenXml.Math.Accent>, Accent
{
  /// <summary>
  /// Accent Properties.
  /// </summary>
  public AccentProperties? AccentProperties
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
