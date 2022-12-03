namespace DocumentModel;

/// <summary>
/// Defines an mc:Choice element in mc:AlternateContent.
/// </summary>
public interface AlternateContentChoice // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Gets or sets a whitespace-delimited list of namespace prefixes that identify the
  /// </summary>
  public String? Requires { get ; set; }
  
}
