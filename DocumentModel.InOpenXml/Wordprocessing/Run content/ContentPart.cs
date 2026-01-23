namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a reference to XML content in a format not defined by ECMA-376, such as MathML, SMIL, or SVG.
/// This element enables the native use of other interchange formats by referencing a custom XML part within the document package. The relationship type must be http://purl.oclc.org/ooxml/officeDocument/relationships/customXml with TargetMode set to Internal. If the content type is not supported, applications should continue processing and may indicate that unknown content was not imported.
/// </summary>
public partial class ContentPart : ModelElement<DXW.ContentPart>, IRunContent, DMM.IMathArgumentContent
{
    /// <summary>
    /// Relationship ID to the specified custom XML part, identifying the target part containing the referenced content.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.ContentPart.Id))]
    /// <summary>
    /// Relationship ID to the specified custom XML part, identifying the target part containing the referenced content.
    /// </summary>
    [OpenXmlElement(typeof(DXW.ContentPart))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
}