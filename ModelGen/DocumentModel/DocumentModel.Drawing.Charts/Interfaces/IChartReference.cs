namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Reference to Chart Part.
/// </summary>
public interface IChartReference // : DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public string? Id { get ; set; }
  
}
