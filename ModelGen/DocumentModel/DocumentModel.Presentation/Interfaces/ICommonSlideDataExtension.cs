namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonSlideDataExtension Class.
/// </summary>
public interface ICommonSlideDataExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public UInt32? CreationId { get ; set; }
  
}
