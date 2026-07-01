namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the Tabs Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:tabs.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Tab"/> <c>&lt;mso14:tab&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.Tabs))]
[DataContract]
[XmlRoot("Tabs", Namespace = "DocumentModel.CustomUI")]
public class Tabs : ModelElement<DXO10CUI.Tabs>
{
}