namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the NumericDimension Class.
/// </summary>
public partial class NumericDimension
{
  
  /// <summary>
  ///   type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NumericDimensionType? Type { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.Formula? Formula { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.NfFormula? NfFormula { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
