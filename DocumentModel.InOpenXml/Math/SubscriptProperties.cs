namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the Subscript object.
/// </summary>
[OpenXmlType(typeof(DXM.SubscriptProperties))]
[XmlRoot("SubscriptProperties", Namespace = "DocumentModel.Math")]
public partial class SubscriptProperties : ModelElement<DXM.SubscriptProperties>
{
 /// <summary>
 ///   Specifies formatting of Subscript object argument.
 /// </summary>
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }
 private ControlProperties? _ControlProperties;
}