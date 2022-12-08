namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public class VbaDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, VbaDataPart
{
  public new DocumentFormat.OpenXml.Packaging.VbaDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VbaDataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.VbaSuppData? VbaSuppData
  {
    get;
    set;
  }
  
}
