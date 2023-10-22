namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the outline style to be applied to text. By default, text does not have outline.
/// </summary>
public partial class TextOutlineEffect
{
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? LineWidth { get; set; }
  
  public DocumentModel.Wordprocessing.NoFillEmpty? NoFillEmpty { get; set; }
  
  public DocumentModel.Wordprocessing.SolidColorFillProperties? SolidColorFillProperties { get; set; }
  
  public DocumentModel.Wordprocessing.GradientFillProperties? GradientFillProperties { get; set; }
  
  public DocumentModel.Wordprocessing.PresetLineDashKind? PresetLineDashProperties { get; set; }
  
  public DocumentModel.Wordprocessing.RoundEmpty? RoundEmpty { get; set; }
  
  public DocumentModel.Wordprocessing.BevelEmpty? BevelEmpty { get; set; }
  
  public DocumentModel.Wordprocessing.LineJoinMiterProperties? LineJoinMiterProperties { get; set; }
  
}
