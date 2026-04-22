namespace DocumentModel.Drawings;
/// <summary>
///   Defines the NonVisualGroupProperties class.
/// </summary>
[OpenXmlType(typeof(DXO13D.NonVisualGroupProperties))]
[XmlRoot("NonVisualGroupProperties", Namespace = "DocumentModel.Drawings")]
public partial class NonVisualGroupProperties : ModelElement<DXO13D.NonVisualGroupProperties>
{
 /// <summary>
 ///   isLegacyGroup
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.NonVisualGroupProperties.IsLegacyGroup))]
 public bool? IsLegacyGroup { get => _IsLegacyGroup; set => UpdateField(ref _IsLegacyGroup, value, nameof(IsLegacyGroup)); }
 private bool? _IsLegacyGroup;
}