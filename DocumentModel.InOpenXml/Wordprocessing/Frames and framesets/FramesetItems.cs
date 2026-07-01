namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of frames and framesets in a WordprocessingML document.
/// This class provides access to and management of <see cref = "IFramesetItem"/> objects, enabling advanced configuration and organization of nested frames and framesets within document layouts.
/// </summary>
[OpenXmlType(typeof(IFramesetItem))]
[DataContract]
[XmlRoot("FramesetItems", Namespace = "DocumentModel.Wordprocessing")]
public class FramesetItems : ElementCollection<IFramesetItem>
{
}