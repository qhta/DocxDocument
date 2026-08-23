namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the BackstageItemType Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is :.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.BackstageItemType))]
[DataContract]
[XmlRoot("BackstageItemType", Namespace = "DocumentModel.CustomUI")]
public abstract partial class BackstageItemType : ModelElement<DXO10CUI.BackstageItemType>
{
  /// <summary>
  /// Specifies the unique identifier of the Backstage item.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageItemType.Id))]
  public String? Id
  {
    get => _Id ??= GetProperty<String?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private String? _Id;

  /// <summary>
  /// Specifies the display label of the Backstage item.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageItemType.Label))]
  public String? Label
  {
    get => _Label ??= GetProperty<String?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns the item label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageItemType.GetLabel))]
  public String? GetLabel
  {
    get => _GetLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private String? _GetLabel;
}