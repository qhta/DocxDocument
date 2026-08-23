namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the name of a glossary document entry or building block in a WordprocessingML document.
/// This class provides properties for the entry name value and a flag indicating whether the entry is built-in, enabling advanced management and identification of reusable document parts.
/// </summary>
[OpenXmlType(typeof(DXW.DocPartName))]
[DataContract]
[XmlRoot("DocPartName", Namespace = "DocumentModel.Wordprocessing")]
public partial class DocPartName: ModelElement<DXW.DocPartName>
{
  /// <summary>
  /// Name value of the entry, specifying the unique identifier or display name for the glossary document entry.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DocPartName.Val))]
  public string? Val
  {
    get => _Val ??= GetProperty<string?>(GetUpdatableElement()?.Val);
    set => UpdateField(ref _Val, value, nameof(Val));
  }

  private string? _Val;

  /// <summary>
  /// Indicates whether the entry is a built-in (decorated) entry.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DocPartName.Decorated))]
  public bool? Decorated
  {
    get => _Decorated ??= GetProperty<bool?>(GetUpdatableElement()?.Decorated);
    set => UpdateField(ref _Decorated, value, nameof(Decorated));
  }

  private bool? _Decorated;
}