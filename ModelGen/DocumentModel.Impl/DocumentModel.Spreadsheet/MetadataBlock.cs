namespace DocumentModel.Spreadsheet;

/// <summary>
/// Metadata Block.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMetadataRecord))]
public class MetadataBlock: IMetadataBlock
{
}
