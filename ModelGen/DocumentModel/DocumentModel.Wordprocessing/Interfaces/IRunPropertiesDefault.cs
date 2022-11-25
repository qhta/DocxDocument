namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Run Properties.
/// </summary>
public interface IRunPropertiesDefault // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunPropertiesBaseStyle? RunPropertiesBaseStyle { get ; set; }
  
}
