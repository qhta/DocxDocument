namespace DocumentModel;

/// <summary>
/// Defines an mc:Choice element in mc:AlternateContent.
/// </summary>
public interface IAlternateContentChoice // : DocumentModel.IOpenXmlCompositeElement
{
  /// <summary>
  /// Gets or sets a whitespace-delimited list of namespace prefixes that identify the
  /// </summary>
  public System.String? Requires { get ; set; }
  
}
