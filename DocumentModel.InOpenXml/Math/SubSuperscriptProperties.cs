namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the Sub-Superscript object, including the alignment of scripts.
/// </summary>
[OpenXmlType(typeof(DXM.SubSuperscriptProperties))]
[DataContract]
[XmlRoot("SubSuperscriptProperties", Namespace = "DocumentModel.Math")]
public partial class SubSuperscriptProperties : ModelElement<DXM.SubSuperscriptProperties>
{
  /// <summary>
  ///   This element specifies the alignment of scripts in the subscript/superscript function. 
  ///   When 1 or true, subscripts and superscripts are aligned to each other. 
  ///   When 0 or false, they are kerned to the shape of the base. 
  ///   If this element is omitted, scripts are not aligned. 
  ///   In other words, when the element is absent, the default is for the sub-superscript object 
  ///   to not align the superscript and subscript with each other
  /// </summary>
  public bool? AlignScripts { get => _AlignScripts; set => UpdateField(ref _AlignScripts, value, nameof(AlignScripts)); }
  private bool? _AlignScripts;

  /// <summary>
  ///   Specifies formatting of SubSuperscript object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }
  private ControlProperties? _ControlProperties;
}