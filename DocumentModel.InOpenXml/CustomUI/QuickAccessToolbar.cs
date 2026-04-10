namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the QuickAccessToolbar Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:qat.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems"/> <c>&lt;mso14:sharedControls&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems"/> <c>&lt;mso14:documentControls&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.QuickAccessToolbar))]
[XmlRoot("QuickAccessToolbar", Namespace = "DocumentModel.CustomUI")]
public class QuickAccessToolbar : ModelElement<DXO10CUI.QuickAccessToolbar>
{
 /// <summary>
 /// Specifies the shared controls qat items.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.QuickAccessToolbar.SharedControlsQatItems))]
 public SharedControlsQatItems? SharedControlsQatItems { get => _SharedControlsQatItems; set => UpdateField(ref _SharedControlsQatItems, value, nameof(SharedControlsQatItems)); }

 private SharedControlsQatItems? _SharedControlsQatItems;
 /// <summary>
 /// Specifies the document controls qat items.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.QuickAccessToolbar.DocumentControlsQatItems))]
 public DocumentControlsQatItems? DocumentControlsQatItems { get => _DocumentControlsQatItems; set => UpdateField(ref _DocumentControlsQatItems, value, nameof(DocumentControlsQatItems)); }

 private DocumentControlsQatItems? _DocumentControlsQatItems;
}