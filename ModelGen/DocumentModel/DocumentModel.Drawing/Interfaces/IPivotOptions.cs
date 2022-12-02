namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public interface IPivotOptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  public System.Boolean? DropZoneFilter { get ; set; }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  public System.Boolean? DropZoneCategories { get ; set; }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  public System.Boolean? DropZoneData { get ; set; }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  public System.Boolean? DropZoneSeries { get ; set; }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  public System.Boolean? DropZonesVisible { get ; set; }
  
}
