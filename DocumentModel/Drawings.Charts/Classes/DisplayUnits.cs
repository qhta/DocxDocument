namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DisplayUnits Class.
/// </summary>
public class DisplayUnits
{
  public Double? CustomDisplayUnit { get; set; }

  public BuiltInUnitKind? BuiltInUnit { get; set; }

  public DisplayUnitsLabel? DisplayUnitsLabel { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}