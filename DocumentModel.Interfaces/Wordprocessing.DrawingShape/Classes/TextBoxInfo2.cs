namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
///   Defines the TextBoxInfo2 Class.
/// </summary>
public interface TextBoxInfo2: IModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public UInt16? Id { get; set; }
  /// <summary>
  ///   TextBoxContent.
  /// </summary>
  public TextBoxContent? TextBoxContent { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}