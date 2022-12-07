namespace DocumentModel.Drawings;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public class ExtraColorSchemeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>, ExtraColorScheme
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public ColorScheme? ColorScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  public ColorMap? ColorMap
  {
    get;
    set;
  }
  
}
