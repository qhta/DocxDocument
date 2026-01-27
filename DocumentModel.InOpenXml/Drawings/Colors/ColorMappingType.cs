namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the color mapping type for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorMappingType))]
public partial class ColorMappingType : DMD.ColorMap<DXD.ColorMappingType>, IExtendableElement
{
  /// <summary>
  /// FontName.
  /// </summary>
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

  private string? _Name;
  [OpenXmlProperty(nameof(DXD.ColorMappingType.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}