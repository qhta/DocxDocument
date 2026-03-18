namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the Backstage Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:backstage.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab"/> <c>&lt;mso14:tab&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.Backstage))]
public class Backstage : ModelElement<DXO10CUI.Backstage>
{
 /// <summary>
 /// Specifies the callback invoked when the Backstage view is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Backstage.OnShow))]
 public String? OnShow { get => _OnShow; set => UpdateField(ref _OnShow, value, nameof(OnShow)); }

 private String? _OnShow;
 /// <summary>
 /// Specifies the callback invoked when the Backstage view is hidden.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Backstage.OnHide))]
 public String? OnHide { get => _OnHide; set => UpdateField(ref _OnHide, value, nameof(OnHide)); }

 private String? _OnHide;


}