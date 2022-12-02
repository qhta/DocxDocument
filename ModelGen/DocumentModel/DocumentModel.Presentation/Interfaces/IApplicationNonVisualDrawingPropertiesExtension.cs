namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ApplicationNonVisualDrawingPropertiesExtension Class.
/// </summary>
public interface IApplicationNonVisualDrawingPropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IMedia? Media { get ; set; }
  
  public UInt32? ModificationId { get ; set; }
  
}
