namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDefinitionTitle))]
[DataContract]
[XmlRoot("StyleDefinitionTitle", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class StyleDefinitionTitle: ModelElement<DXDD.StyleDefinitionTitle>
{
  /// <summary>
  ///   Natural Language
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleDefinitionTitle.Language))]
  public string? Language
  {
    get => _Language ??= GetProperty<string?>(GetUpdatableElement()?.Language);
    set => UpdateField(ref _Language, value, nameof(Language));
  }

  private string? _Language;

  /// <summary>
  ///   Description Value
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleDefinitionTitle.Val))]
  public string? Val
  {
    get => _Val ??= GetProperty<string?>(GetUpdatableElement()?.Val);
    set => UpdateField(ref _Val, value, nameof(Val));
  }

  private string? _Val;
}