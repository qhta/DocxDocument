namespace DocumentModel.Vml;
/// <summary>
///   Shape Clipping Path.
/// </summary>
[OpenXmlType(typeof(DXVO.ClipPath))]
public partial class ClipPath : ModelElement<DXVO.ClipPath>
{
 /// <summary>
 ///   Path Definition
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ClipPath.Value))]
 [OpenXmlElement(typeof(DXVO.ClipPath))]
 public string? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

 private string? _Value;
}