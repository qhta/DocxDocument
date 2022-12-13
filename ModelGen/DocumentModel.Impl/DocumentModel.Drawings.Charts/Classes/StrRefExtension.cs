namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public class StrRefExtensionImpl: ModelElementImpl, StrRefExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StrRefExtensionImpl(): base() {}
  
  public StrRefExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings13.Charts.FullReference? FullReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings13.Charts.LevelReference? LevelReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings13.Charts.FormulaReference? FormulaReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
