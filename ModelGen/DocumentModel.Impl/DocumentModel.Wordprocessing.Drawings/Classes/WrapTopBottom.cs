namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
public class WrapTopBottomImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>, WrapTopBottom
{
  /// <summary>
  /// Wrapping Boundaries.
  /// </summary>
  public EffectExtent? EffectExtent
  {
    get;
    set;
  }
  
}
