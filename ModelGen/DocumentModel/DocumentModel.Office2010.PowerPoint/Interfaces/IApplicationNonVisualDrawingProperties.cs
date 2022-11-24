namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public interface IApplicationNonVisualDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Is a Photo Album
  /// </summary>
  public Boolean? IsPhoto { get ; set; }
  
  /// <summary>
  /// Is User Drawn
  /// </summary>
  public Boolean? UserDrawn { get ; set; }
  
  /// <summary>
  /// Placeholder Shape.
  /// </summary>
  public IPlaceholderShape? PlaceholderShape { get ; set; }
  
}
