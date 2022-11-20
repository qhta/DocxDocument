namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Run Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunPropertiesBaseStyle))]
public interface IRunPropertiesDefault // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IRunPropertiesBaseStyle? RunPropertiesBaseStyle { get ; set; }
  
}
