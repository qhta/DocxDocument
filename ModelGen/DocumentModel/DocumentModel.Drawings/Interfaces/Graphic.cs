namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Object.
/// </summary>
public interface Graphic // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  public GraphicData? GraphicData { get ; set; }
  
}
