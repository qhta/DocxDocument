namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ShowPropertiesExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ILaserColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IBrowseMode))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IShowMediaControls))]
public interface IShowPropertiesExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
