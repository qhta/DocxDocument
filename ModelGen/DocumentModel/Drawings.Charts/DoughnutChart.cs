namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Doughnut Charts.
/// </summary>
public partial class DoughnutChart
{
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public UInt16? FirstSliceAngle { get; set; }
  
  public Byte? HoleSize { get; set; }
  
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
