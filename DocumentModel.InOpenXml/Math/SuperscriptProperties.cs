namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the Superscript object.
/// </summary>
[OpenXmlType(typeof(DXM.SuperscriptProperties))]
[XmlRoot("SuperscriptProperties", Namespace = "DocumentModel.Math")]
public partial class SuperscriptProperties : ModelElement<DXM.SuperscriptProperties>
{
 /// <summary>
 ///   Specifies formatting of Superscript object argument.
 /// </summary>
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}