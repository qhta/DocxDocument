namespace DocumentModel.Wordprocessing.VBA;
/// <summary>
/// Represents a macro WLL (Word Link Library) type for VBA in a Wordprocessing document.
/// This class provides a property for the macro name, enabling identification and management of macro WLL types in VBA-enabled documents.
/// </summary>
[OpenXmlType(typeof(DXOW.MacroWllType))]
[XmlRoot("MacroWllType", Namespace = "DocumentModel.Wordprocessing.VBA")]
public class MacroWllType : ModelElement<DXOW.MacroWllType>
{
 /// <summary>
 /// The name of the macro associated with this WLL type.
 /// </summary>
 [OpenXmlProperty(nameof(DXOW.MacroWllType.MacroName))]
 public string? MacroName { get => _MacroName; set => UpdateField(ref _MacroName, value, nameof(MacroName)); }

 private string? _MacroName;
}