namespace DocumentModel;


/// <summary>
///   Defines the Markup Compatibility Attributes.
/// </summary>
public partial class MarkupCompatibilityAttributes
{
  
  /// <summary>
  ///   Gets or sets a whitespace-delimited list of prefixes, where each
             prefix identifies an ignorable namespace.
  /// </summary>
  public String? Ignorable { get; set; }
  
  
  /// <summary>
  ///   Gets or sets a whitespace-delimited list of element-qualified names
             that identify the expanded names of elements. The content of the
             elements shall be processed, even if the elements themselves are
             ignored.
  /// </summary>
  public String? ProcessContent { get; set; }
  
  
  /// <summary>
  ///   Gets or sets a whitespace-delimited list of element qualified names
             that identify the expanded names of elements. The elements are suggested
             by a markup producer for preservation by markup editors, even if
             the elements themselves are ignored.
  /// </summary>
  public String? PreserveElements { get; set; }
  
  
  /// <summary>
  ///   Gets or sets a whitespace-delimited list of attribute qualified names
             that identify expanded names of attributes. The attributes were
             suggested by a markup producer for preservation by markup editors.
  /// </summary>
  public String? PreserveAttributes { get; set; }
  
  
  /// <summary>
  ///   Gets or sets a whitespace-delimited list of prefixes that identify
             a set of namespace names.
  /// </summary>
  public String? MustUnderstand { get; set; }
  
}
