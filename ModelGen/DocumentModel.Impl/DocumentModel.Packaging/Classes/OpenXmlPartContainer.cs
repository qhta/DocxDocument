namespace DocumentModel.Packaging;

/// <summary>
/// Defines the base class for OpenXmlPackage and OpenXmlPart.
/// </summary>
public class OpenXmlPartContainerImpl: ModelObjectImpl, OpenXmlPartContainer
{
  public DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlPartContainerImpl(): base() {}
  
  public OpenXmlPartContainerImpl(DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets all external relationships.
  /// </summary>
  public ReferenceRelationship? ExternalRelationships
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets all hyperlink relationships.
  /// </summary>
  public HyperlinkRelationship? HyperlinkRelationships
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets all  relationships.
  /// </summary>
  public ReferenceRelationship? DataPartReferenceRelationships
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets all parts which are relationship targets of this part.
  /// </summary>
  public IdPartPair? Parts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
