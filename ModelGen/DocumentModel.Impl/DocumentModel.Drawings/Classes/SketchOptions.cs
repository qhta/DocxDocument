namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public class SketchOptionsImpl: ModelElementImpl, SketchOptions
{
  public DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// InSketchMode.
  /// </summary>
  public Boolean? InSketchMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  public Boolean? ShowSketchButton
  {
    get;
    set;
  }
  
}
