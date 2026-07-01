namespace DocumentModel.Wordprocessing.VBA;
/// <summary>
/// Represents a macro data structure (Mcd) for VBA in a Wordprocessing document.
/// This class provides properties for macro name, display name, menu help text, and encryption-related values, enabling storage and management of supplementary macro information for VBA-enabled documents.
/// </summary>
[OpenXmlType(typeof(DXOW.Mcd))]
[DataContract]
[XmlRoot("Mcd", Namespace = "DocumentModel.Wordprocessing.VBA")]
public class Mcd : ModelElement<DXOW.Mcd>
{
 /// <summary>
 /// The name of the macro associated with this data structure.
 /// </summary>
 [OpenXmlProperty(nameof(DXOW.Mcd.MacroName))]
 public string? MacroName { get => _MacroName; set => UpdateField(ref _MacroName, value, nameof(MacroName)); }
 private string? _MacroName;

 /// <summary>
 /// The display name for the macro or related item.
 /// </summary>
 [OpenXmlProperty(nameof(DXOW.Mcd.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;

 /// <summary>
 /// The help text displayed in the menu for this macro.
 /// </summary>
 [OpenXmlProperty(nameof(DXOW.Mcd.MenuHelp))]
 public string? MenuHelp { get => _MenuHelp; set => UpdateField(ref _MenuHelp, value, nameof(MenuHelp)); }
 private string? _MenuHelp;

 /// <summary>
 /// The encryption value for the macro, stored as a hexadecimal character.
 /// </summary>
 [OpenXmlProperty(nameof(DXOW.Mcd.BEncrypt))]
 public HexChar? BEncrypt { get => _BEncrypt; set => UpdateField(ref _BEncrypt, value, nameof(BEncrypt)); }
 private HexChar? _BEncrypt;

 /// <summary>
 /// The CMG (Code Management Group) value for the macro, stored as a hexadecimal character.
 /// </summary>
 [OpenXmlProperty(nameof(DXOW.Mcd.Cmg))]
 public HexChar? Cmg { get => _Cmg; set => UpdateField(ref _Cmg, value, nameof(Cmg)); }
 private HexChar? _Cmg;
}