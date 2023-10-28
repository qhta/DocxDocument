namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the outline style to be applied to text. By default, text does not have outline.
/// </summary>
public partial class TextOutlineEffect
{
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? LineWidth { get; set; }
  
  public DMW10.NoFillEmpty? NoFillEmpty { get; set; }
  
  public DMW10.SolidColorFillProperties? SolidColorFillProperties { get; set; }
  
  public DMW10.GradientFillProperties? GradientFillProperties { get; set; }
  
  public DMW10.PresetLineDashKind? PresetLineDashProperties { get; set; }
  
  public DMW10.RoundEmpty? RoundEmpty { get; set; }
  
  public DMW10.BevelEmpty? BevelEmpty { get; set; }
  
  public DMW10.LineJoinMiterProperties? LineJoinMiterProperties { get; set; }
  
}
