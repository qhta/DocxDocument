namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Run Properties.
/// </summary>
public class RunPropertiesDefaultImpl: ModelElementImpl, RunPropertiesDefault
{
  public DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public RunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
