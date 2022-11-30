namespace DocumentModel.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div.
/// </summary>
public interface IDivsChild // : DocumentModel.Wordprocessing.IDivsType
{
  public DocumentModel.Wordprocessing.IDiv? Div { get ; set; }
  
}
