using DocumentFormat.OpenXml;

namespace DocumentModel.Wordprocessing;
public partial class AttachedSchema : ModelElement<DXW.AttachedSchema>
{
    [OpenXmlLoadData(nameof(LoadUriFromOpenXml))]
    [OpenXmlUpdateData(nameof(UpdateUriInOpenXml))]
    [OpenXmlElement(typeof(DXW.AttachedSchema))]
    public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

    private string? _Uri;
    /// <summary>
    /// Updates the URI value of the specified Open XML element if it is an attached schema element.
    /// </summary>
    /// <remarks>If the URI is null or the provided element is not a DXW.AttachedSchema, this method performs no
    /// action.</remarks>
    /// <param name = "openXmlElement">The Open XML element to update. If the element is of type DXW.AttachedSchema, its Val property is set to the
    /// current URI value.</param>
    public void UpdateUriInOpenXml(object openXmlElement)
    {
        if (Uri == null)
            return;
        if (openXmlElement is DXW.AttachedSchema attachedSchemaElement)
            attachedSchemaElement.Val = new StringValue(Uri);
    }

    /// <summary>
    /// Loads the URI associated with the current relationship from the specified Open XML element.
    /// </summary>
    /// <remarks>This method updates the <c>Uri</c> property if a matching external relationship is found in the
    /// main document part of the underlying WordprocessingDocument. If the document or relationship is not found, the
    /// <c>Uri</c> property remains unchanged.</remarks>
    /// <param name = "openXmlElement">The Open XML element from which to load the relationship URI. This parameter is not validated and is used as a
    /// context for the operation.</param>
    public void LoadUriFromOpenXml(object openXmlElement)
    {
        if (openXmlElement is not DXW.AttachedSchema attachedSchemaElement)
            throw new InvalidOperationException($"AttachedSchema expected to in {nameof(LoadUriFromOpenXml)}");
        Uri = attachedSchemaElement.Val?.Value;
    }
}