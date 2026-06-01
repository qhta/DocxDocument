namespace DocumentModel.Wordprocessing.DrawingShape;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TextBoxInfo2 Class.
/// </summary>
public class TextBoxInfo2: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2010 and later.
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
