namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ExternalFile<T> 
{
  public bool ShouldSerializeUri() => !String.IsNullOrEmpty(Uri);
}
