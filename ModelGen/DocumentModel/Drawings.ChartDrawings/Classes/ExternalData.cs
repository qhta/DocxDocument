namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public partial class ExternalData
{
  
  /// <summary>
  ///   RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? AutoUpdate { get; set; }
  
}
