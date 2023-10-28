namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class NonVisualPicturePropertiesExtension
{
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  public String? Uri { get; set; }
  
  public DMD10.CameraTool? CameraTool { get; set; }
  
  public DMD.SignatureLine? SignatureLine { get; set; }
  
  public DMD.ObjectProperties? ObjectProperties { get; set; }
  
  public DMD.LiveFeedProperties? LiveFeedProperties { get; set; }
  
  public DMDIF.ImageFormula? ImageFormula { get; set; }
  
}
