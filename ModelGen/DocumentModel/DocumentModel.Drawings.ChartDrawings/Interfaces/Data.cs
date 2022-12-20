namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Data Class.
/// </summary>
public partial interface Data
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.NumericDimension? NumericDimension { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.StringDimension? StringDimension { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
