using DocumentFormat.OpenXml;

using DocumentModel.Packaging;

namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents an external file relationship in a WordprocessingML document, providing logic for managing and synchronizing external file URIs and relationship IDs with the Open XML package.
///   This abstract base class supports loading and updating relationship data for external resources such as templates, images, or other linked files.
/// </summary>
[OpenXmlType(typeof(DXW.RelationshipType))]
[DataContract]
[XmlRoot("ExternalFile", Namespace = "DocumentModel.Wordprocessing")]
//[OpenXmlUpdateData(nameof(ModelElement.UpdateData))]
public abstract partial class ExternalFile<T> : RelationshipType<DXW.RelationshipType>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref = "ExternalFile{T}"/> class with default values.
  /// </summary>
  protected ExternalFile()
  {
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref = "ExternalFile{T}"/> class with the specified URI.
  /// </summary>
  /// <param name = "uri">The URI of the external file, or null if the file does not have an associated URI.</param>
  protected ExternalFile(string? uri)
  {
    Uri = uri;
  }

  /// <summary>
  ///   Updates the internal data by loading information from the specified Open XML element.
  ///   If the associated document is not available, no update is performed.
  /// </summary>
  /// <param name = "openXmlObject">The Open XML element from which to load data. Must represent a valid Open XML element associated with a document.</param>
  public override bool UpdateData(object openXmlObject)
  {
    if (WordprocessingDocument != null)
      return UpdateData(WordprocessingDocument);

    return false;
  }

  /// <summary>
  ///   Loads data from the specified document into the current instance, updating the relationship ID and URI if available.
  ///   If the relevant relationship is not present, the properties remain unchanged.
  /// </summary>
  /// <param name = "document">The document from which to load data.</param>
  public override bool LoadData(DXPP.WordprocessingDocument document)
  {
    DXW.RelationshipType? updatedElement = (DXW.RelationshipType?)GetUpdatableElement();
    if (updatedElement != null)
    {
      Id = updatedElement.Id;
      Uri? relUri = updatedElement.GetType().GetProperty("Uri")?.GetValue(updatedElement) as Uri;
      if (relUri != null)
      {
        Uri = relUri.ToString();
      }
      return true;
    }
    return false;
  }

  /// <summary>
  ///   Updates the specified document with the current relationship ID and URI values.
  ///   Sets the ID property and, if specified, the URI property on the relationship element within the provided document.
  /// </summary>
  /// <param name = "document">The document to update with new relationship data. Cannot be null.</param>
  public override bool UpdateData(DXPP.WordprocessingDocument document)
  {
    DXW.RelationshipType? updatedElement = (DXW.RelationshipType?)GetUpdatableElement();
    if (updatedElement != null)
    {
      updatedElement.Id = Id;
      if (!string.IsNullOrEmpty(Uri))
      {
        updatedElement.GetType().GetProperty("Uri")?.SetValue(updatedElement, new Uri(Uri));
      }
      return true;
    }
    return false;
  }

  /// <summary>
  ///   The URI string of the relationship target (external resource).
  /// </summary>
  [OpenXmlLoadData(nameof(LoadUriFromOpenXml))]
  [OpenXmlUpdateData(nameof(UpdateUriInOpenXml))]
  public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }
  private string? _Uri;

  /// <summary>
  ///   Updates the external relationship in the document to point to the current URI and stores the new relationship ID.
  ///   Removes any old relationship with the same ID before adding the new one.
  /// </summary>
  /// <param name = "openXmlElement">The Open XML element context for the update operation.</param>
  public void UpdateUriInOpenXml(DX.OpenXmlElement openXmlElement)
  {
    if (Uri == null)
      return;
    var parentPart = openXmlElement.GetOpenXmlPart();
    if (parentPart == null)
      return;

    System.Uri.TryCreate(Uri, UriKind.Absolute, out var uri);
    if (!string.IsNullOrEmpty(Id))
    {
      var oldRel = parentPart.ExternalRelationships.FirstOrDefault(r => r.Id == Id);
      if (oldRel != null)
      {
        if (oldRel.Uri == uri)
          return; // No change needed if the URI is the same
        parentPart.DeleteExternalRelationship(oldRel.Id);
      }
    }
    if (uri != null)
    {
      if (String.IsNullOrEmpty(Id))
      {
        var rel = parentPart?.AddExternalRelationship(
          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate",
          uri);
        Id = rel?.Id;
      }
      else
        parentPart?.AddExternalRelationship(
          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate",
          uri, Id);
    }
  }

  /// <summary>
  ///   Loads the URI associated with the current relationship from the specified Open XML element.
  ///   Updates the <c>Uri</c> property if a matching external relationship is found in the main document part of the underlying document.
  ///   If the document or relationship is not found, the <c>Uri</c> property remains unchanged.
  /// </summary>
  /// <param name = "openXmlElement">The Open XML element from which to load the relationship URI. Used as a context for the operation.</param>
  public void LoadUriFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is not DX.OpenXmlElement element)
      throw new InvalidOperationException($"OpenXmlElement expected in {nameof(LoadUriFromOpenXml)}");
    var doc = element.GetWordprocessingDocument();
    if (doc == null)
      throw new InvalidOperationException($"No WordprocessingDocument is known for {element} of type {element.GetType()}");
    if (openXmlElement is DXW.RelationshipType relationshipType)
      Id = relationshipType.Id;
    else
      throw new InvalidOperationException($"OpenXmlElement is a {openXmlElement.GetType()} but not RelationshipType");
    if (Id == null)
      throw new InvalidOperationException($"No Id property in {element} of type {element.GetType()}");
    var openXmlPart = openXmlElement.GetOpenXmlPart();
    if (openXmlPart == null)
      openXmlPart = doc.MainDocumentPart;
    if (openXmlPart == null)
      throw new InvalidOperationException("No OpenXmlPart found for loading external relationship");
    var foundRel = openXmlPart.ExternalRelationships.FirstOrDefault(r => r.Id == Id);
    if (foundRel != null)
      Uri = foundRel.Uri?.ToString();
  }
}