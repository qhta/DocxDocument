namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public class PivotOptionsImpl: ModelElementImpl, PivotOptions
{
  public DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  public Boolean? DropZoneFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  public Boolean? DropZoneCategories
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  public Boolean? DropZoneData
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  public Boolean? DropZoneSeries
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  public Boolean? DropZonesVisible
  {
    get;
    set;
  }
  
}
