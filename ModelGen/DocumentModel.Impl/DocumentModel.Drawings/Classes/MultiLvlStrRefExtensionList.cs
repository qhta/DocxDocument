namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public class MultiLvlStrRefExtensionListImpl: ModelElementImpl, MultiLvlStrRefExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<MultiLvlStrRefExtension>? MultiLvlStrRefExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
