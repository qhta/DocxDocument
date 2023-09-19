namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the outline style to be applied to text. By default, text does not have outline.
/// </summary>
public partial class TextOutlineEffect
{
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:w")]
  public Int32? LineWidth { get; set; }
  
  
  /// <summary>
  ///   cap, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:cap")]
  public DocumentModel.Wordprocessing.LineCapValues? CapType { get; set; }
  
  
  /// <summary>
  ///   cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:cmpd")]
  public DocumentModel.Wordprocessing.CompoundLineValues? Compound { get; set; }
  
  
  /// <summary>
  ///   algn, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:algn")]
  public DocumentModel.Wordprocessing.PenAlignmentValues? Alignment { get; set; }
  
  public Boolean? NoFillEmpty { get; set; }
  
  public DocumentModel.Wordprocessing.SolidColorFillProperties? SolidColorFillProperties { get; set; }
  
  public DocumentModel.Wordprocessing.GradientFillProperties? GradientFillProperties { get; set; }
  
  public DocumentModel.Wordprocessing.PresetLineDashValues? PresetLineDashProperties { get; set; }
  
  public Boolean? RoundEmpty { get; set; }
  
  public Boolean? BevelEmpty { get; set; }
  
  public DocumentModel.Wordprocessing.LineJoinMiterProperties? LineJoinMiterProperties { get; set; }
  
}
