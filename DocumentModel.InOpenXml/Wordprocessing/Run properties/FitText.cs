namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the fit text effect for a text run, enabling the text to be compressed or expanded to fit a specified width.
/// This class provides properties for identifying the fit text run and specifying the target width in twips, allowing advanced text layout control in WordprocessingML documents.
/// </summary>
[OpenXmlType(typeof(DXW.FitText))]
[DataContract]
[XmlRoot("FitText", Namespace = "DocumentModel.Wordprocessing")]
public partial class FitText: ModelElement<DXW.FitText>
{
  /// <summary>
  /// Identifier for the fit text run, used to distinguish multiple fit text effects within the same document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FitText.Id))]
  public Int32? Id
  {
    get => _Id ??= GetProperty<Int32?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private Int32? _Id;

  /// <summary>
  /// Target width for the fit text effect, specified in twips. The text is compressed or expanded to fit this width.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FitText.Val))]
  public Twips? Width
  {
    get => _width ??= GetProperty<Twips?>(GetUpdatableElement()?.Val);
    set => UpdateField(ref _width, value, nameof(Width));
  }

  private Twips? _width;
}