namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumRefExtension Class.
/// </summary>
public class NumRefExtensionImpl: ModelElementImpl, NumRefExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumRefExtensionImpl(): base() {}
  
  public NumRefExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public FullReference? FullReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LevelReference? LevelReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public FormulaReference? FormulaReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
