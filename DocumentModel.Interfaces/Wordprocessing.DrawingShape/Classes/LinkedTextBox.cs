namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
///   Defines the LinkedTextBox Class.
/// </summary>
public interface LinkedTextBox:
{
  /// <summary>
  ///   id
  /// </summary>
  public UInt16? Id { get; set; }
  /// <summary>
  ///   seq
  /// </summary>
  public UInt16? Sequence { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}