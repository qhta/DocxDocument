namespace DocumentModel.Drawings;
/// <summary>
/// Represents a background mark defined by two coordinate points, typically used to specify a rectangular region or line in the background.
/// </summary>
[OpenXmlType(typeof(DXO10D.BackgroundMark))]
[XmlRoot("BackgroundMark", Namespace = "DocumentModel.Drawings")]
public partial class BackgroundMark : ModelElement<DXO10D.BackgroundMark>
{
 /// <summary>
 /// Gets or sets the X coordinate of the first point.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.BackgroundMark.FirstXCoordinate))]
 public Int32? FirstXCoordinate { get => _FirstXCoordinate; set => UpdateField(ref _FirstXCoordinate, value, nameof(FirstXCoordinate)); }

 private Int32? _FirstXCoordinate;
 /// <summary>
 /// Gets or sets the Y coordinate of the first point.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.BackgroundMark.FirstYCoordinate))]
 public Int32? FirstYCoordinate { get => _FirstYCoordinate; set => UpdateField(ref _FirstYCoordinate, value, nameof(FirstYCoordinate)); }

 private Int32? _FirstYCoordinate;
 /// <summary>
 /// Gets or sets the X coordinate of the second point.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.BackgroundMark.SecondXCoordinate))]
 public Int32? SecondXCoordinate { get => _SecondXCoordinate; set => UpdateField(ref _SecondXCoordinate, value, nameof(SecondXCoordinate)); }

 private Int32? _SecondXCoordinate;
 /// <summary>
 /// Gets or sets the Y coordinate of the second point.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.BackgroundMark.SecondYCoordinate))]
 public Int32? SecondYCoordinate { get => _SecondYCoordinate; set => UpdateField(ref _SecondYCoordinate, value, nameof(SecondYCoordinate)); }

 private Int32? _SecondYCoordinate;
}