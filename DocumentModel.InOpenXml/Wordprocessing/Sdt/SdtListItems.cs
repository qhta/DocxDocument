namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the collection of items for a drop-down list in a structured document tag (SDT).
/// This class provides access to and management of <see cref = "SdtListItem"/> elements, enabling advanced customization of drop-down list options.
/// </summary>
[OpenXmlType(typeof(SdtListItem))]
public class SdtListItems : ElementCollection<SdtListItem>
{
}