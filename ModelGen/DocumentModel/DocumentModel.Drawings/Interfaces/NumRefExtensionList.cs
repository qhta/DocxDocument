namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public interface NumRefExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<NumRefExtension>? NumRefExtensions { get ; set; }
  
}
