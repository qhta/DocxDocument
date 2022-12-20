namespace DocumentModel.Wordprocessing;

public partial interface Document
{
  public DocumentProperties? Properties { get; set; }
}