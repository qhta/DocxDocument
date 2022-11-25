namespace DocumentModel.Presentation;

/// <summary>
/// Application Non-Visual Drawing Properties.
/// </summary>
public interface IApplicationNonVisualDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Is a Photo Album
  /// </summary>
  public System.Boolean? IsPhoto { get ; set; }
  
  /// <summary>
  /// Is User Drawn
  /// </summary>
  public System.Boolean? UserDrawn { get ; set; }
  
  /// <summary>
  /// Placeholder Shape.
  /// </summary>
  public DocumentModel.Presentation.IPlaceholderShape? PlaceholderShape { get ; set; }
  
}
