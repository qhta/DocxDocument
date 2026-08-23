namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Color Transform Category.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformCategory))]
[DataContract]
[XmlRoot("ColorTransformCategory", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class ColorTransformCategory: ModelElement<DXDD.ColorTransformCategory>
{
  /// <summary>
  ///   Category Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ColorTransformCategory.Type))]
  public string? Type
  {
    get => _Type ??= GetProperty<string?>(GetUpdatableElement()?.Type);
    set => UpdateField(ref _Type, value, nameof(Type));
  }

  private string? _Type;

  /// <summary>
  ///   Priority
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ColorTransformCategory.Priority))]
  public UInt32? Priority
  {
    get => _Priority ??= GetProperty<UInt32?>(GetUpdatableElement()?.Priority);
    set => UpdateField(ref _Priority, value, nameof(Priority));
  }

  private UInt32? _Priority;
}