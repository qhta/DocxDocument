namespace DocumentModel.Presentation;

/// <summary>
/// Custom Show.
/// </summary>
public interface ICustomShow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Custom Show Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Custom Show ID
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// List of Presentation Slides.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SlideList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
