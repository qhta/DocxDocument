namespace DocumentModel;
#pragma warning disable CS1591
public partial class Extension<T> : IExtension
{
  public bool ShouldSerializeUri() => !String.IsNullOrEmpty(Uri);
}
