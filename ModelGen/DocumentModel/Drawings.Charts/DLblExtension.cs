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
  
  public DocumentModel.Drawings.Charts.DataLabelFieldTable? DataLabelFieldTable { get; set; }
  
  public DocumentModel.Drawings.Charts.ExceptionForSave? ExceptionForSave { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowDataLabelsRange? ShowDataLabelsRange { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
}
