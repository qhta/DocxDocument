namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public class FillTextEffectImpl: ModelElementImpl, FillTextEffect
{
  public DocumentFormat.OpenXml.Office2010.Word.FillTextEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.FillTextEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public Boolean? NoFillEmpty
  {
    get;
    set;
  }
  
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
