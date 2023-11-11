namespace DocumentModel;

/// <summary>
/// This class represents a collection stored in a HyperlinkList extended document property.
/// Although in OpenXml this property is of Variant type, it must be converted to this class to enable proper serialization.
/// </summary>
public class HyperlinkList : Collection<HyperlinkInfo>
{

}