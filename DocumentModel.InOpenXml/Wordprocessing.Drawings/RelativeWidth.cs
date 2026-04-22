namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the relative width settings for a drawing element in a Wordprocessing document.
/// This class provides configuration for horizontal size adjustment, including the reference object and percentage width relative to another element.
/// </summary>
[OpenXmlType(typeof(DXO10WD.RelativeWidth))]
[XmlRoot("RelativeWidth", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class RelativeWidth : ModelElement<DXO10WD.RelativeWidth>
{
 /// <summary>
 /// The reference object used to determine the relative horizontal sizing, such as margin, page, or paragraph.
 /// </summary>
 public RelativeHorizontalSize? ObjectId { get => _ObjectId; set => UpdateField(ref _ObjectId, value, nameof(ObjectId)); }
 private RelativeHorizontalSize? _ObjectId;

 /// <summary>
 /// The percentage value specifying the width of the drawing element relative to the reference object.
 /// </summary>
 public string? PercentageWidth { get => _PercentageWidth; set => UpdateField(ref _PercentageWidth, value, nameof(PercentageWidth)); }
 private string? _PercentageWidth;
}