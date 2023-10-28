namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the fill for text. By default, this element is absent. When this element is absent, the color of text is determined by the color element.
/// </summary>
public partial class FillTextEffect
{
  
  /// <summary>
  ///   NoFillEmpty.
  /// </summary>
  public DMW10.NoFillEmpty? NoFillEmpty { get; set; }
  
  
  /// <summary>
  ///   SolidColorFillProperties.
  /// </summary>
  public DMW10.SolidColorFillProperties? SolidColorFillProperties { get; set; }
  
  
  /// <summary>
  ///   GradientFillProperties.
  /// </summary>
  public DMW10.GradientFillProperties? GradientFillProperties { get; set; }
  
}
