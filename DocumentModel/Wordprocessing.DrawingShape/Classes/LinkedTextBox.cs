namespace DocumentModel.Wordprocessing.DrawingShape;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the LinkedTextBox Class.
/// </summary>
public class LinkedTextBox: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public UInt16? Id { get; set; }

  /// <summary>
  ///   seq, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public UInt16? Sequence { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}
