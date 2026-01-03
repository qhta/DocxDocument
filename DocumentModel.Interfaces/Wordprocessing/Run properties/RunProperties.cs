namespace DocumentModel.Wordprocessing;
/// <summary>
///   Run Properties.
/// </summary>
public interface RunProperties: ExtBaseRunProperties
{
  /// <summary>
  ///   RunPropertiesChange.
  /// </summary>
  public RunPropertiesChange? RunPropertiesChange { get; set; }
}