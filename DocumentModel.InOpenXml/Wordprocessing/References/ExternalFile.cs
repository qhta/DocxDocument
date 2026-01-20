using DocumentFormat.OpenXml;

namespace DocumentModel.Wordprocessing;

//[OpenXmlUpdateData(nameof(ModelElement.UpdateData))]
public abstract class ExternalFile<T> : RelationshipType<DXW.RelationshipType>
{

  internal DXPP.ReferenceRelationship? ReferenceRelationship { get; private set; }


  /// <summary>
  /// Default constructor.
  /// </summary>
  protected ExternalFile()
  {
  }

  /// <summary>
  /// Initializes a new instance of the ExternalFile class with the specified URI.
  /// </summary>
  /// <param name="uri">The URI of the external file, or null if the file does not have an associated URI.</param>
  protected ExternalFile(string? uri)
  {
    Uri = uri;
  }

  /// <summary>
  /// Updates the internal data by loading information from the specified Open XML element.
  /// </summary>
  /// <remarks>If the associated Document is not available, the method does not perform any
  /// update.</remarks>
  /// <param name="openXmlElement">The Open XML element from which to load data. This parameter must represent a valid Open XML element associated
  /// with a Document.</param>
  public override void UpdateData(object openXmlElement)
  {
    if (WordprocessingDocument != null)
      UpdateData(WordprocessingDocument);
  }

  /// <summary>
  /// Loads data from the specified Document into the current instance.
  /// </summary>
  /// <remarks>This method updates the Id and Uri properties based on the relationship information found in the
  /// provided document, if available. If the relevant relationship is not present, the properties remain
  /// unchanged.</remarks>
  /// <param name="document">The Document from which to load data.</param>
  public override void LoadData(DXPack.WordprocessingDocument document)
  {
    DXW.RelationshipType? updatedElement = (DXW.RelationshipType?)GetUpdatableOpenXmlElement();
    if (updatedElement != null)
    {
      Id = updatedElement.Id;
      Uri? relUri = updatedElement.GetType().GetProperty("Uri")?.GetValue(updatedElement) as Uri;
      if (relUri != null)
      {
        Uri = relUri.ToString();
      }
    }
  }

  /// <summary>
  /// Updates the specified Document with the current Id and Uri values.
  /// </summary>
  /// <remarks>This method sets the Id property and, if specified, the Uri property on the relationship element
  /// within the provided document. The document must contain a relationship element compatible with the update
  /// operation.</remarks>
  /// <param name="document">The Document to update with new relationship data. Cannot be null.</param>
  public override void UpdateData(DXPack.WordprocessingDocument document)
  {
    DXW.RelationshipType? updatedElement = (DXW.RelationshipType?)GetUpdatableOpenXmlElement();
    if (updatedElement != null)
    {
      updatedElement.Id = Id;
      if (!string.IsNullOrEmpty(Uri))
      {
        updatedElement.GetType().GetProperty("Uri")?.SetValue(updatedElement, new Uri(Uri));
      }
    }
  }

  /// <summary>
  /// Uri string of the relationship target.
  /// </summary>
  //[OpenXmlConvertFrom(nameof(GetTemplateUri))]
  [OpenXmlUpdateData(nameof(UpdateUriInOpenXml))]
  public string? Uri
  {
    get => _Uri;
    set => UpdateField(ref _Uri, value, nameof(Uri));
  }
  private string? _Uri;


  /// <summary>
  /// Sets the template relationship in the document and stores the relationship Id.
  /// </summary>
  public void UpdateUriInOpenXml(object OpenXmlElement)
  {
    if (Uri == null)
      return;

    var doc = WordprocessingDocument;
    if (doc == null)
      return;
    // Remove old relationship if present
    if (!string.IsNullOrEmpty(Id))
    {
      var oldRel = doc.MainDocumentPart?
        .ExternalRelationships
        .FirstOrDefault(r => r.Id == Id);
      if (oldRel != null)
        doc.MainDocumentPart?.DeleteExternalRelationship(oldRel.Id);
    }

    var rel = doc.MainDocumentPart?
      .AddExternalRelationship(
        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate",
        new Uri(Uri));

    Id = rel?.Id;
  }

  ///// <summary>
  ///// Gets the template URI from the document's relationships.
  ///// </summary>
  //public Uri? GetTemplateUri()
  //{
  //  DXW.RelationshipType? updatedElement = (DXW.RelationshipType?)GetUpdatableOpenXmlElement();
  //  if (updatedElement != null)
  //  {
  //    //if (doc == null || string.IsNullOrEmpty(Id))
  //    //  return null;

  //    //var rel = doc.MainDocumentPart?.ExternalRelationships.FirstOrDefault(r => r.Id == Id);

  //    return updatedElement.GetType().GetProperty("Uri")?.GetValue(updatedElement) as Uri;
  //  }
  //  return null;
  //}

  ///// <summary>
  ///// Sets the template relationship in the document and stores the relationship Id.
  ///// </summary>
  //public void UpdateUriInOpenXml(Uri uri)
  //{
  //  if (Uri==null)
  //    return;

  //  var doc = WordprocessingDocument;
  //  if (doc == null)
  //    return;
  //  // Remove old relationship if present
  //  if (!string.IsNullOrEmpty(Id))
  //  {
  //    var oldRel = doc.MainDocumentPart?
  //      .ExternalRelationships
  //      .FirstOrDefault(r => r.Id == Id);
  //    if (oldRel != null)
  //      doc.MainDocumentPart?.DeleteExternalRelationship(oldRel.Id);
  //  }

  //  var rel = doc.MainDocumentPart?
  //    .AddExternalRelationship(
  //      "http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate",
  //      new Uri(Uri));

  //  Id = rel?.Id;
  //}


  ///// <summary>
  ///// Sets the URI associated with the current instance.
  ///// </summary>
  ///// <remarks>If a WordprocessingDocument is attached, this method also updates the template URI within the
  ///// document.</remarks>
  ///// <param name="uri">The URI to associate with the instance. Cannot be null.</param>
  //public void SetUri(String uri)
  //{
  //  Uri = uri;
  //  if (WordprocessingDocument!=null)
  //  {
  //    UpdateUriInOpenXml(WordprocessingDocument);
  //  }
  //}
}