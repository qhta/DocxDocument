namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the BackstageGroups Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:firstColumn.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup"/> <c>&lt;mso14:group&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup"/> <c>&lt;mso14:taskFormGroup&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup"/> <c>&lt;mso14:taskGroup&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.BackstageGroups))]
[DataContract]
[XmlRoot("BackstageGroups", Namespace = "DocumentModel.CustomUI")]
public class BackstageGroups : ModelElement<DXO10CUI.BackstageGroups>
{
}