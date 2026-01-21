namespace DocumentModel.Wordprocessing;

public partial class ExternalFile<T> 
{
  public bool ShouldSerializeUri() => Uri is not null;
}
