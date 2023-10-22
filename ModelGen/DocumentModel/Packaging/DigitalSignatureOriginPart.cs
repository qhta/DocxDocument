namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type is the starting point for navigating through the signatures in a package.
/// </summary>
public partial class DigitalSignatureOriginPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
