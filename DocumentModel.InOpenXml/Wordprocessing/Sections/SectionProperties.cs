namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the section properties for a section of the document.
/// If it occurs as the last body element, then it specifies the properties of the last section of the document.
/// For any other section the properties are stored as a child element of the paragraph element corresponding to the last paragraph in the given section.
/// </summary>
[OpenXmlType(typeof(DXW.SectionProperties))]
public partial class SectionProperties: BaseSectionProperties<DXW.SectionProperties>
{
  /// <summary>
  /// Collection of header references associated with the current instance.
  /// </summary>
  [OpenXmlElementCollection(typeof(DXW.HeaderReference))]
  public HeaderReferences? HeaderReferences
  {
    get => _HeaderReferences;
    set => UpdateField(ref _HeaderReferences, value, nameof(HeaderReferences));
  }

  private HeaderReferences? _HeaderReferences;

  /// <summary>
  /// Collection of header references associated with the current instance.
  /// </summary>
  [OpenXmlElementCollection(typeof(DXW.FooterReference))]
  public FooterReferences? FooterReferences
  {
    get => _FooterReferences;
    set => UpdateField(ref _FooterReferences, value, nameof(FooterReferences));
  }

  private FooterReferences? _FooterReferences;

  /// <summary>
  /// Change information for the section properties.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SectionPropertiesChange))]
  public SectionPropertiesChange? SectionPropertiesChange
  {
    get => _SectionPropertiesChange;
    set => UpdateField(ref _SectionPropertiesChange, value, nameof(SectionPropertiesChange));
  }

  private SectionPropertiesChange? _SectionPropertiesChange;
}