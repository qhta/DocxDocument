namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the Commands Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:commands.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Command"/> <c>&lt;mso14:command&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.Commands))]
[XmlRoot("Commands", Namespace = "DocumentModel.CustomUI")]
public class Commands : ModelElement<DXO10CUI.Commands>
{
}