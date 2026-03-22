namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the Command Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:command.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.Command))]
public class Command: ModelElement<DXO10CUI.Command>
{
  /// <summary>
  /// Specifies the callback invoked when the command action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Command.OnAction))]
  public String? OnAction { get => _OnAction; set => UpdateField(ref _OnAction, value, nameof(OnAction)); }
  private String? _OnAction;
  /// <summary>
  /// Specifies whether the command is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Command.Enabled))]
  public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }
  private Boolean? _Enabled;
  /// <summary>
  /// Specifies the callback that returns whether the command is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Command.GetEnabled))]
  public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }
  private String? _GetEnabled;
  /// <summary>
  /// Specifies the identifier of the built-in Office command.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Command.IdMso))]
  public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }
  private String? _IdMso;
}