namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentText Class.
/// </summary>
public interface SdtContentText: IModelElement
{
  /// <summary>
  ///   Allow Soft Line Breaks
  /// </summary>
  public bool? MultiLine { get; set; }
}