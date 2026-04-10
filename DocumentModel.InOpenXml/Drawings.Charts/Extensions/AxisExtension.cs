namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for an axis, providing additional numbering format options.
/// </summary>
[XmlRoot("AxisExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class AxisExtension<T> : Extension<T> where T : DX.OpenXmlElement
{
 /// <summary>
 ///   Numbering format configuration for the category axis extension.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.NumberingFormat))]
 public NumberingFormat3? NumberingFormat { get => _NumberingFormat; set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat)); }

 private NumberingFormat3? _NumberingFormat;
}