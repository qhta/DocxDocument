namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a frameset definition in a WordprocessingML document.
/// This class extends <see cref = "ElementCollection{IFramesetItem}"/> and provides properties for advisory information, nested frameset size, splitter properties, and layout, enabling advanced configuration and management of frameset structures within documents.
/// </summary>
[OpenXmlType(typeof(ModelElement))]
[XmlRoot("Frameset", Namespace = "DocumentModel.Wordprocessing")]
public partial class Frameset : ModelElementCollection<ModelElement, DXW.Frameset, DX.OpenXmlElement>, IFramesetItem
{
 /// <summary>
 /// Advisory information about the frameset, typically used as a title or description.
 /// </summary>
 public String? Title { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Size of the nested frameset, specified as a width or height value depending on the frameset orientation.
 /// </summary>
 public UInt32? FrameSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Properties for the frameset splitter, enabling customization of the splitter appearance and behavior.
 /// </summary>
 public FramesetSplitbar? FramesetSplitbar { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Layout of the frameset, specifying how frames are arranged within the frameset.
 /// </summary>
 public FrameLayout? FrameLayout { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}