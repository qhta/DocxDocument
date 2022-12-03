namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ApplicationNonVisualDrawingPropertiesExtension Class.
/// </summary>
public interface ApplicationNonVisualDrawingPropertiesExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public Media? Media { get ; set; }
  
  public UInt32? ModificationId { get ; set; }
  
}
