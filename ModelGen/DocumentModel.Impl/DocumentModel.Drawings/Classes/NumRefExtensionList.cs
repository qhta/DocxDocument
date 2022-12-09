namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public class NumRefExtensionListImpl: ModelElementImpl, NumRefExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<NumRefExtension>? NumRefExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
