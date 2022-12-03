namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public interface DisplayUnits // : DocumentModel.BaseTypes.ModelElement
{
  public Double? CustomDisplayUnit { get ; set; }
  
  public BuiltInUnitKind? BuiltInUnit { get ; set; }
  
  public DisplayUnitsLabel? DisplayUnitsLabel { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
