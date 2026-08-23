namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Layout.
/// </summary>
[OpenXmlType(typeof(DXDC.Layout))]
[DataContract]
[XmlRoot("Layout", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Layout: ModelElement<DXDC.Layout>
{
  /// <summary>
  ///   Manual Layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Layout.ManualLayout))]
  public ManualLayout? ManualLayout
  {
    get => _ManualLayout ??= GetProperty<ManualLayout?>(GetUpdatableElement()?.ManualLayout);
    set => UpdateField(ref _ManualLayout, value, nameof(ManualLayout));
  }

  private ManualLayout? _ManualLayout;

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Layout.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}