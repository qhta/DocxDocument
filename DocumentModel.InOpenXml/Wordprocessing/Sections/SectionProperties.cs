namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the section properties for a section of the document.
/// If it occurs as the last body element, then it specifies the properties of the last section of the document.
/// For any other section the properties are stored as a child element of the paragraph element corresponding to the last paragraph in the given section.
/// </summary>
public partial class SectionProperties : BaseSectionProperties<DXW.SectionProperties>, IStoryContent
{
  /// <summary>
  /// Collection of header references associated with the current instance.
  /// </summary>
  public HeaderReferences? HeaderReferences { get; set; }
  /// <summary>
  /// Collection of header references associated with the current instance.
  /// </summary>
  public FooterReferences? FooterReferences { get; set; }
  /// <summary>
  /// Change information for the section properties.
  /// </summary>
  public SectionPropertiesChange? SectionPropertiesChange { get; set; }
}