namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents base data for a numeric data source type.
/// </summary>
[OpenXmlType(typeof(DXDC.NumberDataType))]
[DataContract]
[XmlRoot("NumberDataType", Namespace = "DocumentModel.Drawings.Charts")]
public partial class NumberDataType: ModelElement<DXDC.NumberDataType>
{
  /// <summary>
  ///   Format code applied to the numeric data.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.NumberDataType.FormatCode))]
  public string? FormatCode
  {
    get => _FormatCode ??= GetProperty<string?>(GetUpdatableElement()?.FormatCode);
    set => UpdateField(ref _FormatCode, value, nameof(FormatCode));
  }

  private string? _FormatCode;

  /// <summary>
  ///   Number of points in the data set.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.NumberDataType.PointCount))]
  public UInt32? PointCount
  {
    get => _PointCount ??= GetProperty<UInt32?>(GetUpdatableElement()?.PointCount);
    set => UpdateField(ref _PointCount, value, nameof(PointCount));
  }

  private UInt32? _PointCount;
}