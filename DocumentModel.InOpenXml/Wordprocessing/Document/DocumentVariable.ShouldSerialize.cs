namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocumentVariable
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeValue() => !String.IsNullOrEmpty(Value);
}
