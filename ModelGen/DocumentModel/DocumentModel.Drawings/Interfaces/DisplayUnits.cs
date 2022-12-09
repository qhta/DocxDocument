namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public interface DisplayUnits
{
  public Double? CustomDisplayUnit { get ; set; }
  
  public BuiltInUnitKind? BuiltInUnit { get ; set; }
  
  public DisplayUnitsLabel? DisplayUnitsLabel { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
