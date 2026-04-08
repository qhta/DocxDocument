namespace DocumentModel.Drawings;
/// <summary>
///   Represents a font scheme, including its name and definitions for major and minor fonts.
/// </summary>
[OpenXmlType(typeof(DXD.FontScheme))]
public partial class FontScheme : ModelElement<DXD.FontScheme>, IExtendableElement
{
 /// <summary>
 ///   Name of the font scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontScheme.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;
 /// <summary>
 ///   Major font definition.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontScheme.MajorFont))]
 public MajorFont? MajorFont { get => _MajorFont; set => UpdateField(ref _MajorFont, value, nameof(MajorFont)); }
 private MajorFont? _MajorFont;
 /// <summary>
 ///   Minor font definition.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontScheme.MinorFont))]
 public MinorFont? MinorFont { get => _MinorFont; set => UpdateField(ref _MinorFont, value, nameof(MinorFont)); }
 private MinorFont? _MinorFont;
 /// <summary>
 /// List of extension properties for the font scheme, used for extensibility scenarios.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontScheme.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}