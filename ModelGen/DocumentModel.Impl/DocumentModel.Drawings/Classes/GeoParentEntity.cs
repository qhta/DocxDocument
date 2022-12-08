namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public class GeoParentEntityImpl: ModelElementImpl, GeoParentEntity
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId
  {
    get;
    set;
  }
  
}
