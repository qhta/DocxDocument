namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a border type definition in a WordprocessingML document.
/// This class provides properties for border style, width, and shadow effect, enabling advanced formatting and visual separation of document content.
/// </summary>
[OpenXmlType(typeof(DXW.BorderType))]
public partial class BorderType : ModelElement<DXW.BorderType>
{
 /// <summary>
 /// Border style, specifying the type of border (e.g., single, double, dashed).
 /// </summary>
 public BorderKind? Type { get; set; }
 /// <summary>
 /// Border width, specified as a 64-bit integer value.
 /// </summary>
 public Int64? Width { get; set; }

 /// <summary>
 /// Indicates whether the border has a shadow effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.BorderType.Shadow))]
 public bool? Shadow { get; set; }
}