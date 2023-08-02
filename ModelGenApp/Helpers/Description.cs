namespace ModelGenApp.Helpers
{
  public struct Description
  {
    public Description(string value)
    {
      Value = value;
    }
    public string Value { get; set; }

    public override string ToString() => Value;
  }
}
