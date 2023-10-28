namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DisplayUnits Class.
/// </summary>
public partial class DisplayUnits
{
  public DMDC.CustomDisplayUnit? CustomDisplayUnit { get; set; }
  
  public DMDC.BuiltInUnitKind? BuiltInUnit { get; set; }
  
  public DMDC.DisplayUnitsLabel? DisplayUnitsLabel { get; set; }
  
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
