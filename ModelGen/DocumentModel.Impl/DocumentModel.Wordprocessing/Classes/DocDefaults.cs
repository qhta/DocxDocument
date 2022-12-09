namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
public class DocDefaultsImpl: ModelElementImpl, DocDefaults
{
  public DocumentFormat.OpenXml.Wordprocessing.DocDefaults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocDefaults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  public RunPropertiesDefault? RunPropertiesDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  public ParagraphPropertiesDefault? ParagraphPropertiesDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
