namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Recipients.
/// </summary>
public interface Recipients // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<RecipientData>? RecipientDatas { get ; set; }
  
}
