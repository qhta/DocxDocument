namespace DocumentModel.Wordprocessing;

/// <summary>
///   Block-Level Structured Document Tag Content.
/// </summary>
[XmlObject]
public class SdtContentBlock: ElementCollection<ISdtBlockElement>, ICommonRunElement
{
}