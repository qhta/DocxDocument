namespace DocumentModel.Drawing.LegacyCompatibility;

/// <summary>
/// Legacy Drawing Object.
/// </summary>
public interface ILegacyDrawing // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public String? ShapeId { get ; set; }
  
}
