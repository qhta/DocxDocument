namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Doughnut Charts.
/// </summary>
public partial class DoughnutChart
{
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public UInt16? FirstSliceAngle { get; set; }
  
  public Byte? HoleSize { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
