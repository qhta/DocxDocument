namespace DocumentModel.WebExtensions;
/// <summary>
///   Defines the WebExtensionProperty Class.
/// </summary>
[OpenXmlType(typeof(DXO13WE.WebExtensionProperty))]
[XmlRoot("WebExtensionProperty", Namespace = "DocumentModel.WebExtensions")]
public class WebExtensionProperty : ModelElement<DXO13WE.WebExtensionProperty>
{
 /// <summary>
 /// Specifies the property name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionProperty.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 /// Specifies the property value.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionProperty.Value))]
 public string? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

 private string? _Value;
}