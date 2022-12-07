namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public class FillTextEffectImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>, FillTextEffect
{
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public SolidColorFillProperties? SolidColorFillProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public GradientFillProperties? GradientFillProperties
  {
    get;
    set;
  }
  
}
