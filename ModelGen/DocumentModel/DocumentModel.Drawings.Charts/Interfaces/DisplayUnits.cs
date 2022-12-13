namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public interface DisplayUnits
{
  public Double? CustomDisplayUnit { get ; set; }
  
  public DocumentModel.Drawings.Charts.BuiltInUnitKind? BuiltInUnit { get ; set; }
  
  public DocumentModel.Drawings.Charts.DisplayUnitsLabel? DisplayUnitsLabel { get ; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
