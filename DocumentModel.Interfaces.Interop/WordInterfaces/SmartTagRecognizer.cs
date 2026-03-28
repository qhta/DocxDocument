namespace DocumentModel.Interop;

/// <summary>
/// Represents installed components that label text with types of information.
/// </summary>
public interface SmartTagRecognizer : InteropObject
{
  /// <summary>
  /// The full name.
  /// </summary>
  public string FullName { get; }
  /// <summary>
  /// The enabled.
  /// </summary>
  public bool Enabled { get; set; }
  /// <summary>
  /// The prog id.
  /// </summary>
  public string ProgID { get; }
  /// <summary>
  /// The caption.
  /// </summary>
  public string Caption { get; }

}
