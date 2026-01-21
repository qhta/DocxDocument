namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single automatic captioning setting in a Wordprocessing document.
///   This class provides properties for the object identifier and the caption used for automatic captioning, enabling configuration and management of automatic captions for document objects.
/// </summary>
public class AutoCaption: ModelElement<DXW.AutoCaption>
{

  /// <summary>
  /// Specifies a unique identifier which can be used to associate objects inserted into the document
  /// which are to be automatically labeled with a caption when inserted into the WordprocessingML document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Caption.Name))]
  public string? Name
  {
    get => _Name;
    set => UpdateField(ref _Name, value, nameof(Name));
  }
  private string? _Name;

  /// <summary>
  /// Specifies the caption defined in using the caption element (§17.15.1.16) which shall be
  /// used to automatically label a given type of object inserted in a WordprocessingML
  /// document. The caption settings are linked by matching the value of this attribute with
  /// the name attribute of the corresponding caption element.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.AutoCaption.Caption))]
  public string? Caption
  {
    get => _Caption;
    set => UpdateField(ref _Caption, value, nameof(Caption));
  }
  private string? _Caption;
}