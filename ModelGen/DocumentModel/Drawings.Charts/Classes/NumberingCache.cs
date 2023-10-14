namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberingCache Class.
/// </summary>
public partial class NumberingCache
{
  public DocumentModel.Drawings.Charts.FormatCode? FormatCode { get; set; }
  
  public DocumentModel.Drawings.Charts.PointCount? PointCount { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
  public DM.ElementCollection<NumericPoint>? Items { get; set; }
  
}
