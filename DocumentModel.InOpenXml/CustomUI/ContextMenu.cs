namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the ContextMenu Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:contextMenu.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox"/> <c>&lt;mso14:checkBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular"/> <c>&lt;mso14:control&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular"/> <c>&lt;mso14:dynamicMenu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular"/> <c>&lt;mso14:gallery&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular"/> <c>&lt;mso14:menu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle"/> <c>&lt;mso14:menuSeparator&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular"/> <c>&lt;mso14:splitButton&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular"/> <c>&lt;mso14:toggleButton&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.ContextMenu))]
[XmlRoot("ContextMenu", Namespace = "DocumentModel.CustomUI")]
public class ContextMenu : ModelElement<DXO10CUI.ContextMenu>
{
 /// <summary>
 /// Specifies the identifier of the built-in Office context menu.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.ContextMenu.IdMso))]
 public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }

 private String? _IdMso;
}