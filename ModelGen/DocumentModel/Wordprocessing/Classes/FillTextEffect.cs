namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the fill for text. By default, this element is absent. When this element is absent, the color of text is determined by the color element.
/// </summary>
public partial class FillTextEffect
{
  
  /// <summary>
  ///   NoFillEmpty.
  /// </summary>
  public Boolean? NoFillEmpty { get; set; }
  
  
  /// <summary>
  ///   SolidColorFillProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.SolidColorFillProperties? SolidColorFillProperties { get; set; }
  
  
  /// <summary>
  ///   GradientFillProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.GradientFillProperties? GradientFillProperties { get; set; }
  
}
