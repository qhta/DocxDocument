namespace DocumentModel;

/// <summary>
/// Defines an mc:Choice element in mc:AlternateContent.
/// </summary>
public interface IAlternateContentChoice // : DocumentModel.IOpenXmlCompositeElement
{
  /// <summary>
  /// Gets the local name of the Choice element.
  /// </summary>
  public String? LocalName { get ; set; }
  
  /// <summary>
  /// Gets or sets a whitespace-delimited list of namespace prefixes that identify the
  /// </summary>
  public String? Requires { get ; set; }
  
}
