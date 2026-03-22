namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the DialogBoxLauncher Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:dialogBoxLauncher.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular"/> <c>&lt;mso14:button&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.DialogBoxLauncher))]
public class DialogBoxLauncher: ModelElement<DXO10CUI.DialogBoxLauncher>
{
  /// <summary>
  /// Specifies the button displayed in the dialog box launcher area.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.DialogBoxLauncher.ButtonRegular))]
  public ButtonRegular? ButtonRegular
  {
    get => _ButtonRegular;
    set => UpdateField(ref _ButtonRegular, value, nameof(ButtonRegular));
  }
  private ButtonRegular? _ButtonRegular;
}