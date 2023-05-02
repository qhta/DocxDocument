namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DisplayUnits Class.
/// </summary>
public class DisplayUnits: ModelElement
{
  public Double? CustomDisplayUnit { get; set; }

  public BuiltInUnitKind? BuiltInUnit { get; set; }

  public DisplayUnitsLabel? DisplayUnitsLabel { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}