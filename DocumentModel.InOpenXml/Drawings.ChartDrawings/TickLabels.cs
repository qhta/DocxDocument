namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TickLabels Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.TickLabels))]
[DataContract]
[XmlRoot("TickLabels", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class TickLabels: ModelElement<DXO16DCD.TickLabels>
{
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.TickLabels.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}