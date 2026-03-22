using DocumentFormat.OpenXml;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents an attached XML schema reference in a WordprocessingML document, enabling association of custom XML schemas with the document for validation and data binding.
/// </summary>
[OpenXmlType(typeof(DXW.AttachedSchema))]
public partial class AttachedSchema : ModelElement<DXW.AttachedSchema>
{
  /// <summary>
  ///   The URI of the attached XML schema associated with the document.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadUriFromOpenXml))]
  [OpenXmlUpdateData(nameof(UpdateUriInOpenXml))]
  public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }
  private string? _Uri;
  /// <summary>
  /// Returns a string representation of the current object.
  /// </summary>
  /// <returns>A string that represents the URI associated with this instance.</returns>
  public override string? ToString()
  {
    return _Uri;
  }
  /// <summary>
  /// Implicitly converts an AttachedSchema instance to its URI string.
  /// </summary>
  /// <param name="attachedSchema">Schema instance to convert</param>
  public static implicit operator string(AttachedSchema attachedSchema) => attachedSchema.Uri!;
  /// <summary>
  /// Implicitly converts a URI string to an AttachedSchema instance.
  /// </summary>
  /// <param name="uri">URI string to convert</param>
  public static implicit operator AttachedSchema(string uri) => new AttachedSchema { Uri = uri };
  /// <summary>
  ///   Updates the URI value of the specified Open XML element if it is an attached schema element.
  ///   If the URI is null or the provided element is not a <c>DXW.AttachedSchema</c>, this method performs no action.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element to update. If the element is of type <c>DXW.AttachedSchema</c>, its <c>Val</c> property is set to the current URI value.</param>
  public void UpdateUriInOpenXml(object openXmlElement)
  {
    if (Uri == null)
      return;
    if (openXmlElement is DXW.AttachedSchema attachedSchemaElement)
      attachedSchemaElement.Val = new StringValue(Uri);
  }
  /// <summary>
  ///   Loads the URI associated with the current attached schema from the specified Open XML element.
  ///   Updates the <c>Uri</c> property if the element is a <c>DXW.AttachedSchema</c>.
  ///   If the element is not a <c>DXW.AttachedSchema</c>, an exception is thrown.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element from which to load the schema URI. Used as a context for the operation.</param>
  public void LoadUriFromOpenXml(object openXmlElement)
  {
    if (openXmlElement is not DXW.AttachedSchema attachedSchemaElement)
      throw new InvalidOperationException($"AttachedSchema expected to in {nameof(LoadUriFromOpenXml)}");
    Uri = attachedSchemaElement.Val?.Value;
  }
}
