namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ApplicationNonVisualDrawingPropertiesExtension Class.
/// </summary>
public interface IApplicationNonVisualDrawingPropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.PowerPoint.IMedia? Media { get ; set; }
  
  public System.UInt32? ModificationId { get ; set; }
  
}
