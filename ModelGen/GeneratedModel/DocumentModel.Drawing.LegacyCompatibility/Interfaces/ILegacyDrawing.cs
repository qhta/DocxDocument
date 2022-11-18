namespace DocumentModel.Drawing.LegacyCompatibility;

/// <summary>
/// Legacy Drawing Object.
/// </summary>
public interface ILegacyDrawing // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public string? ShapeId { get ; set; }
  
}
