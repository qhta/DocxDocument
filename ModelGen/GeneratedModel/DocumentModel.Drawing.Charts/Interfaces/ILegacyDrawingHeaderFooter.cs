namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Legacy Drawing for Headers and Footers.
/// </summary>
public interface ILegacyDrawingHeaderFooter // : DocumentFormat.OpenXml.Drawing.Charts.RelationshipIdType
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public string? Id { get ; set; }
  
}
