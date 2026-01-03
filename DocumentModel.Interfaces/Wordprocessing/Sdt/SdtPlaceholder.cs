namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtPlaceholder Class.
/// </summary>
public interface SdtPlaceholder: IModelElement
{
  /// <summary>
  ///   Document Part Reference.
  /// </summary>
  public string? DocPartReference { get; set; }
}