namespace DocumentModel.Packaging;

/// <summary>
/// Defines a reference relationship. A reference relationship can be internal or external.
/// </summary>
public partial class ReferenceRelationshipImpl: ModelObjectImpl, ReferenceRelationship
{
  public DocumentFormat.OpenXml.Packaging.ReferenceRelationship? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ReferenceRelationship?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ReferenceRelationshipImpl(): base() {}
  
  public ReferenceRelationshipImpl(DocumentFormat.OpenXml.Packaging.ReferenceRelationship openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  public virtual String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ReferenceRelationship).GetProperty("RelationshipType")?.SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets a value indicating whether the target of the relationship is Internal or External to the .
  /// </summary>
  public Boolean? IsExternal
  {
    get => (System.Boolean?)OpenXmlElement?.IsExternal;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ReferenceRelationship).GetProperty("IsExternal")?.SetValue(OpenXmlElement, (System.Boolean?)value);
    }
  }
  
  /// <summary>
  /// Gets the relationship ID.
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ReferenceRelationship).GetProperty("Id")?.SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the target URI of the relationship.
  /// </summary>
  public Uri? Uri
  {
    get => (System.Uri?)OpenXmlElement?.Uri;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ReferenceRelationship).GetProperty("Uri")?.SetValue(OpenXmlElement, (System.Uri?)value);
    }
  }
  
}
