namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Recipients.
/// </summary>
public interface Recipients: IModelElement
{
  public RecipientData? RecipientData { get; set; }
}