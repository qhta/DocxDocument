namespace DocumentModel.Drawings;
/// <summary>
/// Represents a foreground mark defined by two coordinate points, typically used to specify areas to retain during background removal processing.
/// </summary>
[OpenXmlType(typeof(DXO10D.ForegroundMark))]
public partial class ForegroundMark : ModelElement<DXO10D.ForegroundMark>
{
 /// <summary>
 /// Gets or sets the X coordinate of the first point.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ForegroundMark.FirstXCoordinate))]
 public Int32? FirstXCoordinate { get => _FirstXCoordinate; set => UpdateField(ref _FirstXCoordinate, value, nameof(FirstXCoordinate)); }
 private Int32? _FirstXCoordinate;
 /// <summary>
 /// Gets or sets the Y coordinate of the first point.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ForegroundMark.FirstYCoordinate))]
 public Int32? FirstYCoordinate { get => _FirstYCoordinate; set => UpdateField(ref _FirstYCoordinate, value, nameof(FirstYCoordinate)); }
 private Int32? _FirstYCoordinate;
 /// <summary>
 /// Gets or sets the X coordinate of the second point.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ForegroundMark.SecondXCoordinate))]
 public Int32? SecondXCoordinate { get => _SecondXCoordinate; set => UpdateField(ref _SecondXCoordinate, value, nameof(SecondXCoordinate)); }
 private Int32? _SecondXCoordinate;
 /// <summary>
 /// Gets or sets the Y coordinate of the second point.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ForegroundMark.SecondYCoordinate))]
 public Int32? SecondYCoordinate { get => _SecondYCoordinate; set => UpdateField(ref _SecondYCoordinate, value, nameof(SecondYCoordinate)); }
 private Int32? _SecondYCoordinate;
}