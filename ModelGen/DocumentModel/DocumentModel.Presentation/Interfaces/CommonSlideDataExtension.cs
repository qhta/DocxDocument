namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonSlideDataExtension Class.
/// </summary>
public interface CommonSlideDataExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public UInt32? CreationId { get ; set; }
  
}
