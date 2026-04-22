namespace DocumentModel.Vml;
/// <summary>
///   Shape Clipping Path.
/// </summary>
[OpenXmlType(typeof(DXVO.ClipPath))]
[XmlRoot("ClipPath", Namespace = "DocumentModel.Vml")]
public partial class ClipPath : ModelElement<DXVO.ClipPath>
{
 /// <summary>
 ///   Path Definition
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ClipPath.Value))]
 public string? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }
 private string? _Value;
}