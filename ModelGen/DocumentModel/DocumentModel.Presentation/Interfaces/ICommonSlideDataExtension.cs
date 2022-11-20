namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonSlideDataExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ICreationId))]
public interface ICommonSlideDataExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
