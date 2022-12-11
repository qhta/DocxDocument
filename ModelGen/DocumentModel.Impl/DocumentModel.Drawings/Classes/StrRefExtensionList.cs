namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public class StrRefExtensionListImpl: ModelElementImpl, StrRefExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StrRefExtensionListImpl(): base() {}
  
  public StrRefExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<StrRefExtension>? StrRefExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
