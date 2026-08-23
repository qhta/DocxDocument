namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a fixed command keyboard customization in a Wordprocessing document.
/// This class provides properties for the command name, command index, and argument, enabling configuration and management of keyboard shortcuts for fixed commands.
/// </summary>
[OpenXmlType(typeof(DXOW.FixedCommandKeyboardCustomization))]
[DataContract]
[XmlRoot("FixedCommandKeyboardCustomization", Namespace = "DocumentModel.Wordprocessing")]
public partial class FixedCommandKeyboardCustomization: ModelElement<DXOW.FixedCommandKeyboardCustomization>
{
  /// <summary>
  /// Name of the command associated with the keyboard customization.
  /// </summary>
  [OpenXmlProperty(nameof(DXOW.FixedCommandKeyboardCustomization.CommandName))]
  public string? CommandName
  {
    get => _CommandName ??= GetProperty<string?>(GetUpdatableElement()?.CommandName);
    set => UpdateField(ref _CommandName, value, nameof(CommandName));
  }

  private string? _CommandName;

  /// <summary>
  /// Index of the command, represented as a hexadecimal character.
  /// </summary>
  [OpenXmlProperty(nameof(DXOW.FixedCommandKeyboardCustomization.CommandIndex))]
  public HexChar? CommandIndex
  {
    get => _CommandIndex ??= GetProperty<HexChar?>(GetUpdatableElement()?.CommandIndex);
    set => UpdateField(ref _CommandIndex, value, nameof(CommandIndex));
  }

  private HexChar? _CommandIndex;

  /// <summary>
  /// Argument for the command, represented as a hexadecimal character.
  /// </summary>
  [OpenXmlProperty(nameof(DXOW.FixedCommandKeyboardCustomization.Argument))]
  public HexChar? Argument
  {
    get => _Argument ??= GetProperty<HexChar?>(GetUpdatableElement()?.Argument);
    set => UpdateField(ref _Argument, value, nameof(Argument));
  }

  private HexChar? _Argument;
}