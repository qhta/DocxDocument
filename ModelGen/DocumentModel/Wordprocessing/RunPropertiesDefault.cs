namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a set of default run properties for the current document. The actual run properties are stored within the rPr child element of the current element.
/// </summary>
public partial class RunPropertiesDefault
{
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesBaseStyle? RunPropertiesBaseStyle { get; set; }
  
}
