namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DLblExtension Class.
/// </summary>
public partial class DLblExtension
{
  
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DMDC13.DataLabelFieldTable? DataLabelFieldTable { get; set; }
  
  public DMDC13.ExceptionForSave? ExceptionForSave { get; set; }
  
  public DMDC13.ShowDataLabelsRange? ShowDataLabelsRange { get; set; }
  
  public DMDC13.ShapeProperties? ShapeProperties { get; set; }
  
  public DMDC13.Layout? Layout { get; set; }
  
}
