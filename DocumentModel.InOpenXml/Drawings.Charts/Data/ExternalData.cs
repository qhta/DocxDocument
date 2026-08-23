namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents external data referenced by a chart.
///   This class defines the relationship to the external data source and whether it should update automatically.
/// </summary>
[OpenXmlType(typeof(DXDC.ExternalData))]
[DataContract]
[XmlRoot("ExternalData", Namespace = "DocumentModel.Drawings.Charts")]
public partial class ExternalData: ModelElement<DXDC.ExternalData>
{
  /// <summary>
  ///   Relationship reference identifier to the external data part.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ExternalData.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   Indicates whether the data source updates automatically when the chart is refreshed.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ExternalData.AutoUpdate))]
  public bool? AutoUpdate
  {
    get => _AutoUpdate ??= GetProperty<bool?>(GetUpdatableElement()?.AutoUpdate);
    set => UpdateField(ref _AutoUpdate, value, nameof(AutoUpdate));
  }

  private bool? _AutoUpdate;
}