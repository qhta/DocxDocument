namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the StringDimension Class.
/// </summary>
public partial class StringDimension
{
  
  /// <summary>
  ///   type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.StringDimensionType? Type { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.Formula? Formula { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.NfFormula? NfFormula { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
